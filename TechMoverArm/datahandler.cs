using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data;


namespace Harware_TechM
{
    class datahandler
    {
        private  static string Path = "moves.txt";
        private static string Path2 = "moves2.txt";
        private static string Path3 = "moves3.txt";
        public datahandler()
        {

        }
        public static bool Write(List<string>commmands,FileMode fm=FileMode.Create)
        {
           
            bool success = false;

            FileStream fs = new FileStream(Path,fm);//creates the filestream for the file mode

            StreamWriter sw = new StreamWriter(fs);
            
            foreach (string item in commmands)
            {
                try
                {
                    sw.WriteLine(item);
                }
                catch (Exception)
                {
                    return success;
                    
                }
               
            }
            sw.Close();//will write new recorderd commands t text file
            return true;
        }// will save the commands to a txt

        public static List<string> Readstring ( FileMode Fm = FileMode.Open)
        {
            string line = "";
            List<string> comands = new List<string>();
            FileStream fs = new FileStream(Path, Fm);//creates the filestream for the file mode

            StreamReader sr = new StreamReader(fs);
            line = sr.ReadLine();
            while (line!=null)
            {
                
                comands.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return comands;
        }//will retun the command  to alist to be used to play 

        public static bool Write2(List<string> commmands, FileMode fm = FileMode.Create)
        {

            bool success = false;

            FileStream fs = new FileStream(Path2, fm);//creates the filestream for the file mode

            StreamWriter sw = new StreamWriter(fs);

            foreach (string item in commmands)
            {
                try
                {
                    sw.WriteLine(item);
                }
                catch (Exception)
                {
                    return success;

                }

            }
            sw.Close();//will write new recorderd commands t text file
            return true;
        }// will save the commands to a txt

        public static List<string> Readstring2(FileMode Fm = FileMode.Open)
        {
            string line = "";
            List<string> comands = new List<string>();
            FileStream fs = new FileStream(Path2, Fm);//creates the filestream for the file mode

            StreamReader sr = new StreamReader(fs);
            line = sr.ReadLine();
            while (line != null)
            {

                comands.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return comands;
        }//will retun the command  to alist to be used to play 

        public static bool Write3(List<string> commmands, FileMode fm = FileMode.Create)
        {

            bool success = false;

            FileStream fs = new FileStream(Path3, fm);//creates the filestream for the file mode

            StreamWriter sw = new StreamWriter(fs);

            foreach (string item in commmands)
            {
                try
                {
                    sw.WriteLine(item);
                }
                catch (Exception)
                {
                    return success;

                }

            }
            sw.Close();//will write new recorderd commands t text file
            return true;
        }// will save the commands to a txt

        public static List<string> Readstring3(FileMode Fm = FileMode.Open)
        {
            string line = "";
            List<string> comands = new List<string>();
            FileStream fs = new FileStream(Path3, Fm);//creates the filestream for the file mode

            StreamReader sr = new StreamReader(fs);
            line = sr.ReadLine();
            while (line != null)
            {

                comands.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            return comands;
        }//will retun the command  to alist to be used to play 


    }
}
