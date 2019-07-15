using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bimteam.Logic;
namespace bimteam
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<Logic.View> views = new List<Logic.View>();
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
       
            Form3 fr3 = new Form3(1, views);
        
            fr3.ShowDialog();

            Form2_Load(this,null);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var binFormatter = new BinaryFormatter();

            using (var file = new FileStream("groups.bin", FileMode.OpenOrCreate))
            {
                try
                {
                    var newGroups = binFormatter.Deserialize(file) as List<Logic.View>;

                    if (newGroups != null)
                    {
                        views = newGroups;
                    }
                    else
                        MessageBox.Show("Ошибка!");
                }
                catch (Exception)
                {                
                }

                var first = views.FirstOrDefault(x => x.ID == 1);
                if (first != null)
                {
                    pictureBox1.Image = Image.FromFile((first.PhotoPath));
                    richTextBox1.Text = (views.FirstOrDefault(x => x.ID == 1).Text);

                }

                first = views.FirstOrDefault(x => x.ID == 2);
                if (first != null)
                {
                    pictureBox2.Image = Image.FromFile((first.PhotoPath));
                    richTextBox2.Text = (views.FirstOrDefault(x => x.ID == 2).Text);
                }
               
                first = views.FirstOrDefault(x => x.ID == 3);
                if (first != null)
                {
                    pictureBox3.Image = Image.FromFile((first.PhotoPath));
                    richTextBox3.Text = (views.FirstOrDefault(x => x.ID == 3).Text);

                }

                first = views.FirstOrDefault(x => x.ID == 4);
                if (first != null)
                {
                    pictureBox4.Image = Image.FromFile((first.PhotoPath));
                    richTextBox4.Text = (views.FirstOrDefault(x => x.ID == 4).Text);
                }
              
                first = views.FirstOrDefault(x => x.ID == 5);
                if (first != null)
                {
                    pictureBox5.Image = Image.FromFile((first.PhotoPath));
                    richTextBox5.Text = (views.FirstOrDefault(x => x.ID == 5).Text);

                }

                first = views.FirstOrDefault(x => x.ID == 6);
                if (first != null)
                {
                    pictureBox6.Image = Image.FromFile((first.PhotoPath));
                    richTextBox6.Text = (views.FirstOrDefault(x => x.ID == 6).Text);

                }

                first = views.FirstOrDefault(x => x.ID == 7);
                if (first != null)
                {
                    pictureBox7.Image = Image.FromFile((first.PhotoPath));
                    richTextBox7.Text = (views.FirstOrDefault(x => x.ID == 7).Text);
                }
       
            }

        }

        int FormCount = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            panel11.Visible = true;
            if (FormCount == 7)
            {
                MessageBox.Show("Максимальное колличество форм!");
                return;
            }
            ++FormCount;
            switch (FormCount)
            {
                case 1: panel1.Visible = true;
                    break;
                case 2: panel4.Visible = true;
                    break;
                case 3:
                    panel5.Visible = true;
                    break;
                case 4:
                    panel6.Visible = true;
                    break;
                case 5:
                    panel7.Visible = true;
                    break;
                case 6:
                    panel8.Visible = true;
                    break;
                case 7:
                    panel9.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (FormCount <= 1)
            {
                MessageBox.Show("Минимальное колличество форм!");
                return;
            }
            switch (FormCount)
            {
                case 1:
                    panel1.Visible = false;
                    break;
                case 2:
                    panel4.Visible = false;
                    break;
                case 3:
                    panel5.Visible = false;
                    break;
                case 4:
                    panel6.Visible = false;
                    break;
                case 5:
                    panel7.Visible = false;
                    break;
                case 6:
                    panel8.Visible = false;
                    break;
                case 7:
                    panel9.Visible = false;
                    break;
                default:
                    break;
            }
            --FormCount;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(2, views);

            fr3.ShowDialog();

            Form2_Load(this, null);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(3, views);

            fr3.ShowDialog();

            Form2_Load(this, null);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(4, views);

            fr3.ShowDialog();

            Form2_Load(this, null);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(5, views);

            fr3.ShowDialog();

            Form2_Load(this, null);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(6, views);

            fr3.ShowDialog();

            Form2_Load(this, null);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3(7, views);

            fr3.ShowDialog();

            Form2_Load(this,null);
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.BackColor = Color.LawnGreen;
        }

        private void Panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(192,255,192);
        }

        private void Panel4_MouseMove(object sender, MouseEventArgs e)
        {
            panel4.BackColor = Color.LawnGreen;
        }

        private void Panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void Panel5_MouseMove(object sender, MouseEventArgs e)
        {
            panel5.BackColor = Color.LawnGreen;
        }

        private void Panel5_MouseLeave(object sender, EventArgs e)
        {
            panel5.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void Panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void Panel6_MouseMove(object sender, MouseEventArgs e)
        {
            panel6.BackColor = Color.LawnGreen;
        }

        private void Panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void Panel7_MouseMove(object sender, MouseEventArgs e)
        {
            panel7.BackColor = Color.LawnGreen;
        }

        private void Panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void Panel8_MouseMove(object sender, MouseEventArgs e)
        {
            panel8.BackColor = Color.LawnGreen;
        }

        private void Panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void Panel9_MouseMove(object sender, MouseEventArgs e)
        {
            panel9.BackColor = Color.LawnGreen;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var v = views.FirstOrDefault(x => x.ID == 1);
            if (v == null)
            {
                MessageBox.Show("Данный объект не настроен! Настройте его перед просмотром.");
                return;
            }
            Form5 fr5 = new Form5(v);

            fr5.ShowDialog();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var v = views.FirstOrDefault(x => x.ID == 4);
            if (v == null)
            {
                MessageBox.Show("Данный объект не настроен! Настройте его перед просмотром.");
                return;
            }
            Form5 fr5 = new Form5(v);

            fr5.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var v = views.FirstOrDefault(x => x.ID == 2);
            if (v == null)
            {
                MessageBox.Show("Данный объект не настроен! Настройте его перед просмотром.");
                return;
            }
            Form5 fr5 = new Form5(v);

            fr5.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var v = views.FirstOrDefault(x => x.ID == 3);
            if (v == null)
            {
                MessageBox.Show("Данный объект не настроен! Настройте его перед просмотром.");
                return;
            }
            Form5 fr5 = new Form5(v);

            fr5.ShowDialog();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var v = views.FirstOrDefault(x => x.ID == 5);
            if (v == null)
            {
                MessageBox.Show("Данный объект не настроен! Настройте его перед просмотром.");
                return;
            }
            Form5 fr5 = new Form5(v);

            fr5.ShowDialog();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            var v = views.FirstOrDefault(x => x.ID == 6);
            if (v == null)
            {
                MessageBox.Show("Данный объект не настроен! Настройте его перед просмотром.");
                return;
            }
            Form5 fr5 = new Form5(v);

            fr5.ShowDialog();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            var v = views.FirstOrDefault(x => x.ID == 7);
            if (v == null)
            {
                MessageBox.Show("Данный объект не настроен! Настройте его перед просмотром.");
                return;
            }
            Form5 fr5 = new Form5(v);

            fr5.ShowDialog();
        }

        private void Button17_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
