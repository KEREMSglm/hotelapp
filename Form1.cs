using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.AudioFormat;
using System.Globalization;
using System.Speech.Synthesis;
using System.Threading;

//using SpeechLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SpeechLib.Models;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp
{
    public partial class frm_HOTEL : Form
    {
        Color micBtnColor;
        public frm_HOTEL()
        {
            InitializeComponent();
            micBtnColor = btn_Mic.BackColor;

        }

        //SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        //SpeechSynthesizer Sarah = new SpeechSynthesizer();
        //SpeechRecognitionEngine startlistening = new SpeechRecognitionEngine();
        Random rnd = new Random();
        DateTime TimeNow = DateTime.Now;
        int RecTimeOut = 0;

        public void SpeechMic()
        {
           

            //SpeechRecognitionEngine reco = new SpeechRecognitionEngine();
            //Grammar grammar = new DictationGrammar();
            //reco.LoadGrammar(grammar);
            //try
            //{
            //    MessageBox.Show("Microphone Open");
            //    reco.SetInputToDefaultAudioDevice();
            //    RecognitionResult res = reco.Recognize();
            //    txt_Search.Text = res.Text;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("ERROR...");
            //}

            //try
            //{
            //string[] order = {"Sakla","Göster","CustomerAdd Git","CustommerList Git","CustomerPath Git","Ekle","Anasayfaya Git", };
            //Choices choices = new Choices(order);
            //Grammar grammar = new Grammar(new GrammarBuilder(choices));
            ////RecognitionResult res = SRE.Recognize();
            ////grammar = new DictationGrammar();
            //SRE.LoadGrammar(grammar);
            //SRE.SetInputToDefaultAudioDevice();
            //SRE.SpeechRecognized += notice;

            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error... Pleas try again");
            //}

        }

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            int ranNum;
            string speech = e.Result.Text;
            txt_Search.Text = speech;

            /*if (speech=="Merhaba") { Sarah.SpeakAsync("Hello, I am here"); }

            if (speech=="Nasılsın") { Sarah.SpeakAsync("I am working normally"); }

            if (speech=="Saat Kaç") { Sarah.SpeakAsync(DateTime.Now.ToString("h mm ss")); }

            if (speech=="Dinleme")
            {
                this.btn_Mic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                Sarah.SpeakAsyncCancelAll();
                ranNum=rnd.Next(1, 2);
                if (ranNum==1) { Sarah.SpeakAsync("Yes sir"); }
                if (ranNum==2) { Sarah.SpeakAsync("I am sorry i will be quite"); }
            }

            if (speech == "Konuşma")
            {
                this.btn_Mic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                Sarah.SpeakAsync("if you need me just ask");
                _recognizer.RecognizeAsyncCancel();
                startlistening.RecognizeAsync(RecognizeMode.Multiple);
            }

            if (speech == "Komutları Göster")
            {


                string[] commands = (File.ReadAllLines(@"DefaultCommands"));
                LstCommands.Items.Clear();
                LstCommands.SelectionMode = SelectionMode.None;
                LstCommands.Visible = true;
                foreach (string command in commands)
                {

                    LstCommands.Items.Add(command);
                }
            }

            if (speech == "Komutları Sakla")
            {
                LstCommands.Visible = false;
            }*/
        }

        private void _recognizer_SpeechRecognized(object sender, SpeechDetectedEventArgs e)
        {
            RecTimeOut = 0;
        }

        /*private void startlistening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;
            if (speech=="Wake up") { startlistening.RecognizeAsyncCancel(); Sarah.SpeakAsync("Yes, I am here "); _recognizer.RecognizeAsync(RecognizeMode.Multiple); }
        }
        private void TmrSpeaking_Tick(object sender, EventArgs e)
        {
            if (RecTimeOut == 10) { _recognizer.RecognizeAsyncCancel(); }
            else if (RecTimeOut == 11) { TmrSpeaking.Stop(); startlistening.RecognizeAsync(RecognizeMode.Multiple); }
            RecTimeOut= 0;
        }*/







        //void DocummentPath()
        //{
        //    string Location = a.ToString();
        //    string[] array = Location.Split(':', '\\');
        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        string newpathrenneval = array[0]+":\\";
        //        string newpathrennevaladd = newpathrenneval.ToString() + array[i].ToString();
        //        var di = new DirectoryInfo(System.IO.Path.GetFullPath(Location).ToString()).ToString();
        //        var fi = new FileInfo(System.IO.Path.GetFileName(Location).ToString()).ToString();
        //        if (newpathrennevaladd.ToString() != di)
        //        {
        //            if (array[array.Length] != fi)
        //            {
        //                MessageBox.Show("Pleas Entered File Text Title.");
        //                return;
        //            }
        //            string file = System.IO.Path.Combine(newpathrennevaladd, array[array.Length]);
        //            System.IO.File.CreateText(file);
        //            MessageBox.Show("File Path :"+array[array.Length]+"\n Creat Sucssesfully Compelet.");
        //        }
        //        else
        //        {
        //            string path = System.IO.Path.Combine(newpathrennevaladd, array[i].ToString());
        //            System.IO.Directory.CreateDirectory(path);
        //            MessageBox.Show("Directory Path : "+array[array.Length-1]+"\n Create Sucssesfully Compelet.");
        //            return;
        //        }
        //    }
        //}


        private void notice(object sender, SpeechRecognizedEventArgs e)
        {
            //txt_Search.Text = e.Result.Text;
            //Console.WriteLine(e.Result.Text);
            //this.btn_Mic.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            ////SRE.RecognizeAsyncStop();
            //speechFlag=false;
        }
        private void frm_tblp_pnl1_HOTEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Costommer_Add_Click(object sender, EventArgs e)
        {
            hoteL_App3.refreshTable(); 
            
            hoteL_App0.Hide();
            hoteL_App1.Hide();
            hoteL_App2.Hide();
            hoteL_App3.Show();
        }

        private void btn_Costomer_List_Click(object sender, EventArgs e)
        {
            hoteL_App1.refreshTable();

            hoteL_App0.Hide();
            hoteL_App1.Show();
            hoteL_App2.Hide();
            hoteL_App3.Hide();

            
        }

        private void btn_Costommer_Path_Click(object sender, EventArgs e)
        {
            hoteL_App0.Hide();
            hoteL_App1.Hide();
            hoteL_App2.Show();
            hoteL_App3.Hide();
        }

        private void frm_HOTEL_Load(object sender, EventArgs e)
        {
            /*_recognizer.SetInputToDefaultAudioDevice();
            _recognizer.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands")))));
            _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
            _recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(_recognizer_SpeechRecognized);
            _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            startlistening.SetInputToDefaultAudioDevice();
            startlistening.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices(File.ReadAllLines(@"DefaultCommands")))));
            startlistening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(startlistening_SpeechRecognized);
            */
            loadReservationListFromFile();
            hoteL_App0.Show();
            hoteL_App1.Hide();
            hoteL_App2.Hide();
            hoteL_App3.Hide();
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            hoteL_App0.Show();
            hoteL_App1.Hide();
            hoteL_App2.Hide();
            hoteL_App3.Hide();
        }

        Boolean speechFlag=false;
        private void btn_Mic_Click(object sender, EventArgs e)
        {

        }

        private void frm_HOTEL_FormClosing(object sender, FormClosingEventArgs e)
        {
            writeReservationListToFile();
        }

        private void writeReservationListToFile()
        {
            Program.WriteToBinaryFile<ArrayList>(Program.FILE_PATH, Program.reservationList);
            
        }

        private void loadReservationListFromFile()
        {
            if (File.Exists(Program.FILE_PATH)) {
                Program.reservationList = Program.ReadFromBinaryFile<ArrayList>(Program.FILE_PATH);
                Program.adjustReservationCount();
            }
                
        }

        public void mic_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Mic.BackColor=Color.Green;
            Speech.getInstance().start();
        }

        public void mic_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Mic.BackColor = micBtnColor;
            Speech s = Speech.getInstance();
            
            string text = s.stopAndGetTranscript();

            txt_Search.Text=text;

            if (text.ToLower().Trim().Replace(" ","").Equals("rezervasyon"))
            {
                btn_Costommer_Add_Click(null, null);
            }
            else if (text.ToLower().Trim().Replace(" ", "").Equals("liste"))
            {
                btn_Costomer_List_Click(null, null);
            }
            else if (text.ToLower().Trim().Replace(" ", "").Equals("odalar"))
            {
                btn_Costommer_Path_Click(null, null);
            }
            else if (
                text.ToLower().Trim().Replace(" ", "").IndexOf("oda") == 0
                || text.ToLower().Trim().Replace(" ", "").IndexOf("odabir") == 0
                || text.ToLower().Trim().Replace(" ", "").IndexOf("odayedi") == 0
                )
            {
                string room=text.ToLower().Trim().Replace(" ", "").Replace("oda", "");
                int result;
                bool isNumeric = int.TryParse(room, out result);//
                if (isNumeric)
                {
                    RoomCalendar r = new RoomCalendar(room);
                    r.ShowDialog();
                }
                else if (room.Equals("bir"))
                {
                    RoomCalendar r = new RoomCalendar("1");
                    r.ShowDialog();
                }
                else if (room.Equals("yedi"))
                {
                    RoomCalendar r = new RoomCalendar("7");
                    r.ShowDialog();
                }
            }
        }

        private void frm_HOTEL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                
                switch (e.KeyCode)
                {
                    case Keys.ControlKey:return;
                    case Keys.A:
                        btn_Costommer_Add_Click(null, null);
                        return;
                    case Keys.L:
                        btn_Costomer_List_Click(null, null);
                        return;
                    case Keys.R:
                        btn_Costommer_Path_Click(null, null);
                        return;
                    default: break;

                }

                try {
                    int room = e.KeyValue-48;
                    if(room == 0) { room = 10; }
                    RoomCalendar r = new RoomCalendar(room.ToString());
                    r.ShowDialog();
                } 
                catch
                {
                    
                }
                

            }
            
        }
    }
}
