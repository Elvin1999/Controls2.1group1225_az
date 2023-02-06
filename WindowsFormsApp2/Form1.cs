using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.SpringGreen;
            richTextBox1.SelectionColor = Color.Yellow;
            richTextBox1.SelectionFont = new Font("Comic Sans MS", 32, FontStyle.Bold | FontStyle.Italic);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = dateTimePicker1.Value.ToString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            richTextBox1.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {

                if (cb.Checked)
                {
                    cb.BackColor = Color.SpringGreen;
                }
                else
                {
                    cb.BackColor = Color.Red;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton radioButton)
            {
                if (radioButton.Checked)
                {
                    radioButton.Text += " Selected";
                }
                else
                {
                    if(radioButton.Text.Split(' ').Length == 2)
                    {
                        radioButton.Text = radioButton.Text.Split(' ')[0];
                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is RadioButton radioButton)
            {
                var count = groupBox1.Controls.Count;
                var lastControl = groupBox1.Controls[count-1];
                if(lastControl is RadioButton rb)
                {
                    var x = rb.Location.X;
                    var y = rb.Location.Y;
                    radioButton.Location= new Point(x, y+40);
                    groupBox1.Controls.Add(radioButton);

                } 
               // radioButton.Dispose();
            }
        }
    }
}
