using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {

        private string toOpenPath;
        private string toSavePath;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    toOpenPath = openFileDialog.FileName;
                }
            }
            OutBox.Text = toOpenPath;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    toSavePath = openFileDialog.FileName;
                }
            }
            SaveBox.Text = toSavePath;
        }

        private void RunButton_Click_1(object sender, EventArgs e)
        {
            Conversion conv = new Conversion(toOpenPath);
            string textFromFile = conv.TextFromFile();
            WorkWithFile wwf = new WorkWithFile(textFromFile);
            DictHashTable dict = wwf.FindWordsOfN();
            var i = 250;
            foreach (Chain item in dict)
            {
                var temp = new ProgressBar();
                temp.Value = item.Value * 10;
                temp.Width = 350;
                temp.Height = 25;
                temp.Location = new Point(15, i);
                
                var label = new Label();
                label.Width = 200;
                label.Height = 25;
                label.Text = $"Name: '{item.Key}', Number: --{item.Value}";
                label.Location = new Point(385, i+3);

                Controls.Add(temp);
                Controls.Add(label);
                i += 30;
            }

            OutBox.Text = "Выполнено";
        }
    }
}
