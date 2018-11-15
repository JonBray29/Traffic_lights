namespace TrafficLight
{
    partial class FormTrafficLight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLightIP = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonCarArrived = new System.Windows.Forms.Button();
            this.picLightEast = new System.Windows.Forms.PictureBox();
            this.picLightWest = new System.Windows.Forms.PictureBox();
            this.picBus = new System.Windows.Forms.PictureBox();
            this.timerCountdownNS = new System.Windows.Forms.Timer(this.components);
            this.picNorth = new System.Windows.Forms.PictureBox();
            this.picSouth = new System.Windows.Forms.PictureBox();
            this.btnArrivedNorth = new System.Windows.Forms.Button();
            this.btnArrivedSouth = new System.Windows.Forms.Button();
            this.btnArrivedEast = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lblWest = new System.Windows.Forms.Label();
            this.lblNorth = new System.Windows.Forms.Label();
            this.lblEast = new System.Windows.Forms.Label();
            this.lblSouth = new System.Windows.Forms.Label();
            this.timerCountdownEW = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLightEast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightWest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNorth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSouth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "IP number of server";
            // 
            // textBoxLightIP
            // 
            this.textBoxLightIP.Location = new System.Drawing.Point(134, 93);
            this.textBoxLightIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLightIP.Name = "textBoxLightIP";
            this.textBoxLightIP.Size = new System.Drawing.Size(88, 20);
            this.textBoxLightIP.TabIndex = 10;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(238, 32);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 18);
            this.labelStatus.TabIndex = 9;
            this.labelStatus.Text = "Status";
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(9, 206);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(336, 160);
            this.listBoxOutput.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(44, 24);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(176, 31);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connect to sort of proxy";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonCarArrived
            // 
            this.buttonCarArrived.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCarArrived.Enabled = false;
            this.buttonCarArrived.Location = new System.Drawing.Point(116, 184);
            this.buttonCarArrived.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCarArrived.Name = "buttonCarArrived";
            this.buttonCarArrived.Size = new System.Drawing.Size(105, 19);
            this.buttonCarArrived.TabIndex = 15;
            this.buttonCarArrived.Text = "Car Arrived West";
            this.buttonCarArrived.UseVisualStyleBackColor = true;
            this.buttonCarArrived.Click += new System.EventHandler(this.buttonCarArrived_Click);
            // 
            // picLightEast
            // 
            this.picLightEast.BackColor = System.Drawing.Color.Red;
            this.picLightEast.Location = new System.Drawing.Point(549, 179);
            this.picLightEast.Name = "picLightEast";
            this.picLightEast.Size = new System.Drawing.Size(8, 106);
            this.picLightEast.TabIndex = 17;
            this.picLightEast.TabStop = false;
            // 
            // picLightWest
            // 
            this.picLightWest.BackColor = System.Drawing.Color.Red;
            this.picLightWest.Location = new System.Drawing.Point(470, 179);
            this.picLightWest.Name = "picLightWest";
            this.picLightWest.Size = new System.Drawing.Size(8, 103);
            this.picLightWest.TabIndex = 18;
            this.picLightWest.TabStop = false;
            // 
            // picBus
            // 
            this.picBus.BackColor = System.Drawing.Color.Yellow;
            this.picBus.Location = new System.Drawing.Point(430, 206);
            this.picBus.Name = "picBus";
            this.picBus.Size = new System.Drawing.Size(34, 21);
            this.picBus.TabIndex = 20;
            this.picBus.TabStop = false;
            // 
            // timerCountdownNS
            // 
            this.timerCountdownNS.Interval = 10000;
            this.timerCountdownNS.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picNorth
            // 
            this.picNorth.BackColor = System.Drawing.Color.Red;
            this.picNorth.Location = new System.Drawing.Point(455, 191);
            this.picNorth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picNorth.Name = "picNorth";
            this.picNorth.Size = new System.Drawing.Size(110, 8);
            this.picNorth.TabIndex = 22;
            this.picNorth.TabStop = false;
            // 
            // picSouth
            // 
            this.picSouth.BackColor = System.Drawing.Color.Red;
            this.picSouth.Location = new System.Drawing.Point(456, 266);
            this.picSouth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSouth.Name = "picSouth";
            this.picSouth.Size = new System.Drawing.Size(110, 8);
            this.picSouth.TabIndex = 23;
            this.picSouth.TabStop = false;
            // 
            // btnArrivedNorth
            // 
            this.btnArrivedNorth.Enabled = false;
            this.btnArrivedNorth.Location = new System.Drawing.Point(7, 160);
            this.btnArrivedNorth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArrivedNorth.Name = "btnArrivedNorth";
            this.btnArrivedNorth.Size = new System.Drawing.Size(104, 19);
            this.btnArrivedNorth.TabIndex = 24;
            this.btnArrivedNorth.Text = "Car Arrived North";
            this.btnArrivedNorth.UseVisualStyleBackColor = true;
            this.btnArrivedNorth.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArrivedSouth
            // 
            this.btnArrivedSouth.Enabled = false;
            this.btnArrivedSouth.Location = new System.Drawing.Point(7, 184);
            this.btnArrivedSouth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArrivedSouth.Name = "btnArrivedSouth";
            this.btnArrivedSouth.Size = new System.Drawing.Size(104, 19);
            this.btnArrivedSouth.TabIndex = 25;
            this.btnArrivedSouth.Text = "Car Arrived South";
            this.btnArrivedSouth.UseVisualStyleBackColor = true;
            this.btnArrivedSouth.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnArrivedEast
            // 
            this.btnArrivedEast.Enabled = false;
            this.btnArrivedEast.Location = new System.Drawing.Point(116, 162);
            this.btnArrivedEast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnArrivedEast.Name = "btnArrivedEast";
            this.btnArrivedEast.Size = new System.Drawing.Size(105, 19);
            this.btnArrivedEast.TabIndex = 26;
            this.btnArrivedEast.Text = "Car Arrived East";
            this.btnArrivedEast.UseVisualStyleBackColor = true;
            this.btnArrivedEast.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.LimeGreen;
            this.pictureBox2.Location = new System.Drawing.Point(355, 94);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(306, 271);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Location = new System.Drawing.Point(470, 94);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 271);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Gray;
            this.pictureBox4.Location = new System.Drawing.Point(355, 191);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(306, 81);
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // btnRandom
            // 
            this.btnRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRandom.Enabled = false;
            this.btnRandom.Location = new System.Drawing.Point(232, 162);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(112, 41);
            this.btnRandom.TabIndex = 30;
            this.btnRandom.Text = "Send Random Direction";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(562, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 21);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox5.Location = new System.Drawing.Point(480, 288);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 37);
            this.pictureBox5.TabIndex = 32;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox6.Location = new System.Drawing.Point(524, 144);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 37);
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // lblWest
            // 
            this.lblWest.AutoSize = true;
            this.lblWest.Location = new System.Drawing.Point(439, 206);
            this.lblWest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWest.Name = "lblWest";
            this.lblWest.Size = new System.Drawing.Size(0, 13);
            this.lblWest.TabIndex = 34;
            // 
            // lblNorth
            // 
            this.lblNorth.AutoSize = true;
            this.lblNorth.Location = new System.Drawing.Point(524, 160);
            this.lblNorth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNorth.Name = "lblNorth";
            this.lblNorth.Size = new System.Drawing.Size(0, 13);
            this.lblNorth.TabIndex = 35;
            // 
            // lblEast
            // 
            this.lblEast.AutoSize = true;
            this.lblEast.Location = new System.Drawing.Point(562, 240);
            this.lblEast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEast.Name = "lblEast";
            this.lblEast.Size = new System.Drawing.Size(0, 13);
            this.lblEast.TabIndex = 36;
            // 
            // lblSouth
            // 
            this.lblSouth.AutoSize = true;
            this.lblSouth.Location = new System.Drawing.Point(480, 288);
            this.lblSouth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSouth.Name = "lblSouth";
            this.lblSouth.Size = new System.Drawing.Size(0, 13);
            this.lblSouth.TabIndex = 37;
            // 
            // timerCountdownEW
            // 
            this.timerCountdownEW.Interval = 10000;
            this.timerCountdownEW.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 594);
            this.Controls.Add(this.lblSouth);
            this.Controls.Add(this.lblEast);
            this.Controls.Add(this.lblNorth);
            this.Controls.Add(this.lblWest);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.picSouth);
            this.Controls.Add(this.picNorth);
            this.Controls.Add(this.picBus);
            this.Controls.Add(this.picLightWest);
            this.Controls.Add(this.picLightEast);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnArrivedEast);
            this.Controls.Add(this.btnArrivedSouth);
            this.Controls.Add(this.btnArrivedNorth);
            this.Controls.Add(this.buttonCarArrived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLightIP);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTrafficLight";
            this.Text = "TrafficLight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormTrafficLight_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLightEast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLightWest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNorth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSouth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLightIP;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonCarArrived;
        private System.Windows.Forms.PictureBox picLightEast;
        private System.Windows.Forms.PictureBox picLightWest;
        private System.Windows.Forms.PictureBox picBus;
        private System.Windows.Forms.Timer timerCountdownNS;
		private System.Windows.Forms.PictureBox picNorth;
		private System.Windows.Forms.PictureBox picSouth;
        private System.Windows.Forms.Button btnArrivedNorth;
        private System.Windows.Forms.Button btnArrivedSouth;
        private System.Windows.Forms.Button btnArrivedEast;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lblWest;
        private System.Windows.Forms.Label lblNorth;
        private System.Windows.Forms.Label lblEast;
        private System.Windows.Forms.Label lblSouth;
        private System.Windows.Forms.Timer timerCountdownEW;
    }
}

