using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Collections;


//************************************************************************//
// This project makes an extremely simple server to connect to the other  //
// traffic light clients.  Because of the personal firewall on the lab    //
// computers being switched on, the server cannot use a listening socket  //
// accept incomming connections.  So the server to actually connects to a //
// sort of proxy (running in my office) that accepts the incomming        //
// connection.                                                            //    
// By Nigel.                                                              //
//                                                                        //
// Please use this code, sich as it is,  for any eduactional or non       //
// profit making research porposes on the conditions that.                //
//                                                                        //
// 1.    You may only use it for educational and related research         //
//      pusposes.                                                         //
//                                                                        //
// 2.   You leave my name on it.                                          //
//                                                                        //
// 3.   You correct at least 10% of the typig and spekking mistskes.      //
//                                                                        //
// © Nigel Barlow nigel@soc.plymouth.ac.uk 2018                           //
//************************************************************************//

namespace TrafficLightServer
{

    //New wrapper class.
    public delegate void UI_UpdateHandler(String message);

    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
        }


        //******************************************************//
        // Nigel Networking attributes.                         //
        //******************************************************//
        private int serverPort = 5000;
        private int bufferSize = 200;
        private TcpClient socketClient = null;
        private String serverName = "eeyore.fost.plymouth.ac.uk";  //A computer in my office.
        private NetworkStream connectionStream = null;
        private BinaryReader inStream = null;
        private BinaryWriter outStream = null;
        private ThreadConnection threadConnection = null;


        //*******************************************************************//
        // This one is needed so that we can post messages back to the form's//
        // thread and don't violate C#'s threading rule that says you can    //
        // only touch the UI components from the form's thread.              //
        //*******************************************************************//
        private SynchronizationContext uiContext = null;



        //*********************************************************************//
        // Form load.  Display an IP. Or a series of IPs.                      //                               
        //*********************************************************************//
        private void Form1_Load(object sender, EventArgs e)
        {
            //******************************************************************//
            //All this to find out IP number.                                   //
            //******************************************************************//
            IPHostEntry localHostInfo = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            listBoxOutput.Items.Add("You may have many IP numbers.");
            listBoxOutput.Items.Add("In the Plymouth labs, use the IP that looks like an IP4 number");
            listBoxOutput.Items.Add("something like 10.xx.xx.xx.");
            listBoxOutput.Items.Add("If at home using a VPN use the IP4 number that starts");
            listBoxOutput.Items.Add("something like 141.163.xx.xx");
            listBoxOutput.Items.Add(" ");


            foreach (IPAddress address in localHostInfo.AddressList)
                listBoxOutput.Items.Add(address.ToString());


            //******************************************************************//
            // Get the SynchronizationContext for the current thread (the form's//
            // thread).                                                         //
            //******************************************************************//
            uiContext = SynchronizationContext.Current;
            if (uiContext == null)
                listBoxOutput.Items.Add("No context for this thread");
            else
                listBoxOutput.Items.Add("We got a context");

        }



        //*********************************************************************//
        // The OnClick for the "connect"command button.  Create a new client   //
        // socket.   Much of this code is exception processing.                //
        //*********************************************************************//
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                socketClient = new TcpClient(serverName, serverPort);
            }
            catch (Exception ee)
            {
                listBoxOutput.Items.Add("Error in connecting to server");     //Console is a sealed object; we
                listBoxOutput.Items.Add(ee.Message);				 	       //can't make it, we can just access
                labelStatus.Text = "Error " + ee.Message;
                labelStatus.BackColor = Color.Red;
            }

            if (socketClient == null)
            {
                listBoxOutput.Items.Add("Socket not connected");

            }
            else
            {

                //**************************************************//
                // Make some streams.  They have rather more        //
                // capabilities than just a socket.  With this type //
                // of socket, we can't read from it and write to it //
                // directly.                                        //
                //**************************************************//
                connectionStream = socketClient.GetStream();
                inStream = new BinaryReader(connectionStream);
                outStream = new BinaryWriter(connectionStream);

                listBoxOutput.Items.Add("Socket connected to " + serverName);

                labelStatus.BackColor = Color.Green;
                labelStatus.Text = "Connected to " + serverName;


                //**********************************************************//
                // Discale connect button (we can only connect once) and    //
                // enable other components.                                 //
                //**********************************************************//
                buttonConnect.Enabled = false;
                comboBoxLightColour.Enabled = true;
                cbxLightsTwo.Enabled = true;

                //**********************************************************//
                // Start timers                                             //
                //**********************************************************//
                timer1.Start();
                timer2.Start();

                //***********************************************************//
                //We have now accepted a connection.                         //
                //                                                           //
                //There are several ways to do this next bit.   Here I make a//
                //network stream and use it to create two other streams, an  //
                //input and an output stream.   Life gets easier at that     //
                //point.                                                     //
                //***********************************************************//
                threadConnection = new ThreadConnection(uiContext, socketClient, this);

                //***********************************************************//
                // Create a new Thread to manage the connection that receives//
                // data.  If you are a Java programmer, this looks like a    //
                // load of hokum cokum..                                     //
                //***********************************************************//
                Thread threadRunner = new Thread(new ThreadStart(threadConnection.run));
                threadRunner.Start();

                Console.WriteLine("Created new connection class");

            }
        }






        //*********************************************************************//
        // The item in the combo box has been changed.  Transmit it.           // 
        //*********************************************************************//
        private void comboBoxLightColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            String toSendIP = textBoxLightIP.Text;
            String colour = (String)comboBoxLightColour.SelectedItem;
            sendString(colour, toSendIP);
        }




        //**********************************************************************//
        // Send a string to the IP you give.  The string and IP are bundled up  //
        // into one of there rather quirky Nigel style packets.                 // 
        //                                                                      //
        // This uses the pre-defined stream outStream.  If this strean doesn't  //
        // exist then this method will bomb.                                    //
        //                                                                      //
        // It also does the networking synchronously, in the form's main        //
        // Thread.  This is not good practise; all networking should really be  //
        // asynchronous.                                                        //
        //**********************************************************************//
        private void sendString(String stringToSend, String sendToIP)
        {

            try
            {
                byte[] packet = new byte[bufferSize];
                String[] ipStrings = sendToIP.Split('.'); //Split with . as separator

                packet[0] = Byte.Parse(ipStrings[0]);
                packet[1] = Byte.Parse(ipStrings[1]);   //Think about this.  It assumes the user
                packet[2] = Byte.Parse(ipStrings[2]);   //has entered the IP corrrectly, and 
                packet[3] = Byte.Parse(ipStrings[3]);   //sends the numbers without the bytes.

                int bufferIndex = 4;                    //Start assembling message

                //**************************************************************//
                // Turn the string into an array of characters.                 //
                //**************************************************************//
                int length = stringToSend.Length;
                char[] chars = stringToSend.ToCharArray();


                //**************************************************************//
                // Then turn each character into a byte and copy into my packet.//
                //**************************************************************//
                for (int i = 0; i < length; i++)
                {
                    byte b = (byte)chars[i];
                    packet[bufferIndex] = b;
                    bufferIndex++;
                }

                packet[bufferIndex] = 0;    //End of packet (even though it is always 200 bytes)

                outStream.Write(packet, 0, bufferSize);
                listBoxOutput.Items.Add("Sent " + stringToSend);
            }
            catch (Exception doh)
            {
                listBoxOutput.Items.Add("An error occurred: " + doh.Message);
            }

        }


        //*********************************************************************//
        // Message was posted back to us.  This is to get over the C# threading//
        // rules whereby we can only touch the UI components from the thread   //
        // that created them, which is the form's main thread.                 // 
        //*********************************************************************//
        ArrayList carsW = new ArrayList();
        ArrayList carsN = new ArrayList();
        ArrayList carsS = new ArrayList();
        ArrayList carsE = new ArrayList();
        int counterWest;
        int counterNorth;
        int counterSouth;
        int counterEast;
        public void MessageReceived(Object received)
        {
            String message = (String)received;
            listBoxOutput.Items.Add(message);
            Console.WriteLine(message);
            if (message.Contains("LoadCars"))
            {
                String toSendIP = textBoxLightIP.Text;

                String noCarsWest = ($"*W{counterWest}");
                sendString(noCarsWest, toSendIP);

                String noCarsEast = ($"*E{counterEast}");
                sendString(noCarsEast, toSendIP);

                String noCarsNorth = ($"*N{counterNorth}");
                sendString(noCarsNorth, toSendIP);

                String noCarsSouth = ($"*S{counterSouth}");
                sendString(noCarsSouth, toSendIP);
            }
            if (message.Contains("West"))
            {
                for (int CounterWest = 0; CounterWest < 1; CounterWest++)
                {
                    counterWest = counterWest + 1;
                    carsW.Add(counterWest);
                    CarArrayW();
                    lblOutputWest.Text = Convert.ToString($"Cars West - Number Of Cars West: {counterWest}");

                    String toSendIP = textBoxLightIP.Text;
                    String noCarsWest = ($"*W{counterWest}");
                    sendString(noCarsWest, toSendIP);
                }
                if (counterWest == 10)
                {
                    String toSendIP = textBoxLightIP.Text;
                    String colour = ("Green1");
                    sendString(colour, toSendIP);
                    counterWest = 0;
                    counterEast = 0;
                    lblOutputWest.Text = Convert.ToString($"Cars West - Number Of Cars West: {counterWest}");
                    lblOutputEast.Text = Convert.ToString($"Cars East - Number Of Cars East: {counterEast}");
                    System.Threading.Thread.Sleep(1000);
                    changeToRed1();

                    String noCarsWest = ($"*W{counterWest}");
                    sendString(noCarsWest, toSendIP);

                    timer2.Stop();
                    timer2.Start();
                }
            }
            if (message.Contains("East"))
            {
                for (int CounterEast = 0; CounterEast < 1; CounterEast++)
                {
                    counterEast = counterEast + 1;
                    carsE.Add(counterEast);
                    CarArrayE();
                    lblOutputEast.Text = Convert.ToString($"Cars East - Number Of Cars East: {counterEast}");

                    String toSendIP = textBoxLightIP.Text;
                    String noCarsEast = ($"*E{counterEast}");
                    sendString(noCarsEast, toSendIP);
                }
                if (counterEast == 10)
                {
                    String toSendIP = textBoxLightIP.Text;
                    String colour = ("Green1");
                    sendString(colour, toSendIP);
                    counterEast = 0;
                    counterWest = 0;
                    lblOutputEast.Text = Convert.ToString($"Cars East - Number Of Cars East: {counterEast}");
                    lblOutputWest.Text = Convert.ToString($"Cars West - Number Of Cars West: {counterWest}");
                    System.Threading.Thread.Sleep(1000);
                    changeToRed1();

                    String noCarsEast = ($"*E{counterEast}");
                    sendString(noCarsEast, toSendIP);

                    timer2.Stop();
                    timer2.Start();
                }
            }

            if (message.Contains("North"))
            {
                for (int CounterNorth = 0; CounterNorth < 1; CounterNorth++)
                {
                    counterNorth = counterNorth + 1;
                    carsN.Add(counterNorth);
                    CarArrayN();
                    lblOutputNorth.Text = Convert.ToString($"Cars North - Number Of Cars North: {counterNorth}");

                    String toSendIP = textBoxLightIP.Text;
                    String noCarsNorth = ($"*N{counterNorth}");
                    sendString(noCarsNorth, toSendIP);
                }
                if (counterNorth == 10)
                {
                    String toSendIP = textBoxLightIP.Text;
                    String colour = ("Green2");
                    sendString(colour, toSendIP);
                    counterNorth = 0;
                    counterSouth = 0;
                    lblOutputNorth.Text = Convert.ToString($"Cars North - Number Of Cars North: {counterNorth}");
                    lblOutputSouth.Text = Convert.ToString($"Cars South - Number Of Cars South: {counterSouth}");
                    System.Threading.Thread.Sleep(1000);
                    changeToRed2();

                    String noCarsNorth = ($"*N{counterNorth}");
                    sendString(noCarsNorth, toSendIP);

                    timer1.Stop();
                    timer1.Start();
                }
            }

            if (message.Contains("South"))
            {
                for (int CounterSouth = 0; CounterSouth < 1; CounterSouth++)
                {
                    counterSouth = counterSouth + 1;
                    carsS.Add(counterSouth);
                    CarArrayS();
                    lblOutputSouth.Text = Convert.ToString($"Cars South - Number Of Cars South: {counterSouth}");

                    String toSendIP = textBoxLightIP.Text;
                    String noCarsSouth = ($"*S{counterSouth}");
                    sendString(noCarsSouth, toSendIP);
                }
                if (counterSouth == 10)
                {
                    String toSendIP = textBoxLightIP.Text;
                    String colour = ("Green2");
                    sendString(colour, toSendIP);
                    counterNorth = 0;
                    counterSouth = 0;
                    lblOutputSouth.Text = Convert.ToString($"Cars South - Number Of Cars South: {counterSouth}");
                    lblOutputNorth.Text = Convert.ToString($"Cars North - Number Of Cars North: {counterNorth}");
                    System.Threading.Thread.Sleep(1000);
                    changeToRed2();

                    String noCarsSouth = ($"*S{counterSouth}");
                    sendString(noCarsSouth, toSendIP);

                    timer1.Stop();
                    timer1.Start();
                }
            }
        }

        public void changeToRed1()
        {
            String toSendIP = textBoxLightIP.Text;
            String colour = ("Red1");
            sendString(colour, toSendIP);
        }
        public void changeToRed2()
        {
            String toSendIP = textBoxLightIP.Text;
            String colour = ("Red2");
            sendString(colour, toSendIP);
        }

        public void CarArrayW()
        {


            foreach (int item in carsW)
            {
                lblOutputWest.Text = Convert.ToString($"Number Of Cars: {counterWest}");

            }


        }
        public void CarArrayN()
        {


            foreach (int item in carsN)
            {
                lblOutputNorth.Text = Convert.ToString($"Number Of Cars: {counterNorth}");

            }


        }

        public void CarArrayS()
        {


            foreach (int item in carsS)
            {
                lblOutputSouth.Text = Convert.ToString($"Number Of Cars: {counterSouth}");

            }


        }
        public void CarArrayE()
        {


            foreach (int item in carsE)
            {
                lblOutputEast.Text = Convert.ToString($"Number Of Cars: {counterEast}");

            }


        }




        //*********************************************************************//
        // Form closing.  If the connection thread was ever created then kill  //
        // it off.                                                             //                               
        //*********************************************************************//
        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadConnection != null) threadConnection.StopThread();
        }

        private void listBoxOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbloutput_Click(object sender, EventArgs e)
        {

        }

        private void cbxLightsTwo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String toSendIP = textBoxLightIP.Text;
            String colour2 = (String)cbxLightsTwo.SelectedItem;
            sendString(colour2, toSendIP);
        }

        //int timeLeftNS;
        //int timeLeftEW;

        private void timer1_Tick(object sender, EventArgs e)
        {

            String toSendIP = textBoxLightIP.Text;
            String colour = ("Green2");
            sendString(colour, toSendIP);
            counterNorth = 0;
            counterSouth = 0;
            lblOutputSouth.Text = Convert.ToString($"Cars South - Number Of Cars South: {counterSouth}");
            lblOutputNorth.Text = Convert.ToString($"Cars North - Number Of Cars North: {counterNorth}");
            System.Threading.Thread.Sleep(1000);
            changeToRed2();

            String noCarsSouth = ($"*S{counterSouth}");
            sendString(noCarsSouth, toSendIP);

            String noCarsNorth = ($"*N{counterNorth}");
            sendString(noCarsNorth, toSendIP);

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            String toSendIP = textBoxLightIP.Text;
            String colour = ("Green1");
            sendString(colour, toSendIP);
            counterEast = 0;
            counterWest = 0;
            lblOutputEast.Text = Convert.ToString($"Cars East - Number Of Cars East: {counterEast}");
            lblOutputWest.Text = Convert.ToString($"Cars West - Number Of Cars West: {counterWest}");
            System.Threading.Thread.Sleep(1000);
            changeToRed1();

            String noCarsEast = ($"*E{counterEast}");
            sendString(noCarsEast, toSendIP);

            String noCarsWest = ($"*W{counterWest}");
            sendString(noCarsWest, toSendIP);

        }
    }   // End of classy class.
}       // End of namespace
