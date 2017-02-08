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
using System.Diagnostics;

namespace BrianHomeAuto
{
    public partial class Form1 : Form
    {

        SpeechSynthesizer s = new SpeechSynthesizer();
        Boolean wake = true;
        Choices list = new Choices();
        public Form1()
        {
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
            list.Add(new String[] {"wake", "sleep", "hello", "how are you", "time", "date", "open google", "restart", "update", "open word", "close word"});

            Grammar gr = new Grammar(new GrammarBuilder(list));

            try
            {
                rec.RequestRecognizerUpdate();
                rec.LoadGrammar(gr);
                rec.SpeechRecognized += rec_SpeachRecognized;
                rec.SetInputToDefaultAudioDevice();
                rec.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }

            InitializeComponent();
        }

        public void restart()
        {
            Application.Restart();
        }

        public void say(String h)
        {
            s.Speak(h);
            outputTextbox.AppendText(h + "\n");
        }

        private void rec_SpeachRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String r = e.Result.Text;

            if (r == "wake")
            {
                stateLable.Text = "State: Awake";
                say("I'm Awake");
                wake = true;
            }
            if (r == "sleep")
            {
                stateLable.Text = "State: Sleep mode";
                say("I'm sleeping");
                wake = false;
            }

            if (wake == true)
            {
                if (r == "restart" || r == "update")
                {
                    restart();
                }

                if (r == "hello")
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

                if (r == "date")
                {
                    say(DateTime.Now.ToString("M/d/yyyy"));
                }

                if (r == "open google")
                {
                    Process.Start("http://google.com");
                    say("Opening google");
                }

                if (r == "open word")
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = "WINWORD.EXE";
                    Process.Start(startInfo);
                    say("opening word");
                }
            }
            inputTextbox.AppendText(r + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
