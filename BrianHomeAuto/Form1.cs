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
        Timer timer = new Timer();
        SpeechSynthesizer s = new SpeechSynthesizer();
        Boolean wake = false;
        Choices list = new Choices();
        public Form1()
        {
            SpeechRecognitionEngine rec = new SpeechRecognitionEngine();
            list.Add(new String[] {"wake", "sleep", "exit", "hello", "how are you", "time", "date", "open google", "restart", "update", "open word", "close word", "weather", "open youtube"});

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

        public void say(String h)
        {
            s.Speak(h);
            outputTextbox.AppendText(h + "\n");
        }

        private void rec_SpeachRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            String r = e.Result.Text;

            //Awake or sleeping (Change the lable to "Awake or Sleeping")
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
                //Restart, update or exit the program *FUTURE: AUTO UPDATE WILL BE ADDED LATER*
                if (r == "restart" || r == "update")
                {
                    AppComm.restart();
                }

                if (r == "exit")
                {
                    AppComm.exit();
                }

                //Basic commands and conversations
                if (r == "hello")
                {
                    say("Hello sir");
                }

                if (r == "how are you")
                {
                    say("I'm good, and you?");
                }

                // Time, Date, Weather
                if (r == "time")
                {
                    say(DateTime.Now.ToString("h:mm"));
                }

                if (r == "date")
                {
                    say(DateTime.Now.ToString("M/d/yyyy"));
                }

                if (r == "weather")
                {
                    say("The sky is, " + Weather._weather("cond") + "while" + "the temp is, " + Weather._weather("temp") + ".");
                }

                // Open and close (Word)
                if (r == "open word")
                {
                    OpenPrograms.word();
                    say("opening word");
                }

                if(r== "close word")
                {
                    ClosePrograms._CloseProgram("WINWORD");
                    say("Word is closed");
                }

                // Open websites
                if (r == "open google")
                {
                    Process.Start("http://google.com");
                    say("Opening google");
                }

                if (r == "open youtube")
                {
                    Process.Start("http://youtube.com");
                    say("Opening youtube");
                }
            }
            inputTextbox.AppendText(r + "\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
