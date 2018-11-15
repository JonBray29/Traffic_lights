namespace TrafficLightServer
{
    partial class FormServer
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
            this.buttonConnect = new System.Windows.Forms.Button();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxLightIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLightColour = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutputWest = new System.Windows.Forms.Label();
            this.cbxLightsTwo = new System.Windows.Forms.ComboBox();
            this.lbllightstwo = new System.Windows.Forms.Label();
            this.lblOutputNorth = new System.Windows.Forms.Label();
            this.lblOutputSouth = new System.Windows.Forms.Label();
            this.lblOutputEast = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(35, 10);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(176, 31);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "Connect to sort of proxy";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(35, 148);
            this.listBoxOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(315, 251);
            this.listBoxOutput.TabIndex = 1;
            this.listBoxOutput.SelectedIndexChanged += new System.EventHandler(this.listBoxOutput_SelectedIndexChanged);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(231, 17);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 18);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status";
            // 
            // textBoxLightIP
            // 
            this.textBoxLightIP.Location = new System.Drawing.Point(113, 76);
            this.textBoxLightIP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLightIP.Name = "textBoxLightIP";
            this.textBoxLightIP.Size = new System.Drawing.Size(88, 20);
            this.textBoxLightIP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP number of light";
            // 
            // comboBoxLightColour
            // 
            this.comboBoxLightColour.Enabled = false;
            this.comboBoxLightColour.FormattingEnabled = true;
            this.comboBoxLightColour.Items.AddRange(new object[] {
            "Red1",
            "Amber1",
            "Green1"});
            this.comboBoxLightColour.Location = new System.Drawing.Point(306, 51);
            this.comboBoxLightColour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxLightColour.Name = "comboBoxLightColour";
            this.comboBoxLightColour.Size = new System.Drawing.Size(51, 21);
            this.comboBoxLightColour.TabIndex = 5;
            this.comboBoxLightColour.SelectedIndexChanged += new System.EventHandler(this.comboBoxLightColour_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set colour of Light 1";
            // 
            // lblOutputWest
            // 
            this.lblOutputWest.AutoSize = true;
            this.lblOutputWest.Location = new System.Drawing.Point(362, 216);
            this.lblOutputWest.Name = "lblOutputWest";
            this.lblOutputWest.Size = new System.Drawing.Size(59, 13);
            this.lblOutputWest.TabIndex = 7;
            this.lblOutputWest.Text = "Cars West:";
            this.lblOutputWest.Click += new System.EventHandler(this.lbloutput_Click);
            // 
            // cbxLightsTwo
            // 
            this.cbxLightsTwo.Enabled = false;
            this.cbxLightsTwo.FormattingEnabled = true;
            this.cbxLightsTwo.Items.AddRange(new object[] {
            "Red2",
            "Amber2",
            "Green2"});
            this.cbxLightsTwo.Location = new System.Drawing.Point(306, 88);
            this.cbxLightsTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxLightsTwo.Name = "cbxLightsTwo";
            this.cbxLightsTwo.Size = new System.Drawing.Size(51, 21);
            this.cbxLightsTwo.TabIndex = 8;
            this.cbxLightsTwo.SelectedIndexChanged += new System.EventHandler(this.cbxLightsTwo_SelectedIndexChanged_1);
            // 
            // lbllightstwo
            // 
            this.lbllightstwo.AutoSize = true;
            this.lbllightstwo.Location = new System.Drawing.Point(204, 93);
            this.lbllightstwo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllightstwo.Name = "lbllightstwo";
            this.lbllightstwo.Size = new System.Drawing.Size(102, 13);
            this.lbllightstwo.TabIndex = 9;
            this.lbllightstwo.Text = "Set colour of Light 2";
            // 
            // lblOutputNorth
            // 
            this.lblOutputNorth.AutoSize = true;
            this.lblOutputNorth.Location = new System.Drawing.Point(362, 139);
            this.lblOutputNorth.Name = "lblOutputNorth";
            this.lblOutputNorth.Size = new System.Drawing.Size(60, 13);
            this.lblOutputNorth.TabIndex = 10;
            this.lblOutputNorth.Text = "Cars North:";
            // 
            // lblOutputSouth
            // 
            this.lblOutputSouth.AutoSize = true;
            this.lblOutputSouth.Location = new System.Drawing.Point(362, 189);
            this.lblOutputSouth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputSouth.Name = "lblOutputSouth";
            this.lblOutputSouth.Size = new System.Drawing.Size(62, 13);
            this.lblOutputSouth.TabIndex = 11;
            this.lblOutputSouth.Text = "Cars South:";
            // 
            // lblOutputEast
            // 
            this.lblOutputEast.AutoSize = true;
            this.lblOutputEast.Location = new System.Drawing.Point(362, 162);
            this.lblOutputEast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutputEast.Name = "lblOutputEast";
            this.lblOutputEast.Size = new System.Drawing.Size(55, 13);
            this.lblOutputEast.TabIndex = 12;
            this.lblOutputEast.Text = "Cars East:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 538);
            this.Controls.Add(this.lblOutputEast);
            this.Controls.Add(this.lblOutputSouth);
            this.Controls.Add(this.lblOutputNorth);
            this.Controls.Add(this.lbllightstwo);
            this.Controls.Add(this.cbxLightsTwo);
            this.Controls.Add(this.lblOutputWest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLightColour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLightIP);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.buttonConnect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormServer";
            this.Text = "Server (sort of)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormServer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ListBox listBoxOutput;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxLightIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLightColour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutputWest;
		private System.Windows.Forms.ComboBox cbxLightsTwo;
		private System.Windows.Forms.Label lbllightstwo;
        private System.Windows.Forms.Label lblOutputNorth;
        private System.Windows.Forms.Label lblOutputSouth;
        private System.Windows.Forms.Label lblOutputEast;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

