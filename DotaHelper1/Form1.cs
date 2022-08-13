using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Search;
using System.Threading;

namespace DotaHelper1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isThreadWorks = false;
        private async void button1_Click(object sender, EventArgs e)
        {
            if(!isThreadWorks && comboBox1.SelectedItem?.ToString() != null && comboBox1.SelectedItem.ToString() != string.Empty)
            {
                var text = comboBox1.SelectedItem.ToString().ToLower().Replace(' ', '-');
                string t1 = string.Empty;
                string t2 = string.Empty;
                string t3 = string.Empty;
                button1.Visible = false;
                string[] result = await Task.Run(() =>
                {
                    isThreadWorks = true;
                    t1 = SDotabuff.getData(text, 0);
                    t2 = SDotabuff.getData(text, 1);
                    t3 = SDotabuff.getData(text, 2);
                    isThreadWorks = false;
                    return Task.FromResult(new string[] { t1, t2, t3 });
                });
                label2.Text = result[0];
                label3.Text = result[1];
                label4.Text = result[2];
                button1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }
        }
    }
}
