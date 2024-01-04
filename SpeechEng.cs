using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace WindowsFormsApp
{
    internal class SpeechEng
    {

        private static SpeechEng instance = null;
        private string text = "";

        SpeechRecognitionEngine recognizer = null;
        private SpeechEng() {
            var recognizerInfo = GetRecognizer();
            recognizer = new SpeechRecognitionEngine(recognizerInfo);
        }
        public static SpeechEng getInstance()
        {
            if (instance == null)
                instance = new SpeechEng();
            return instance;
        }

        private void startRecognition()
        {
            try
            {
                text = "No Data";

                // load grammar file
                //var grammar = new Grammar("grammar.xml");
                

                Choices sesGrubu = new Choices("reservation", "list", "rooms");
                GrammarBuilder gramerYapilandirici = new GrammarBuilder(sesGrubu);
                gramerYapilandirici.Culture = System.Globalization.CultureInfo.GetCultureInfoByIetfLanguageTag("en-US");
                Grammar grammar = new Grammar(gramerYapilandirici);
                recognizer.LoadGrammar(grammar);

                recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
                recognizer.SetInputToDefaultAudioDevice(); 

                // Tanıma işlemini başlatın
                recognizer.RecognizeAsync(RecognizeMode.Multiple);


                // Tanıma işlemini durdurun
                recognizer.RecognizeAsyncStop();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void stopRecognition()
        {
            try {
                recognizer.RecognizeAsyncStop();
            } catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Tanıma başarılı olduğunda çağrılır
            Console.WriteLine("Text: " + e.Result.Text);
            text = e.Result.Text;
        }

        private RecognizerInfo GetRecognizer()
        {
            
            foreach (RecognizerInfo ri in SpeechRecognitionEngine.InstalledRecognizers())
            {
                string t = ri.Culture.Name;
                    return ri;
                
            }

            throw new Exception("en-US Recognation Engine has not been found.");
        }


        private bool startFlag = false;
        public void start()
        {
            if (startFlag)
                stopRecognition();
            startFlag = true;
            startRecognition();
        }

        public string stopAndGetTranscript()
        {
            stopRecognition();
            startFlag = false;
            return text;
        }

    }
}
