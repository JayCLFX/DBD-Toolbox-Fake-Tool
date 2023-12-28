using System;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace DBD_Toolbox_Remake
{
    public partial class MainWindow : Form
    {

        //Base
        public bool Pressed_Unpack;
        public bool Pressed_Repack;

        public float Timer;
        public float Timer_02;

        public bool Timer_finished;
        public bool Timer_2_finished;

        //Main Paths
        string Main_Directory_Path = @"C:\Unpacks";

        string Directory_Pakchunk_0 = @"C:\Unpacks\Pakchunk_0";
        string Directory_Pakchunk_1 = @"C:\Unpacks\Pakchunk_1";
        string Directory_Pakchunk_2 = @"C:\Unpacks\Pakchunk_2";
        string Directory_Pakchunk_3 = @"C:\Unpacks\Pakchunk_3";
        string Directory_Pakchunk_4 = @"C:\Unpacks\Pakchunk_4";
        string Directory_Pakchunk_5 = @"C:\Unpacks\Pakchunk_5";
        string Directory_Pakchunk_6 = @"C:\Unpacks\Pakchunk_6";
        string Directory_Pakchunk_7 = @"C:\Unpacks\Pakchunk_7";
        string Directory_Pakchunk_8 = @"C:\Unpacks\Pakchunk_8";
        string Directory_Pakchunk_9 = @"C:\Unpacks\Pakchunk_9";
        string Directory_Pakchunk_10 = @"C:\Unpacks\Pakchunk_10";
        string Directory_Pakchunk_11 = @"C:\Unpacks\Pakchunk_11";
        string Directory_Pakchunk_12 = @"C:\Unpacks\Pakchunk_12";
        string Directory_Pakchunk_13 = @"C:\Unpacks\Pakchunk_13";
        string Directory_Pakchunk_14 = @"C:\Unpacks\Pakchunk_14";
        string Directory_Pakchunk_15 = @"C:\Unpacks\Pakchunk_15";
        string Directory_Pakchunk_16 = @"C:\Unpacks\Pakchunk_16";
        string Directory_Pakchunk_17 = @"C:\Unpacks\Pakchunk_17";
        string Directory_Pakchunk_18 = @"C:\Unpacks\Pakchunk_18";
        string Directory_Pakchunk_19 = @"C:\Unpacks\Pakchunk_19";


        //File Paths
        static string File_Pakchunk_0 = @"C:\Unpacks\Pakchunk_0\pakchunk0-WindowsNoEditor.cax";
        static string File_Pakchunk_1 = @"C:\Unpacks\Pakchunk_1\pakchunk1-WindowsNoEditor.cax";
        static string File_Pakchunk_2 = @"C:\Unpacks\Pakchunk_2\pakchunk2-WindowsNoEditor.cax";
        static string File_Pakchunk_3 = @"C:\Unpacks\Pakchunk_3\pakchunk3-WindowsNoEditor.cax";
        static string File_Pakchunk_4 = @"C:\Unpacks\Pakchunk_4\pakchunk4-WindowsNoEditor.cax";
        static string File_Pakchunk_5 = @"C:\Unpacks\Pakchunk_5\pakchunk5-WindowsNoEditor.cax";
        static string File_Pakchunk_6 = @"C:\Unpacks\Pakchunk_6\pakchunk6-WindowsNoEditor.cax";
        static string File_Pakchunk_7 = @"C:\Unpacks\Pakchunk_7\pakchunk7-WindowsNoEditor.cax";
        static string File_Pakchunk_8 = @"C:\Unpacks\Pakchunk_8\pakchunk8-WindowsNoEditor.cax";
        static string File_Pakchunk_9 = @"C:\Unpacks\Pakchunk_9\pakchunk9-WindowsNoEditor.cax";
        static string File_Pakchunk_10 = @"C:\Unpacks\Pakchunk_10\pakchunk10-WindowsNoEditor.cax";
        static string File_Pakchunk_11 = @"C:\Unpacks\Pakchunk_11\pakchunk11-WindowsNoEditor.cax";
        static string File_Pakchunk_12 = @"C:\Unpacks\Pakchunk_12\pakchunk12-WindowsNoEditor.cax";
        static string File_Pakchunk_13 = @"C:\Unpacks\Pakchunk_13\pakchunk13-WindowsNoEditor.cax";
        static string File_Pakchunk_14 = @"C:\Unpacks\Pakchunk_14\pakchunk14-WindowsNoEditor.cax";
        static string File_Pakchunk_15 = @"C:\Unpacks\Pakchunk_15\pakchunk15-WindowsNoEditor.cax";
        static string File_Pakchunk_16 = @"C:\Unpacks\Pakchunk_16\pakchunk16-WindowsNoEditor.cax";
        static string File_Pakchunk_17 = @"C:\Unpacks\Pakchunk_17\pakchunk17-WindowsNoEditor.cax";
        static string File_Pakchunk_18 = @"C:\Unpacks\Pakchunk_18\pakchunk18-WindowsNoEditor.cax";
        static string File_Pakchunk_19 = @"C:\Unpacks\Pakchunk_19\pakchunk19-WindowsNoEditor.cax";

        //File Producer
        static int Random_Number_00;
        static int Random_Number_01;
        static int Random_Number_02;
        static int Random_Number_03;
        static int Random_Number_04;
        static int Random_Number_05;
        static int Random_Number_06;
        static int Random_Number_07;
        static int Random_Number_08;
        static int Random_Number_09;
        static int Random_Number_10;
        static int Random_Number_11;
        static int Random_Number_12;
        static int Random_Number_13;
        static int Random_Number_14;
        static int Random_Number_15;
        static int Random_Number_16;
        static int Random_Number_17;
        static int Random_Number_18;
        static int Random_Number_19;

        //Runtime
        public static string ExecutablePathAndFileName { get; } = Process.GetCurrentProcess().MainModule.FileName;
        public static string DataDrive { get; } = Path.GetPathRoot(ExecutablePathAndFileName);
        public static string ExecutableFolder { get; } = Path.GetDirectoryName(ExecutablePathAndFileName);

        string currentPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        public string WorkingDirectory { get; set; }





        //MessageBox01 (Unpacker)
        string Message01 = "Unpacking Paks, Please wait!";
        string Title = "DbD Toolbox";

        //MessageBox02 (Repack Error)
        string Message02 = "Paks not fully unpacked, Progress:";

        //MessageBox03 (Unpack already)
        string Message03 = "Already Unpacking";

        //MessageBox04 
        string Message04 = "Unpacking Progress at 50%";

        //MessageBox05
        string Message05 = "Reconstructing Paks, currently at: ";

        //MessageBox06
        string Message06 = "Unpacking Finished, Reconstructing Pakchunk";

        //MessageBox07
        string Message07 = "Do you want to Replace the original Paks with the new ones ?";

        //MessageBox08
        string Message08 = "Reconstructing Pakchunks, Currently at:";

        //MessageBox09
        string Message09 = "Unpacking Complete";

        //MessageBox10
        string Message10 = "Reconstruction currently at: ";

        public MainWindow()
        {
            InitializeComponent();
        }





        private void MainWindow_Load(object sender, EventArgs e)
        {
            Pressed_Unpack = false;
            Pressed_Repack = false;

            Timer = 0;
            timer1.Enabled = false;
            Timer_finished = false;

            Timer_02 = 0;
            timer2.Enabled = false;
            Timer_2_finished = false;
        }





        private void UnpackButton_Click(object sender, EventArgs e)
        {

            if (Pressed_Unpack == true)
            {
                if (Timer_finished == false)
                {
                    MessageBox.Show(Message03, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Timer_finished == true)
                {
                    MessageBox.Show(Message05 + Timer_02 + "%", Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                Pressed_Unpack = true;

                if (Timer_finished == false)
                {
                    timer1.Enabled = true;
                    MessageBox.Show(Message01, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timer_finished == false)
            {
                if (Pressed_Unpack == true)
                {
                    Timer += 1;
                    Console.WriteLine("Progress:" + Timer + "%");
                }
                
               
                if (Timer == 5)
                {
                    CreateFolder();
                    Console.WriteLine(currentPath);
                  //  Process.Start("DBD_Toolbox_Runtime.exe");
                }







                if (Timer == 50)
                {
                    MessageBox.Show(Message04, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (Timer >= 100)
                {
                    Timer_finished = true;
                }

                if (Timer == 99)
                {
                    MessageBox.Show(Message06, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (Timer_finished == true)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            Timer_02 += 1;
            //Console.WriteLine("Timer02 At:  " + Timer_02);

            if (Timer_02 == 5)
            {
                Thread t0 = new Thread(CreateDataThread00)
                {
                    Name = "Thread 00"
                };

                Thread t1 = new Thread(CreateDataThread01)
                {
                    Name = "Thread 01"
                };

                Thread t2 = new Thread(CreateDataThread02)
                {
                    Name = "Thread 02"
                };

                Thread t3 = new Thread(CreateDataThread03)
                {
                    Name = "Thread 03"
                };

                Thread t4 = new Thread(CreateDataThread04)
                {
                    Name = "Thread 04"
                };

                t0.Start();
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
            }

            if (Timer_02 == 50)
            { 
                MessageBox.Show(Message10 + Timer_02 + "%", Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Timer_02 >= 100)
            {
                Timer_2_finished = true;
                timer2.Enabled = false;
                MessageBox.Show(Message09, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RepackButton_Click(object sender, EventArgs e)
        {
            if (Pressed_Unpack == true)
            {
                if (Timer_finished == false)
                {
                    if (Timer <= 99)
                    {
                        MessageBox.Show(Message02 + Timer + "%", Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (Timer_finished == true)
                {
                    if (Timer_2_finished == false)
                    {
                        MessageBox.Show(Message08 + Timer_02 + "%", Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


                if (Timer_finished == true)
                {
                    if (Timer_2_finished == true)
                    {
                        DialogResult result = MessageBox.Show(Message07, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            Console.WriteLine("Pressed Yes");

                        }
                        else
                        {
                            Console.WriteLine("Pressed No");
                            return;
                        }
                    }
                }
            }
        }










        static void CreateDataThread00()
        {
            using (StreamWriter Pakchunk_00 = File.AppendText(File_Pakchunk_0))
            {
                for (int i = 1; i < 1000000; i++)
                {
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                }
            }

            using (StreamWriter Pakchunk_00 = File.AppendText(File_Pakchunk_0))
            {
                for (int i = 1; i < 1000250; i++)
                {
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);
                    Pakchunk_00.Write(Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00 + "\n" + Random_Number_00);

                    if (i == 1000250)
                    {
                        Thread.Sleep(10000);
                        Console.WriteLine("Thread 00 Completed");
                    }
                }
            }
        }

        static void CreateDataThread01()
        {
            using (StreamWriter Pakchunk_01 = File.AppendText(File_Pakchunk_1))
            {
                for (int i = 1; i < 1000000; i++)
                {
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                }
            }

            using (StreamWriter Pakchunk_01 = File.AppendText(File_Pakchunk_1))
            {
                for (int i = 1; i < 1000250; i++)
                {
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);
                    Pakchunk_01.Write(Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01 + "\n" + Random_Number_01);

                    if (i == 1000250)
                    {
                        Thread.Sleep(10000);
                        Console.WriteLine("Thread 01 Completed");
                    }
                }
            }
        }

        static void CreateDataThread02()
        {
            using (StreamWriter Pakchunk_02 = File.AppendText(File_Pakchunk_2))
            {
                for (int i = 1; i < 1000000; i++)
                {
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                }
            }

            using (StreamWriter Pakchunk_02 = File.AppendText(File_Pakchunk_2))
            {
                for (int i = 1; i < 1000250; i++)
                {
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);
                    Pakchunk_02.Write(Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02 + "\n" + Random_Number_02);

                    if (i == 1000250)
                    {
                        Thread.Sleep(10000);
                        Console.WriteLine("Thread 02 Completed");
                    }
                }
            }
        }

        static void CreateDataThread03()
        {
            using (StreamWriter Pakchunk_03 = File.AppendText(File_Pakchunk_3))
            {
                for (int i = 1; i < 1000000; i++)
                {
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                }
            }

            using (StreamWriter Pakchunk_03 = File.AppendText(File_Pakchunk_3))
            {
                for (int i = 1; i < 1000250; i++)
                {
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);
                    Pakchunk_03.Write(Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03 + "\n" + Random_Number_03);

                    if (i == 1000250)
                    {
                        Thread.Sleep(10000);
                        Console.WriteLine("Thread 03 Completed");
                    }
                }
            }
        }

        static void CreateDataThread04()
        {
            using (StreamWriter Pakchunk_04 = File.AppendText(File_Pakchunk_4))
            {
                for (int i = 1; i < 1000000; i++)
                {
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                }
            }

            using (StreamWriter Pakchunk_04 = File.AppendText(File_Pakchunk_4))
            {
                for (int i = 1; i < 1000250; i++)
                {
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);
                    Pakchunk_04.Write(Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04 + "\n" + Random_Number_04);

                    if (i == 1000250)
                    {
                        Thread.Sleep(10000);
                        Console.WriteLine("Thread 04 Completed");
                    }
                }
            }
        }

        private void CreateFolder()
        {
                if (!Directory.Exists(Main_Directory_Path))
                {
                    Directory.CreateDirectory(Main_Directory_Path);
                }
                if (!Directory.Exists(Directory_Pakchunk_0))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_0);
                    using (FileStream fs = File.Create(File_Pakchunk_0, 1024)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_1))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_1);
                    using (FileStream fs = File.Create(File_Pakchunk_1)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_2))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_2);
                    using (FileStream fs = File.Create(File_Pakchunk_2)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_3))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_3);
                    using (FileStream fs = File.Create(File_Pakchunk_3)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_4))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_4);
                    using (FileStream fs = File.Create(File_Pakchunk_4)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_5))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_5);
                    using (FileStream fs = File.Create(File_Pakchunk_5)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_6))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_6);
                    using (FileStream fs = File.Create(File_Pakchunk_6)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_7))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_7);
                    using (FileStream fs = File.Create(File_Pakchunk_7)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_8))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_8);
                    using (FileStream fs = File.Create(File_Pakchunk_8)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_9))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_9);
                    using (FileStream fs = File.Create(File_Pakchunk_9)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_10))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_10);
                    using (FileStream fs = File.Create(File_Pakchunk_10)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_11))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_11);
                    using (FileStream fs = File.Create(File_Pakchunk_11)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_12))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_12);
                    using (FileStream fs = File.Create(File_Pakchunk_12)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_13))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_13);
                    using (FileStream fs = File.Create(File_Pakchunk_13)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_14))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_14);
                    using (FileStream fs = File.Create(File_Pakchunk_14)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_15))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_15);
                    using (FileStream fs = File.Create(File_Pakchunk_15)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_16))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_16);
                    using (FileStream fs = File.Create(File_Pakchunk_16)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_17))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_17);
                    using (FileStream fs = File.Create(File_Pakchunk_17)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_18))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_18);
                    using (FileStream fs = File.Create(File_Pakchunk_18)) ;
                }

                if (!Directory.Exists(Directory_Pakchunk_19))
                {
                    Directory.CreateDirectory(Directory_Pakchunk_19);
                    using (FileStream fs = File.Create(File_Pakchunk_19)) ;
                }
        }
    }
}
