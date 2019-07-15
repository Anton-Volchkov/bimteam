using bimteam.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bimteam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        Logic.View _view;
        public Form4(Logic.View view)
        {
            InitializeComponent();
            _view = view;

            BatFiles = _view.BatFiles;
        }

        public List<ViewBatFile> BatFiles = new List<ViewBatFile>();

        private (string, string) GetPath()
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                return (openFileDialog1.FileName, openFileDialog1.SafeFileName);
            }

            return ("", "");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox1.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label1.Text,
                FileName = Path.Item2
            });
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox2.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label2.Text,
                FileName = Path.Item2
            });
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox3.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label3.Text,
                FileName = Path.Item2
            });
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox6.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label6.Text,
                FileName = Path.Item2
            });
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox5.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label5.Text,
                FileName = Path.Item2
            });
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox4.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label4.Text,
                FileName = Path.Item2
            });
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox9.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label9.Text,
                FileName = Path.Item2
            });
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox8.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label8.Text,
                FileName = Path.Item2
            });
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            var Path = GetPath();
            listBox7.Items.Add(Path.Item2);

            BatFiles.Add(new ViewBatFile
            {
                Path = Path.Item1,
                Seccion = label7.Text,
                FileName = Path.Item2
            });
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                BatFiles.Remove(BatFiles.First(x => x.FileName == listBox1.SelectedItem.ToString()));
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox2.SelectedItem.ToString()));
            listBox2.Items.Remove(listBox2.SelectedItem);
               
            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox3.SelectedItem.ToString()));
            listBox3.Items.Remove(listBox3.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox6.SelectedItem.ToString()));
            listBox6.Items.Remove(listBox6.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox5.SelectedItem.ToString()));
            listBox5.Items.Remove(listBox5.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox4.SelectedItem.ToString()));
            listBox4.Items.Remove(listBox4.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox9.SelectedItem.ToString()));
            listBox9.Items.Remove(listBox9.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox8.SelectedItem.ToString()));
            listBox8.Items.Remove(listBox8.SelectedItem);

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
            BatFiles.Remove(BatFiles.First(x => x.FileName == listBox7.SelectedItem.ToString()));
            listBox7.Items.Remove(listBox7.SelectedItem);        

            }
            catch (Exception)
            {
                MessageBox.Show("Не выбран никакой параметр.");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            var v = _view.BatFiles.Where(x => x.Seccion == "Архитектура");

            foreach (var item in v)
            {
                listBox1.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "Конструктив");

            foreach (var item in v)
            {
                listBox2.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "Вентиляция");

            foreach (var item in v)
            {
                listBox3.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "Отопление");

            foreach (var item in v)
            {
                listBox6.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "ИТП");

            foreach (var item in v)
            {
                listBox5.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "ВК");

            foreach (var item in v)
            {
                listBox4.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "АТП");

            foreach (var item in v)
            {
                listBox9.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "СС");

            foreach (var item in v)
            {
                listBox8.Items.Add(item.FileName);
            }

            v = _view.BatFiles.Where(x => x.Seccion == "ЭОМ");

            foreach (var item in v)
            {
                listBox7.Items.Add(item.FileName);
            }
        }
    }
}
