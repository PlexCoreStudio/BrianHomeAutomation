using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace BrianHomeAuto
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer s = new SpeechSynthesizer();
        Choices list = new Choices();
        public Form1()
        {
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
            list.Add(new String[] { "hello", "how are you", "time" });

            Grammar gr = new Grammar(new GrammarBuilder(list));

            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);
                rec.SpeechRecognized += rec_SpeachRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch { return; }

            s.Speak("Hello, I'm Brian. What can I help you with?");
            InitializeComponent();
        }

        public void say(String h)
        {
            s.Speak(h);
        }

        private void rec_SpeachRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String r = e.Result.Text;

            if(r == "hello")
            {
                say("Hi");
            }

            if (r == "how are you")
            {
                say("I'm good, and you?");
            }

            if (r == "time")
            {
                say(DateTime.Now.ToString("h:mm"));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
