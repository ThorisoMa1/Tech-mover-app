using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.IO;
using System.Data;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Harware_TechM
{
    
    class AsyncClient2
    {
        public static Switchboard f1;
        public int recieveType = 0;
        public const int _bufferSize = 1024;
        public const int _port = 8080;
        public static bool _isRunning = true;
        public static bool loggedIn = false;
        
       
        public static object TempObj;
        public static Socket listerner;
     
        public static string temp;
     
        public static ManualResetEvent RecieveDone = new ManualResetEvent(false);
   
        public static ManualResetEvent SendDone = new ManualResetEvent(false);
        public static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        public static ManualResetEvent Done = new ManualResetEvent(false);
      
       

        class StateObj
        {
            public Socket currentSock = null;
            public byte[] buffer = new byte[_bufferSize];
            public StringBuilder sb = new StringBuilder();


        }
        public static void Connect(Switchboard ds)
        {

            f1 = ds;
            ds.Hide();
            f1.Show(); 

                 IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
                 IPEndPoint localEP = new IPEndPoint(IPAddress.Parse("192.168.60.50"), _port);
                 listerner = new Socket(localEP.Address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
          
                 listerner.BeginConnect(localEP,new AsyncCallback(ConnectCallBack),listerner);

         
            
            

        }
        public static void ConnectCallBack(IAsyncResult ar) 
        {
            
            Socket Client = (Socket)ar.AsyncState;

            StateObj obj = new StateObj();

            Client.EndConnect(ar);
            MessageBox.Show("Connected to server");
            ConnectDone.Set();
            Client.BeginReceive(obj.buffer, 0, _bufferSize, 0, new AsyncCallback(ReadCallback), Client);



        }//connects 

        public static void Send(int type) 
        {
            SendDone = new ManualResetEvent(false);
            //makes the global object qhat euivilent to the parsed obj
          
           
            byte[] bytes = Encoding.ASCII.GetBytes(type.ToString());
           
            //will let the server know what to expect
            listerner.BeginSend(bytes, 0, bytes.Length, 0,new AsyncCallback(SendCallBack), listerner);//check this should work 
            SendDone.Set();
        }//check it 
         public static void SendCallBack(IAsyncResult ar) 
            {

                //after it sends then it will  send the object
                StateObj st = new StateObj();
                st.currentSock = listerner;
                Socket hand = st.currentSock;
                int test = hand.EndSend(ar);

                if (test>0)
                {
                    
                       
                            //sends the authentication details
                    
                      
                       

                            //tells it to reieve
                              st.buffer = new byte[1024];
                              
                              hand.BeginReceive(st.buffer, 0, _bufferSize, 0, new AsyncCallback(ReadCallback), st);
                  
                        
                        
                       

                          
                       
                
                
                    
               
               
                }
                else
                {
                    MessageBox.Show("Failed to send");
                }
            
                //SendDone.Set();
                //st.currentSock = hand;
           


                //tells it to listen again
           
           



            
            
            }//will telll it to wait for reply
        public static void ReadCallback(IAsyncResult air)
        {
           
            //makes it equal to the current connection
            StateObj state = (StateObj)air.AsyncState;
            Socket hand = state.currentSock;

            if (!IsConnected(hand))
            {
                hand.Close();
                return;
            }

            int read = hand.EndReceive(air);

            if (read > 0)
            {
                
                //do something
               ///now it need to check for the type of object that its biulding 
               
               
            }

            else
            {
                hand.Close();
            }
            RecieveDone.Set();
            



        }
        static bool IsConnected(Socket s)
        {
            //returns the reult
            return !((s.Poll(1000, SelectMode.SelectRead) && (s.Available == 0)) || !s.Connected);
        }//Correct


      



    }
}
