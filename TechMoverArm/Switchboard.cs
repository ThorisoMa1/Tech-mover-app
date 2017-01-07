using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Collections.Generic;
using Timer = System.Timers.Timer;
using System.Timers;
using System.Threading;
using System.Text;
using MetroFramework.Forms;

namespace Harware_TechM
{
    public partial class Switchboard : MetroForm
    
    {
        enum Part
        {
            bodybase=0,
            shoulderUPDown,
            elbowUpDown,
            wristLeft,
            wristRight,
            grip
        }//ccould be used  to check what is pressed
        Thread th;
        List<string> moveSet2;
        SerialPort sp;
        SerialPort ComPort;//serial port
        bool finishedPLay = false;
        bool finishedPLay2=false;
        public  bool done = false;
        private static List<string> zeroP;//used for zero position values
        private static List<string> Initialfinal;//final zero position values
        public  static List<string> moves;//kee[s track pf the moves used
        List<string> ports;
        List<string> intialSet;
        int worked;
        bool manualUpDown = false;
        public  bool notRead = false;
        bool cont;


        string data;//data that is revived from the machine
        static string tmSpeed;
        string port;
        string readBuffer = "";

        int length;
        int leftRightt = 0;
        int tmBase;
        int tmShoulder;
        int tmElbow;
        int tmRightWrist;
        int tmLeftWrist;
        int tmGripper;
        int tmOut;


        List<string> movesSet3;

        private void numericValueSet()
        {
             string TMSpeed  = "232";
            int TMBase      = 0;
            int TMShoulder  =0;
            int TMElbow = 0;
            int TMRightWrist = 0;
            int TMLeftWrist = 0;
            int TMGripper = 0;
            int TMOut = 0;
        }//run when program starts
        private void OnSerialDataReceived(object sender, SerialDataReceivedEventArgs args)
        {
            //starts the connection to the port
            this.Invoke(new EventHandler(ReadComPort));

        }

       
      
       
        private void ReadComPort(object s, EventArgs e)
        {
            notRead = false;
            length = 0;
           
            data = ComPort.ReadExisting();//reads for values from the machine
            //data = ComPort.ReadLine();

            length=data.Length-3;
           
            readBuffer += data;

           

            
            
           

            if (readBuffer.EndsWith("\r"))
            {
                notRead=true;
                Log(readBuffer, "Robot");
                readBuffer = "";
            }
            else
            {
                notRead = false;
            }
            //char HA = data[0];
           
        }

        /// <summary>
        /// Visual Studio generated code
        /// </summary>
        public Switchboard()
        {
            InitializeComponent();
            //btnLeft.MouseDown+=btnLeft_MouseDown;
            btnLeft.MouseUp += btnLeft_MouseUp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Initialfinal = new List<string>();//creates new list for initial pos
            intialSet = new List<string>();  //creates new list for setting initial

            moves = new List<string>();//creates  a new list for moves
            moveSet2 = new List<string>();
            movesSet3 = new List<string>();
            zeroP = new List<string>();//creates a new zeroposition list

            cont = false;//bool value initial state
            ports = new List<string>();//creates  list of ports
            port = GetPort();//places the port were it need to be 
            SetComboboxvalues();//sets initial states of combo boxes
            //starts the application and sets according to the port

            InitializeComPort(port, 9600);

            UpdateJointSteps();//sets the values  of numerics according to the robot values
          
        }
        private void SetComboboxvalues()
        {
            cbo_role.SelectedIndex = 0;
            comboBoxBaud.SelectedIndex = 1;
            comboBoxPort.SelectedIndex = 0;
            comboBoxSpeed.SelectedIndex = 8;
        }
      
