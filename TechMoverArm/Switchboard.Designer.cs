namespace Harware_TechM
{
    partial class Switchboard
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
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_role = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.chkE = new System.Windows.Forms.CheckBox();
            this.btnInitialPostition = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chk_Wrist = new System.Windows.Forms.CheckBox();
            this.buttonSubmitCommand = new System.Windows.Forms.Button();
            this.textBoxRobotCommand = new System.Windows.Forms.TextBox();
            this.buttonCloseGripper = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_stretch = new System.Windows.Forms.Button();
            this.btnOpenGripper = new System.Windows.Forms.Button();
            this.numericElbow = new System.Windows.Forms.NumericUpDown();
            this.numericBase = new System.Windows.Forms.NumericUpDown();
            this.numericRightWrist = new System.Windows.Forms.NumericUpDown();
            this.numericLeftWrist = new System.Windows.Forms.NumericUpDown();
            this.numericShoulder = new System.Windows.Forms.NumericUpDown();
            this.chk_BaseRight = new System.Windows.Forms.CheckBox();
            this.chk_ShoulderUp = new System.Windows.Forms.CheckBox();
            this.chk_ElbowUp = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_loopPlay = new System.Windows.Forms.Button();
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.btn_stop_loop = new System.Windows.Forms.Button();
            this.btn_routine = new System.Windows.Forms.Button();
            this.Btn_save2 = new System.Windows.Forms.Button();
            this.Btn_save3 = new System.Windows.Forms.Button();
            this.btn_load2 = new System.Windows.Forms.Button();
            this.btn_load3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericElbow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRightWrist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLeftWrist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericShoulder)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(9, 30);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(298, 128);
            this.textBoxLog.TabIndex = 2;
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLog);
            this.groupBox1.Controls.Add(this.listBoxLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 275);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communications Log";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(9, 178);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(298, 134);
            this.listBoxLog.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_connect);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbo_role);
            this.groupBox2.Controls.Add(this.buttonOpenPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxBaud);
            this.groupBox2.Controls.Add(this.comboBoxPort);
            this.groupBox2.Controls.Add(this.comboBoxSpeed);
            this.groupBox2.Controls.Add(this.labelSpeed);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 197);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(11, 168);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(296, 23);
            this.btn_connect.TabIndex = 15;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Role";
            // 
            // cbo_role
            // 
            this.cbo_role.FormattingEnabled = true;
            this.cbo_role.Items.AddRange(new object[] {
            "Slave",
            "Master"});
            this.cbo_role.Location = new System.Drawing.Point(100, 102);
            this.cbo_role.Name = "cbo_role";
            this.cbo_role.Size = new System.Drawing.Size(167, 21);
            this.cbo_role.TabIndex = 13;
            this.cbo_role.SelectedIndexChanged += new System.EventHandler(this.cbo_role_SelectedIndexChanged);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(11, 129);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(296, 23);
            this.buttonOpenPort.TabIndex = 6;
            this.buttonOpenPort.Text = "Open Port";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600"});
            this.comboBoxBaud.Location = new System.Drawing.Point(100, 46);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(166, 21);
            this.comboBoxBaud.TabIndex = 8;
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(100, 19);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(166, 21);
            this.comboBoxPort.TabIndex = 7;
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(100, 73);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(166, 21);
            this.comboBoxSpeed.TabIndex = 12;
            this.comboBoxSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBoxSpeed_SelectedIndexChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(5, 77);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 13;
            this.labelSpeed.Text = "Speed";
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(174, 16);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(49, 34);
            this.btnUP.TabIndex = 14;
            this.btnUP.Text = "up";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            this.btnUP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnUP_MouseDown);
            this.btnUP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnUP_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(117, 55);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(49, 34);
            this.btnLeft.TabIndex = 15;
            this.btnLeft.Text = "left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            this.btnLeft.Leave += new System.EventHandler(this.btnLeft_Leave);
            this.btnLeft.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseClick);
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseEnter += new System.EventHandler(this.btnLeft_MouseEnter);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseUp);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(222, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(49, 34);
            this.button4.TabIndex = 16;
            this.button4.Text = "right";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button4_MouseUp);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(174, 95);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 34);
            this.button5.TabIndex = 17;
            this.button5.Text = "down ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnDown);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button5_MouseUp);
            // 
            // chkE
            // 
            this.chkE.AutoSize = true;
            this.chkE.Location = new System.Drawing.Point(20, 32);
            this.chkE.Name = "chkE";
            this.chkE.Size = new System.Drawing.Size(55, 17);
            this.chkE.TabIndex = 19;
            this.chkE.Text = "Elbow";
            this.chkE.UseVisualStyleBackColor = true;
            // 
            // btnInitialPostition
            // 
            this.btnInitialPostition.Location = new System.Drawing.Point(299, 80);
            this.btnInitialPostition.Name = "btnInitialPostition";
            this.btnInitialPostition.Size = new System.Drawing.Size(139, 56);
            this.btnInitialPostition.TabIndex = 20;
            this.btnInitialPostition.Text = "Initial Postition";
            this.btnInitialPostition.UseVisualStyleBackColor = true;
            this.btnInitialPostition.Click += new System.EventHandler(this.btnInitialPostition_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 62);
            this.button1.TabIndex = 21;
            this.button1.Text = "Play initial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btninitialPlay);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chk_Wrist);
            this.groupBox4.Controls.Add(this.btnUP);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnInitialPostition);
            this.groupBox4.Controls.Add(this.btnLeft);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.chkE);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(331, 348);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 142);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manual Control";
            // 
            // chk_Wrist
            // 
            this.chk_Wrist.AutoSize = true;
            this.chk_Wrist.Location = new System.Drawing.Point(20, 55);
            this.chk_Wrist.Name = "chk_Wrist";
            this.chk_Wrist.Size = new System.Drawing.Size(50, 17);
            this.chk_Wrist.TabIndex = 22;
            this.chk_Wrist.Text = "Wrist";
            this.chk_Wrist.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitCommand
            // 
            this.buttonSubmitCommand.Location = new System.Drawing.Point(19, 230);
            this.buttonSubmitCommand.Name = "buttonSubmitCommand";
            this.buttonSubmitCommand.Size = new System.Drawing.Size(419, 23);
            this.buttonSubmitCommand.TabIndex = 0;
            this.buttonSubmitCommand.Text = "Step";
            this.buttonSubmitCommand.UseVisualStyleBackColor = true;
            this.buttonSubmitCommand.Click += new System.EventHandler(this.buttonSubmitCommand_Click);
            // 
            // textBoxRobotCommand
            // 
            this.textBoxRobotCommand.Location = new System.Drawing.Point(20, 203);
            this.textBoxRobotCommand.Name = "textBoxRobotCommand";
            this.textBoxRobotCommand.Size = new System.Drawing.Size(419, 20);
            this.textBoxRobotCommand.TabIndex = 1;
            this.textBoxRobotCommand.TextChanged += new System.EventHandler(this.textBoxRobotCommand_TextChanged);
            // 
            // buttonCloseGripper
            // 
            this.buttonCloseGripper.Location = new System.Drawing.Point(19, 259);
            this.buttonCloseGripper.Name = "buttonCloseGripper";
            this.buttonCloseGripper.Size = new System.Drawing.Size(173, 23);
            this.buttonCloseGripper.TabIndex = 2;
            this.buttonCloseGripper.Text = "Close Gripper";
            this.buttonCloseGripper.UseVisualStyleBackColor = true;
            this.buttonCloseGripper.Click += new System.EventHandler(this.buttonCloseGripper_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Base";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Joint";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(192, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Half-Steps (in degrees)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Shoulder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Elbow";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Right Wrist";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Left Wrist";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(282, 259);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(73, 51);
            this.buttonReset.TabIndex = 26;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(390, 31);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(49, 162);
            this.buttonRead.TabIndex = 27;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(338, 31);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(48, 162);
            this.buttonClear.TabIndex = 28;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_stretch
            // 
            this.btn_stretch.Location = new System.Drawing.Point(202, 259);
            this.btn_stretch.Name = "btn_stretch";
            this.btn_stretch.Size = new System.Drawing.Size(73, 51);
            this.btn_stretch.TabIndex = 13;
            this.btn_stretch.Text = "Stretch";
            this.btn_stretch.UseVisualStyleBackColor = true;
            this.btn_stretch.Click += new System.EventHandler(this.btn_stretch_Click);
            // 
            // btnOpenGripper
            // 
            this.btnOpenGripper.Location = new System.Drawing.Point(19, 287);
            this.btnOpenGripper.Name = "btnOpenGripper";
            this.btnOpenGripper.Size = new System.Drawing.Size(173, 23);
            this.btnOpenGripper.TabIndex = 22;
            this.btnOpenGripper.Text = "Open Gripper";
            this.btnOpenGripper.UseVisualStyleBackColor = true;
            this.btnOpenGripper.Click += new System.EventHandler(this.btnOpenGripper_Click);
            // 
            // numericElbow
            // 
            this.numericElbow.Location = new System.Drawing.Point(256, 97);
            this.numericElbow.Name = "numericElbow";
            this.numericElbow.Size = new System.Drawing.Size(60, 20);
            this.numericElbow.TabIndex = 36;
            this.numericElbow.ValueChanged += new System.EventHandler(this.numericElbow_ValueChanged);
            // 
            // numericBase
            // 
            this.numericBase.Location = new System.Drawing.Point(256, 42);
            this.numericBase.Name = "numericBase";
            this.numericBase.Size = new System.Drawing.Size(60, 20);
            this.numericBase.TabIndex = 36;
            this.numericBase.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // numericRightWrist
            // 
            this.numericRightWrist.Location = new System.Drawing.Point(256, 122);
            this.numericRightWrist.Name = "numericRightWrist";
            this.numericRightWrist.Size = new System.Drawing.Size(60, 20);
            this.numericRightWrist.TabIndex = 36;
            this.numericRightWrist.ValueChanged += new System.EventHandler(this.numericRightWrist_ValueChanged);
            // 
            // numericLeftWrist
            // 
            this.numericLeftWrist.Location = new System.Drawing.Point(256, 148);
            this.numericLeftWrist.Name = "numericLeftWrist";
            this.numericLeftWrist.Size = new System.Drawing.Size(60, 20);
            this.numericLeftWrist.TabIndex = 36;
            this.numericLeftWrist.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // numericShoulder
            // 
            this.numericShoulder.Location = new System.Drawing.Point(256, 71);
            this.numericShoulder.Name = "numericShoulder";
            this.numericShoulder.Size = new System.Drawing.Size(60, 20);
            this.numericShoulder.TabIndex = 36;
            this.numericShoulder.ValueChanged += new System.EventHandler(this.numericShoulder_ValueChanged);
            // 
            // chk_BaseRight
            // 
            this.chk_BaseRight.AutoSize = true;
            this.chk_BaseRight.Location = new System.Drawing.Point(83, 44);
            this.chk_BaseRight.Name = "chk_BaseRight";
            this.chk_BaseRight.Size = new System.Drawing.Size(73, 17);
            this.chk_BaseRight.TabIndex = 37;
            this.chk_BaseRight.Text = "Base right";
            this.chk_BaseRight.UseVisualStyleBackColor = true;
            // 
            // chk_ShoulderUp
            // 
            this.chk_ShoulderUp.AutoSize = true;
            this.chk_ShoulderUp.Location = new System.Drawing.Point(83, 70);
            this.chk_ShoulderUp.Name = "chk_ShoulderUp";
            this.chk_ShoulderUp.Size = new System.Drawing.Size(83, 17);
            this.chk_ShoulderUp.TabIndex = 37;
            this.chk_ShoulderUp.Text = "Shoulder up";
            this.chk_ShoulderUp.UseVisualStyleBackColor = true;
            this.chk_ShoulderUp.CheckedChanged += new System.EventHandler(this.chk_ShoulderUp_CheckedChanged);
            // 
            // chk_ElbowUp
            // 
            this.chk_ElbowUp.AutoSize = true;
            this.chk_ElbowUp.Location = new System.Drawing.Point(81, 96);
            this.chk_ElbowUp.Name = "chk_ElbowUp";
            this.chk_ElbowUp.Size = new System.Drawing.Size(70, 17);
            this.chk_ElbowUp.TabIndex = 37;
            this.chk_ElbowUp.Text = "Elbow up";
            this.chk_ElbowUp.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Opposite direction";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.chk_ElbowUp);
            this.groupBox3.Controls.Add(this.chk_ShoulderUp);
            this.groupBox3.Controls.Add(this.chk_BaseRight);
            this.groupBox3.Controls.Add(this.numericShoulder);
            this.groupBox3.Controls.Add(this.numericLeftWrist);
            this.groupBox3.Controls.Add(this.numericRightWrist);
            this.groupBox3.Controls.Add(this.numericBase);
            this.groupBox3.Controls.Add(this.numericElbow);
            this.groupBox3.Controls.Add(this.btnOpenGripper);
            this.groupBox3.Controls.Add(this.btn_stretch);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.buttonClear);
            this.groupBox3.Controls.Add(this.buttonRead);
            this.groupBox3.Controls.Add(this.buttonReset);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonCloseGripper);
            this.groupBox3.Controls.Add(this.textBoxRobotCommand);
            this.groupBox3.Controls.Add(this.buttonSubmitCommand);
            this.groupBox3.Location = new System.Drawing.Point(331, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 329);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Robot Commands";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 70;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 50;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(798, 134);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 23;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(798, 317);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 24;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_loopPlay
            // 
            this.btn_loopPlay.Location = new System.Drawing.Point(798, 422);
            this.btn_loopPlay.Name = "btn_loopPlay";
            this.btn_loopPlay.Size = new System.Drawing.Size(75, 23);
            this.btn_loopPlay.TabIndex = 0;
            this.btn_loopPlay.Text = "Play Loop";
            this.btn_loopPlay.UseVisualStyleBackColor = true;
            this.btn_loopPlay.Click += new System.EventHandler(this.btn_loopPlay_Click);
            // 
            // timer7
            // 
            this.timer7.Interval = 30;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // btn_stop_loop
            // 
            this.btn_stop_loop.Location = new System.Drawing.Point(798, 385);
            this.btn_stop_loop.Name = "btn_stop_loop";
            this.btn_stop_loop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop_loop.TabIndex = 26;
            this.btn_stop_loop.Text = "stop loop";
            this.btn_stop_loop.UseVisualStyleBackColor = true;
            this.btn_stop_loop.Click += new System.EventHandler(this.btn_stop_loop_Click);
            // 
            // btn_routine
            // 
            this.btn_routine.Location = new System.Drawing.Point(798, 452);
            this.btn_routine.Name = "btn_routine";
            this.btn_routine.Size = new System.Drawing.Size(75, 23);
            this.btn_routine.TabIndex = 27;
            this.btn_routine.Text = "Play routine";
            this.btn_routine.UseVisualStyleBackColor = true;
            // 
            // Btn_save2
            // 
            this.Btn_save2.Location = new System.Drawing.Point(798, 77);
            this.Btn_save2.Name = "Btn_save2";
            this.Btn_save2.Size = new System.Drawing.Size(75, 23);
            this.Btn_save2.TabIndex = 28;
            this.Btn_save2.Text = "Save 2";
            this.Btn_save2.UseVisualStyleBackColor = true;
            this.Btn_save2.Click += new System.EventHandler(this.Btn_save2_Click);
            // 
            // Btn_save3
            // 
            this.Btn_save3.Location = new System.Drawing.Point(798, 20);
            this.Btn_save3.Name = "Btn_save3";
            this.Btn_save3.Size = new System.Drawing.Size(75, 23);
            this.Btn_save3.TabIndex = 29;
            this.Btn_save3.Text = "Save 3";
            this.Btn_save3.UseVisualStyleBackColor = true;
            this.Btn_save3.Click += new System.EventHandler(this.Btn_save3_Click);
            // 
            // btn_load2
            // 
            this.btn_load2.Location = new System.Drawing.Point(798, 214);
            this.btn_load2.Name = "btn_load2";
            this.btn_load2.Size = new System.Drawing.Size(75, 23);
            this.btn_load2.TabIndex = 30;
            this.btn_load2.Text = "Load2";
            this.btn_load2.UseVisualStyleBackColor = true;
            this.btn_load2.Click += new System.EventHandler(this.btn_load2_Click);
            // 
            // btn_load3
            // 
            this.btn_load3.Location = new System.Drawing.Point(798, 270);
            this.btn_load3.Name = "btn_load3";
            this.btn_load3.Size = new System.Drawing.Size(75, 23);
            this.btn_load3.TabIndex = 31;
            this.btn_load3.Text = "Load3";
            this.btn_load3.UseVisualStyleBackColor = true;
            this.btn_load3.Click += new System.EventHandler(this.btn_load3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 506);
            this.Controls.Add(this.btn_load3);
            this.Controls.Add(this.btn_load2);
            this.Controls.Add(this.Btn_save3);
            this.Controls.Add(this.Btn_save2);
            this.Controls.Add(this.btn_routine);
            this.Controls.Add(this.btn_stop_loop);
            this.Controls.Add(this.btn_loopPlay);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Group E";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericElbow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRightWrist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericLeftWrist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericShoulder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox chkE;
        private System.Windows.Forms.Button btnInitialPostition;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chk_Wrist;
        private System.Windows.Forms.Button buttonSubmitCommand;
        private System.Windows.Forms.TextBox textBoxRobotCommand;
        private System.Windows.Forms.Button buttonCloseGripper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_stretch;
        private System.Windows.Forms.Button btnOpenGripper;
        private System.Windows.Forms.NumericUpDown numericElbow;
        private System.Windows.Forms.NumericUpDown numericBase;
        private System.Windows.Forms.NumericUpDown numericRightWrist;
        private System.Windows.Forms.NumericUpDown numericLeftWrist;
        private System.Windows.Forms.NumericUpDown numericShoulder;
        private System.Windows.Forms.CheckBox chk_BaseRight;
        private System.Windows.Forms.CheckBox chk_ShoulderUp;
        private System.Windows.Forms.CheckBox chk_ElbowUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_loopPlay;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_role;
        private System.Windows.Forms.Button btn_stop_loop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button btn_routine;
        private System.Windows.Forms.Button Btn_save2;
        private System.Windows.Forms.Button Btn_save3;
        private System.Windows.Forms.Button btn_load2;
        private System.Windows.Forms.Button btn_load3;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer7;
    }
}

