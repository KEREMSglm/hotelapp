using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace WindowsFormsApp
{
    public partial class HOTEL_App0 : UserControl
    {
        SpeechRecognitionEngine SRE = new SpeechRecognitionEngine();
        public HOTEL_App0()
        {
            InitializeComponent();
        }
        void SpeechMic()
        {
            string[] order = { "HELLO", "HI" };
            Choices select = new Choices(order);
            Grammar grammar = new Grammar(new GrammarBuilder(select));
            grammar = new DictationGrammar();
            SRE.LoadGrammar(grammar);
            SRE.SetInputToDefaultAudioDevice();
            SRE.SpeechRecognized += notice;

        }
        public void notice(object sender, SpeechRecognizedEventArgs e)
        {
            txt_Search.Text = e.Result.Text;

        } 
        private void HOTEL_App0_Load(object sender, EventArgs e)
        {
            //this.BackColor = System.Drawing.Color.DeepGrey;
            this.BackColor = System.Drawing.Color.DarkGray;
        }

        Boolean speechFlag;
        private void btn_Header_Click(object sender, EventArgs e)
        {
            if (speechFlag)
            {
                this.btn_Header.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                SRE.RecognizeAsyncStop();
            }
            else
            {
                this.btn_Header.BackColor= Color.Green;
                SpeechMic();
                SRE.RecognizeAsync();

            }
            speechFlag= !speechFlag;
        }
    }
}