        private void InitializeComPort(string port, int baud)
        {

            
            
            ComPort = new SerialPort(port, baud);
            ComPort.Parity = Parity.None;
            ComPort.StopBits = StopBits.One;
            ComPort.DataBits = 8;
            ComPort.Handshake = Handshake.None;
            ComPort.DataReceived += OnSerialDataReceived;

            try
            {
                ComPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Please make sure that the machine is connected already");
                this.Close();
            }
           
        }

       
        private void buttonSubmitCommand_Click(object sender, EventArgs e)
        {

            //will add a method that actually checks if command is complete

            Log(textBoxRobotCommand.Text.ToString(), "PC");//adds to the log

            RobotCommand(textBoxRobotCommand.Text.ToString());//initiates command
           
            textBoxReset();//clears the textbox for after use
        }

        public static void MessagShow()
        {
            MessageBox.Show("Press to send back");
        }


        private void RobotCommandOther(string text)
        { 
            string com = "@STEP " + tmSpeed + ",0,0,0,0,0,1500,0";
            if (text == com)
            {
                ComPort.Write(text + '\r');
                ComPort.DiscardOutBuffer();
                Thread.Sleep(2000);
            }
            else
            {
                ComPort.Write(text + '\r');
                ComPort.DiscardOutBuffer();
            }
            
        }
        private void RobotCommand(string text)
        {
            //string HA = ComPort.ReadExisting();
            //will test for the return 
            // string wordtest = ComPort.ReadLine();
            //ComPort.DiscardInBuffer();//will clear all buffer data
            //checks if it is  function that should actually be  recorded
            //must test  if ot returns a value
            //list of movE
            moves.Add(text); 

            ComPort.Write(text + '\r');
            ComPort.DiscardOutBuffer();

        }// working on now 

        private void RobotCommandPlay(string text)
        {
            //if (notRead==false)
            //{
            //    Thread.Sleep(2000);//NEEDS TO READ
            //}
            
            
            
           ComPort.Write(text + '\r');
            UpdateJointSteps();
        }//working on to

        private void UpdateStepString()
        {
            textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + tmBase + "," + tmShoulder + "," + tmElbow + "," + tmRightWrist + "," + tmLeftWrist + "," + tmGripper + "," + tmOut;
        }

      
        private void ResetJoints()
        {
            tmBase       = 0;
            tmShoulder   = 0;
            tmElbow      = 0;
            tmRightWrist = 0;
            tmLeftWrist  = 0;
            tmGripper    = 0;
        }//resets the  part values

        private void UpdateJointSteps()
        {
            numericBase.Value = tmBase;  
            numericShoulder.Value  = tmShoulder;
            numericElbow.Value = tmElbow;
            numericRightWrist.Value = tmRightWrist;
            numericLeftWrist.Value  = tmLeftWrist;
           
        }//updates the actual numeric values to the parts

        private void Log(string text, string source)
        {
            string timestamp = DateTime.Now.ToString();
            this.textBoxLog.Text += timestamp + " :: " + source + " >> " + text + Environment.NewLine;
            this.textBoxLog.SelectionStart = this.textBoxLog.TextLength - 1;
            this.textBoxLog.ScrollToCaret();
            //adds items to listbox
            listBoxLog.Items.Add(timestamp + " :: " + source + " >> " + text + Environment.NewLine);
            listBoxLog.SelectedValue = listBoxLog.Items.Count - 1;
        }//updates log
        private void textBoxReset()//resets the numeric up downs  //resets the jois
        {
            ResetJoints();
            UpdateJointSteps();
            


        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            Log("@RESET", "PC"); 
            RobotCommandOther("@RESET");
            moves.Clear();//clears the list
            Initialfinal.Clear();
            textBoxReset();


        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            Log("@READ", "PC");
            RobotCommandOther("@READ");
        }

