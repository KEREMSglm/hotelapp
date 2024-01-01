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

        Color mic_Color;
        public HOTEL_App0()
        {
            InitializeComponent();
            this.mic_Color = btn_Header.BackColor;
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

        }



        private void mic_MouseDown(object sender, MouseEventArgs e)
        {
            frm_HOTEL f = (frm_HOTEL)this.ParentForm;
            btn_Header.BackColor=Color.Green;
            f.mic_MouseDown(sender, e);
        }

        private void mic_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Header.BackColor = mic_Color;
            frm_HOTEL f = (frm_HOTEL)this.ParentForm;
            f.mic_MouseUp(sender, e);
            txt_Search.Text=f.txt_Search.Text;
        }
    }
}
