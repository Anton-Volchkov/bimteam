using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bimteam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private  void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Timer1_Tick(object sender, EventArgs e)
        {
          
                timer1.Enabled = false;

            xuiObjectAnimator1.ColorAnimate(this, Color.DodgerBlue, XanderUI.XUIObjectAnimator.ColorAnimation.StripeFill, true, 1);

            label1.Visible = true;
            xuiObjectAnimator1.StandardAnimate(label1, XanderUI.XUIObjectAnimator.StandardAnimation.SlideLeft, 1);

            label2.Visible = true;
            xuiObjectAnimator1.StandardAnimate(label2, XanderUI.XUIObjectAnimator.StandardAnimation.SlideRight, 1);

            pictureBox1.Visible = true;
            xuiObjectAnimator1.StandardAnimate(pictureBox1, XanderUI.XUIObjectAnimator.StandardAnimation.SlideLeft, 1);

            Thread.Sleep(1200);
            xuiObjectAnimator1.FormAnimate(this, XanderUI.XUIObjectAnimator.FormAnimation.FadeOut, 1);

            Form2 fr2 = new Form2();
                fr2.Show();

                this.Hide();

        }

        private void EventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
    }
}
