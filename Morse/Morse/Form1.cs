using System;

using System.Windows.Forms;
using System.Threading;

namespace Morse
{
    public partial class Form1 : Form
    {
        Thread myThread;

        private static readonly string[] Alphabet = { "A", "B", "C", "D" ,"E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        private static readonly string[] AlphabetMorse = {".-", "-...", "-.-.", "-..", ".","..-.", "--.", ".... ", "..", ".---","-.-", ".-..", "--", "-.", "---",".--.", "--.-", ".-.", "...", "-","..-", "...-", ".--", "-..-", "-.--","--.."};

        private static readonly string[] Number = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        private static readonly string[] NumberMores = {"-----", ".----","..---", "...--", "....-", ".....", "-....","--...", "---.."};


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
            myThread = new Thread(new ThreadStart(SpeakBeef));
            myThread.Start();
        }

        private void SpeakBeef()
        {
            int freq = 500;
            int dit = 200;
            int dah = 600;

            string encoded = "";
            if (textBox1.Text.Length > 0)
            {
                foreach (char ch in textBox1.Text.ToUpper())
                {
                    if (ch >= 'A' && ch <= 'Z')
                        encoded += (AlphabetMorse[ch - 'A']);

                    else if (ch >= '0' && ch <= '9')
                        encoded += (NumberMores[ch - '0']);

                    else if (ch == ' ')
                        encoded += '/';

                    encoded += ' ';
                }
            }

            foreach (char s in encoded)
            {
                if (s == '.')
                {
                    Console.Beep(freq, dit);
                    Thread.Sleep(dit);
                }
                else if (s == '-')
                {
                    Console.Beep(freq, dah);
                    Thread.Sleep(dit);
                }

                else if (s == ' ')
                {
                    Thread.Sleep(dit * 3);
                }

                else if (s == '/')
                {
                    Thread.Sleep(dit * 7);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            myThread.Abort();
        }
    }
}
