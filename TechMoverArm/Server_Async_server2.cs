using System;
using System.Collections.Generic;

using System.Text;

using System.Threading;
using System.Net.Sockets;
using System.Net;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace Harware_TechM
{
    //will checck this to ask what it is recieving
    class Server_Async_server2
    {
        private static  int clientCount = 0;
        public static bool connnectd = false;
       
        public int recieveType = 0;

       private static Switchboard f1;
        public static object tempObj;
        public static Socket listerner;
        public static ManualResetEvent Done = new ManualResetEvent(false);
        public const int _bufferSize = 1024;
        public const int _port = 8080;
        public static bool _isRunning = true;

        class StateObj
        {
            public Socket currentSock = null;
            public  byte[] buffer = new byte[_bufferSize];
            public StringBuilder sb = new StringBuilder();

         
        }
      

        public static void Host(Switchboard ds)
        {
            f1 = ds;
            //information
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPEndPoint localEP = new IPEndPoint(IPAddress.Parse("192.168.60.41"), _port);

            listerner = new Socket(localEP.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            listerner.Bind(localEP);

            string starts = "listenining";
            Console.Write(starts);

            while (_isRunning)
            {
                Thread.Sleep(1000);
                
                Done.Reset();
                listerner.Listen(10);
                //start accepting any connection from a client
                //this conneects
                listerner.BeginAccept(new AsyncCallback(AcceptCallback),listerner); //works


            }
        }



        public  static void AcceptCallback (IAsyncResult air)
        {
            f1.notRead = true;
            //saves then state
            Socket listener =(Socket)air.AsyncState;

            MessageBox.Show("Client connected");
            if (listerner!=null)
            {
                Socket Hand=listerner.EndAccept(air);
                //tells main thread to go on 
                Done.Set();

                //gets it ready to recieve
                StateObj  state=new StateObj();
                state.currentSock=Hand;
                connnectd = true;

               
                //will change the textbox colour

                
                
               // begins to recieve the client info
                Hand.BeginReceive(state.buffer,0,_bufferSize,0,new AsyncCallback(ReadCallback),state);//works
               
            }


        }//works //readcallback next

         public static void ReadCallback(IAsyncResult air) //works for 1st itteration
        {
            byte[] toSend = new byte[1000];
            MemoryStream ms=new MemoryStream();
            ms.Flush();
            //makes it equal to the current connection
            StateObj state=(StateObj)air.AsyncState;
            Socket hand =state.currentSock;
            byte[] bytes = state.buffer;
       
            if(!IsConnected(hand))
            {
                hand.Close();
                return;
            }
            int read=hand.EndReceive(air);
            //if data bigger than what was needed then activate
            int i = 0;
            if (read>0)
	            {

                string r;
                         state.sb = new StringBuilder();
                                             
                    state.sb.Append(ASCIIEncoding.UTF8.GetString(state.buffer,0,read));
                r = state.sb.ToString();

                if (r == "Hello pc")
                {
                    f1.done = false;
                    f1.Playclick();
                   
                    //activate the method
                }
                else if (r == "1")
                {
                    f1.Playclick();
                    
                    //will activate  moveset 1 and play



                    toSend = Encoding.UTF8.GetBytes("1");

                    //will put a method for sending
                    // ms = SerializeObj.ser(cfch);//works

                    StateObj state4 = new StateObj();

                    state4.currentSock = hand;

                    hand.BeginSend(state.buffer, 0, _bufferSize, 0, new AsyncCallback(SendCallback), state);//works



                }
                else if (r == "2")
                {
                    //activate moveset 2
                }
                else if (r == "3")
                {
                    //activate moveset 3
                    //at this porint  it will go back to old moveset
                }
               












                //if things dont work out then  uncomment everything and readd the break
                //delet the new menu option andreset the event for sending










                toSend = new byte[1000];
                                              
                                             //will put a method for sending
                                               // ms = SerializeObj.ser(cfch);//works
                                                
                                                StateObj state5 = new StateObj();

                                                state5.currentSock = hand;

                hand.BeginReceive(state.buffer, 0, _bufferSize, 0, new AsyncCallback(ReadCallback), state);//works


                // hand.BeginSend(toSend, 0, toSend.Length, SocketFlags.None, new AsyncCallback(SendCallback), state5);



                //at this point it needs to check for the  current tyep   
            }

            else
	        {
                hand.Close();
	        }
                

            

        }//seems legit
         public static void SendCallback(IAsyncResult air) 
        {
           



            StateObj state = (StateObj)air.AsyncState;
            Socket handler = state.currentSock;
            handler.EndSend(air);



            StateObj newstate = new StateObj();
            newstate.currentSock = handler;
            //resets type back to 0
           
            handler.BeginReceive(newstate.buffer, 0, newstate.buffer.Length, 0, new AsyncCallback(ReadCallback), newstate);
                    
        }//Correct
         static bool IsConnected(Socket s)
        {
               //returns the reult
            return !((s.Poll(1000, SelectMode.SelectRead) && (s.Available == 0)) || !s.Connected);
        }//Correct
         public static void Send(int type)
         {
            //makes the global object qhat euivilent to the parsed obj
            
            byte[] bytes=new byte[1024];
            //nneed to send umber
            //will let the server know what to expect
            listerner.BeginSend(bytes, 0, bytes.Length, 0, new AsyncCallback(SendCallback), listerner);//check this should work 
         }//check it 
           
           

       
                    
           
                
            
               

              
                
                



             
               

                
         




        }

        
    }