        private void buttonCloseGripper_Click_1(object sender, EventArgs e)
        {
            ResetJoints();//resets the joints

            Log("@CLOSE", "PC");//logs  the close command
            //textBoxRobotCommand.Text = ("@CLOSE ");
           tmGripper = -1500;//places negative for negative action

            //need to place a check for the completion of the method

            UpdateStepString();//updates the string to the new value

            RobotCommand(textBoxRobotCommand.Text);//runs command
            
        }

       

    
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxReset();//resets text boxes
            ResetJoints();//resets joins
            UpdateJointSteps();//updates joint values
            LIstreset();
            
            

        }
        private void LIstreset()
        {
            zeroP = new List<string>();
            Initialfinal = new List<string>();
            moves = new List<string>();
            moveSet2 = new List<string>();
            movesSet3 = new List<string>();
            intialSet = new List<string>();
        }
        private void btn_stretch_Click(object sender, EventArgs e)
        {
            Stretch();//activate sthe stretch
        }
        private void Stretch()//stretches arm
        {
            Log("@Streching", "PC");

            RobotCommandOther("@RUN 126");

            //Need to add the check for the arm
            
        }

        
        private string GetPort()
        {
            port = null;

            sp = new SerialPort();

            foreach (var item in SerialPort.GetPortNames())
            {
                sp = new SerialPort(item);
                if (sp.IsOpen==false)
                {
                    port = item;
                    comboBoxPort.Items.Add(item);
                }
            }
            return port;
        }//gets and set connected port

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            int v = int.Parse(comboBoxBaud.GetItemText(comboBoxBaud.SelectedText));
            ComPort.Close();
            InitializeComPort(comboBoxPort.GetItemText(comboBoxPort.SelectedText), v);
            MessageBox.Show("The port is open");
        }//poens port up for use

        private void comboBoxSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] speed = { 0, 111, 159, 183, 205, 221, 232, 236, 238, 239, 240, 241, 242, 243, 244, 245};
            if (comboBoxSpeed.SelectedIndex>=0 || comboBoxSpeed.SelectedIndex<=15)
            {
                tmSpeed = speed[comboBoxSpeed.SelectedIndex].ToString();
                UpdateStepString();
            }
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            Playclick();
           

            //foreach (string item in moves)
            //{

            //    //actually need the string for sending the commands
            //    //need to send  how many steps can be sent per
                
            //    RobotCommandPlay(item);
            //    Update();
            //}
        }
        public void Playclick()
        {
            index = 0;
            if (moves.Count == 0)
            {
                MessageBox.Show("Please preform some steps");
            }
            else
            {
                timer5.Enabled = true;
                notRead = true;
            }
        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }
        public void MoveLeft() 
        {

            ResetJoints();//needs to be first
            leftRightt++;

            double value = leftRightt * 19.64;//converts value to  half steps 

            tmBase = (int)Math.Round(value);
            UpdateStepString();
            //will update command
            //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + tmBase + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;
            RobotCommand(textBoxRobotCommand.Text.ToString());
            ResetJoints();



        }
        public void MoveRight()
        {
            ResetJoints();//needs to be first
            leftRightt++;

            double value = leftRightt * 19.64;//converts value to  half steps 

            tmBase = (int)Math.Round(value * -1);

            UpdateStepString();
            //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + tmBase + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;
            RobotCommand(textBoxRobotCommand.Text.ToString());
            ResetJoints();

        }
        public void MoveUp()
        {
            ResetJoints();
            leftRightt++;

            if (chkE.CheckState==CheckState.Checked)
            {
                double value = leftRightt * 19.64;//converts value to  half steps 
                tmElbow = (int)Math.Round(value * -1);
                //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + 0 + "," + 0 + "," + tmElbow + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;
              //  RobotCommand(textBoxRobotCommand.Text.ToString());
               
            }
            else
            {   
                double value = leftRightt * 19.64;//converts value to  half steps 
                tmShoulder = (int)Math.Round(value * -1);
                //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + 0 + "," + tmShoulder + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;
               
                
            }
            playOnUpdate();
        }
        public void MoveDown()
        {
            leftRightt++;
            double value = leftRightt * 19.64;//converts value to  half steps 

            if (chkE.CheckState == CheckState.Checked)
            {
                tmElbow = (int)Math.Round(value);
                // textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + 0 + "," + 0 + "," + tmElbow + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;

            }
            else
            {
                tmShoulder = (int)Math.Round(value);
                //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + 0 + "," + tmShoulder + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;

            }
            playOnUpdate();

        }

        public void MoveUpManual()
        {
            ResetJoints();
            leftRightt++;
            double value = leftRightt * 19.64;//converts value to  half steps 

            if (chkE.CheckState == CheckState.Checked)
            {
               
                tmElbow = (int)Math.Round(value * -1) / 10;
               
            }
            else
            {
                
                tmShoulder = (int)Math.Round(value * -1) / 10;
               
         
            }

            playOnUpdate();

        }
       
        public void MoveDownManual()
        {
            leftRightt++;
            double value = leftRightt * 19.64;//converts value to  half steps 

            if (chkE.CheckState == CheckState.Checked)
            {
                tmElbow = (int)Math.Round(value)/10;
               // textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + 0 + "," + 0 + "," + tmElbow + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;
               
            }
            else
            {
                tmShoulder = (int)Math.Round(value)/10;
                }
            playOnUpdate();

        }

        public void AvailablePorts() 
        {
            SerialPort s = new SerialPort();
            foreach (string item in SerialPort.GetPortNames())
            {
                s = new SerialPort(item,9600);
                if (s.IsOpen==true)
                {
                    
                }
                
            }
        }//will check for aavilable  ports

        

        private void textBoxRobotCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //needs to be uncommented
          // MoveLeft();

        }

        private void btnLeft_MouseClick(object sender, MouseEventArgs e)
        {
            
        }//move to bottem

     
        private void btnLeft_Leave(object sender, EventArgs e)
        {
            
        }//mtb

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }//mtb

        private void btnUP_Click(object sender, EventArgs e)
        {
            MoveUpManual();

              
        }

        private void btnDown(object sender, EventArgs e)
        {
            MoveDownManual();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //MoveRight();//moves base right
        }//work on

        private void btnInitialPostition_Click(object sender, EventArgs e)
        {
            setZeroposition();//sets initial position
        }
        private static void setZeroposition()
        {

            string step = "@STEP "+tmSpeed+", ";
       
            List<double> Processed = new List<double>();
            zeroP = new List<string>();
            Initialfinal = new List<string>();


            string[] numExt;
          
            string newStep;

            for (int i = moves.Count-1; i > -1; i--)//adds this list to a new parallel post
            {
                if (moves[i]=="@CLOSE")
                {
                    moves[i]=("@STEP " + tmSpeed + ",0,0,0,0,0,1500,0");
                }
                zeroP.Add(moves[i]);
            }


            foreach (string item in zeroP)
            {
                newStep = "";
               
                numExt = item.Split(',');
                Processed = new List<double>();
                for (int i = 1; i < numExt.Length; i++)
                {
                    //intialSet.Add("@STEP 232, "+num);
                   Processed.Add((double.Parse(numExt[i]) * -1));
                }

                foreach (int item2 in Processed)
                {
                    newStep+= (item2.ToString() + ",");
                    
                }

                int l = newStep.ToString().LastIndexOf(',');
                
                Initialfinal.Add(step + newStep.Remove(newStep.Length - 1, 1));//adds initial reverse values
               
                

            }

            

      
           
            
           
        }//need to check

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void PlayInitial()
        {
            //starts the zero postioning 

            index = 0;
            timer6.Enabled = true;
            notRead = true;

        }//need to work on

        private void btninitialPlay(object sender, EventArgs e)
        {
            PlayInitial();
        }

        private void btnOpenGripper_Click(object sender, EventArgs e)
        {
            ResetJoints();
            tmGripper = 1500;
            UpdateStepString();

            //textBoxRobotCommand.Text = ("@STEP " + tmSpeed + ",0,0,0,0,0,1500,0");
            RobotCommand(textBoxRobotCommand.Text);
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
             
         
            double value = double.Parse(numericBase.Value.ToString()) * 19.64;//converts value to  half steps 
            tmBase = (int)Math.Round(value);

            if (chk_BaseRight.CheckState == CheckState.Checked)
            {
                tmBase *= -1;
            }

            UpdateStepString();
        }

        private void numericShoulder_ValueChanged(object sender, EventArgs e)
        {
            double value = double.Parse(numericShoulder.Value.ToString()) * 10;

            tmShoulder = (int)value;
             
            if (chk_ShoulderUp.CheckState==CheckState.Checked)
            {
                tmShoulder *= -1;
            }
          
           
            UpdateStepString();
        }

        private void numericElbow_ValueChanged(object sender, EventArgs e)
        {
           

            double value = double.Parse(numericElbow.Value.ToString()) * 10;
            tmElbow = (int)value;

            if (chk_ElbowUp.CheckState == CheckState.Checked)
            {
                tmElbow *= -1;
            }

            UpdateStepString();
        }

        private void numericRightWrist_ValueChanged(object sender, EventArgs e)
        {
            
            double value = double.Parse(numericRightWrist.Value.ToString()) * 4.27;
            tmRightWrist = (int)value;
            UpdateStepString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            

            double value = double.Parse(numericLeftWrist.Value.ToString()) * 4.27;
            tmLeftWrist = (int)value;
            UpdateStepString();
        }

        private void numericGripper_ValueChanged(object sender, EventArgs e)
        {
           

            
        }//move

        private void btnLeft_MouseEnter(object sender, EventArgs e)
        {

        }//mtb
       
        private void timer1_Tick(object sender, EventArgs e)
        {

           
            leftRightt++;
            double value = leftRightt * 19.64;//converts value to  half steps 

            if (chk_Wrist.CheckState==CheckState.Checked)
            {
               

                tmLeftWrist = (int)Math.Round(value) / 5;

               // UpdateJointSteps();
               // textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmLeftWrist + "," + 0 + "," + tmOut;
                
               
            }
            else
            {

                tmBase = (int)Math.Round(value) / 5;


                //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + tmBase + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;
              
               




                //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + tmBase + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;

            }


           // Thread.Sleep(100);
            playOnUpdate();
            ResetJoints();
            
        }

       

        private void timer2_Tick(object sender, EventArgs e)
        {

            ResetJoints();
            if (notRead == true)
            {
                MoveDownManual();
                double value = leftRightt * 19.64;//converts value to  half steps 

                if (chk_Wrist.CheckState == CheckState.Checked)
                {
                    tmLeftWrist = (int)Math.Round(value);
                    //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + 0 + "," + 0 + "," + 0 + "," + tmRightWrist + "," + 0 + "," + 0 + "," + tmOut;

                }
                else
                {
                    tmBase = ((int)Math.Round(value) * -1) / 5;
                    //textBoxRobotCommand.Text = "@STEP " + tmSpeed + "," + tmBase / 5 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + tmOut;

                }


                
                playOnUpdate();
                notRead = false;

               
               
            }
            leftRightt++;


            

          

          
        }

        private void chk_ShoulderUp_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

            timer2.Enabled = true;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Enabled = false;
        }
        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {

            timer1.Enabled = true;




        }
        private void btnUP_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Enabled = true;
        }
        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            timer4.Enabled = true;
        }
        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;


        }
        private void btnUP_MouseUp(object sender, MouseEventArgs e)
        {
            leftRightt = 0;
            timer3.Enabled = false;
        }
        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            leftRightt = 0;
            timer4.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (notRead == true)
            {
                MoveDownManual();
                notRead = false;
               
               
            }

           
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            MoveUpManual();
        }

        
        private void playOnUpdate()
        {
            UpdateStepString();
            RobotCommand(textBoxRobotCommand.Text.ToString());
            ResetJoints();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ZeroPositioning()
        {
            List<string> moves2 = new List<string>();
            List<string> moves3 = new List<string>();
            foreach (string item in moves)
            {
                if (item == "@CLOSE")
                {
                    moves2.Add("@STEP " + tmSpeed + ",0,0,0,0,0,-1500,0");
                }
                else
                {
                    moves2.Add(item);
                }
            }

            foreach (string item in moves2)
            {
                string[] list = item.Split(' ');
                string[] values = list[1].Split(',');
                for (int i =1 ; i < values.Length; i++)
                {
                    if (values[i] != "0")
                    {
                        int a = int.Parse(values[i]) * -1;
                        values[i] = a.ToString();

                    }
                    
                }
                string output = string.Format("@STEP {0},{1},{2},{3},{4},{5},{6},{7}", values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
                moves3.Add(output);


            }
            int[] zz = { 0, 0, 0, 0, 0, 0 };
            foreach (string item in moves3)
            {
                string[] list = item.Split(' ');
                string[] values = list[1].Split(',');
               
                for (int i = 1; i < values.Length-1; i++)
                {
                    if (values[i] != "0")
                    {
                        int a = int.Parse(values[i]) ;
                        zz[i-1] += a;
                        
                    }

                }
            }

            string commandString = string.Format("@STEP 232,{0},{1},{2},{3},{4},{5},0",zz[0],zz[1],zz[2],zz[3],zz[4],zz[5]);
            RobotCommandOther(commandString);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZeroPositioning();
        }

        int index = 0;
        public void play(int inde)
        {

            RobotCommandOther(moves[inde]);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (notRead == true)
            {
                if (index<moves.Count)
                {
                    play(index);
                    index++;
                    notRead = false;
                   
                }
                else
                {
                    index = 0;
                    timer5.Enabled = false;
                    finishedPLay = true;
                }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (notRead == true)
            {
                if (index < Initialfinal.Count)
                {
                    RobotCommandOther(Initialfinal[index]);
                    index++;
                    notRead = false;
                }
                else
                {
                    index = 0;
                    timer6.Enabled = false;
                    finishedPLay2 = true;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (moves.Count==0)
            {
                MessageBox.Show("Please record moves fist");
            }
            else
            {
                datahandler.Write(moves);
            }
           
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            moves=datahandler.Readstring();
            MessageBox.Show("moves loaded ");
        }

        private void btn_loopPlay_Click(object sender, EventArgs e)
        {
            
            done = true;
            LoopPlay();
           
        }
       
        public  void LoopPlay()
        {
            
            if (moves.Count == 0)
            {
                MessageBox.Show("Please preform some steps or Load them");

            }
            else
            {
                setZeroposition();//sets initial position
                notRead = true;
                timer5.Enabled = true;
                timer7.Enabled = true;//enables the play loop
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (done==true)
            {
                if (finishedPLay == true)
                {
                    finishedPLay = false;
                    timer6.Enabled = true;
                }

                if (finishedPLay2 == true)
                {
                    finishedPLay2 = false;
                    timer5.Enabled = true;
                }
            }
            else
            {
                timer7.Enabled = false;
            }

           

            //need to add method for disableing the timer.
            
        }

        private void cbo_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_role.SelectedIndex==1)
            {
                btn_connect.Text = "Host";
            }
            else
            {
                btn_connect.Text = "Connect";
            }
        }
        
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (cbo_role.SelectedIndex==1)
            {
                th = new Thread(hostServer);
                th.Start();
               
                //will connect to servere
            }
            else
            {
                th = new Thread(ConnectToServer);
                th.Start();
                
                //will  host 
            }
        }
        private void hostServer()
        {
            Server_Async_server2.Host(this);
        }
        private void ConnectToServer()
        {
            AsyncClient2.Connect(this);
        }

        private void btn_stop_loop_Click(object sender, EventArgs e)
        {
           done = false;
        }

        private void Btn_save2_Click(object sender, EventArgs e)
        {
            if (moves.Count == 0)
            {
                MessageBox.Show("Please record moves fist");
            }
            else
            {
                datahandler.Write2(moves);
            }
        }

        private void Btn_save3_Click(object sender, EventArgs e)
        {
            if (moves.Count == 0)
            {
                MessageBox.Show("Please record moves fist");
            }
            else
            {
                datahandler.Write3(moves);
            }
        }

        private void btn_load2_Click(object sender, EventArgs e)
        {
           moveSet2 = datahandler.Readstring2();
            MessageBox.Show("moves  set 2 loaded ");
        }

        private void btn_load3_Click(object sender, EventArgs e)
        {
            movesSet3 = datahandler.Readstring3();
            MessageBox.Show("moves set 3 loaded ");
        }
    }
}
