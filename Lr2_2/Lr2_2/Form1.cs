using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr2_2
{
    public partial class Form1 : Form
    {
        delegate void Del(object sender, EventArgs e);
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity <1f)
            {
                this.Opacity = 1f;
            }
            else
            {
                this.Opacity = 0.5f;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.WhiteSmoke)
            { this.BackColor = Color.Yellow; }
            else { this.BackColor = Color.WhiteSmoke; }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello World");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\nі цього мене не позбавиш!");
            Del[] but = new Del[] { Button1_Click, Button2_Click, Button3_Click };
            if (checkBox1.Checked == true)
            {
                but[0](sender, e);
            }
            if (checkBox2.Checked == true)
            {
                but[1](sender, e);
            }
            if (checkBox3.Checked == true)
            {
                but[2](sender, e);
            }
        }
    }
}
