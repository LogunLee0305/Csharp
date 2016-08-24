using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caesar
{
    public partial class Form1 : Form
    {
        string input;
        int shiftnum;
        string output = "";
         
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            input = this.textBox1.Text;
            shiftnum = (Convert.ToInt32(this.num.Value));
            output = caesarinto(input, shiftnum);
            this.textBox2.Text = output;

            output = "";
            this.textBox1.Text = "";
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            input = this.textBox2.Text;
            shiftnum = (Convert.ToInt32(this.num.Value));
            output = caesarout(input, shiftnum);
            this.textBox1.Text = output;

            output = "";
            this.textBox2.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string caesarinto(string value, int shift)
         {
            char[] buffer = value.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                

                if(char.IsUpper(letter))
                {
                    letter = (char)(letter + shift);
                    if (letter > 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'A')
                    {
                        letter = (char)(letter + 26);
                    }
                }

                else if(char.IsLower(letter))
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                }
        

                buffer[i] = letter;
            }     
             return new string(buffer); 
         }

        private void clear()
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private string caesarout(string value, int shift)
        {
            char[] buffer = value.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if(char.IsUpper(letter))
                {
                    letter = (char)(letter - shift);

                    if(letter > 'Z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'A')
                    {
                        letter = (char)(letter + 26);
                    }
                }

                else if (char.IsLower(letter))
                {
                    letter = (char)(letter - shift);
                    if(letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                }

                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
}
