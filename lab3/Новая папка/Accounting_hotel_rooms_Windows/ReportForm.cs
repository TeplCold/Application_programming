using Accounting_hotel_rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Accounting_hotel_rooms_Windows
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }


        private List<ReportItem> Generate()
        {
            if (Type.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип отчета");
            }

            else if (Type.SelectedIndex == +0)
            {
                return Program.Studio.Report(null);
            }

            else if (Type.SelectedIndex == +1)
            {
                DateTime dataRep = this.dateTimePicker2.Value.Date;
                return Program.Studio.Report(dataRep);
            }

            return null;
        }






        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Generate();
        }
     
        private void savebutton_Click(object sender, EventArgs e)
        {
            var res = saveFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                var report = Generate();
                using (var stream = new FileStream(saveFileDialog1.FileName, FileMode.CreateNew))
                using (var writer = new StreamWriter(stream))
                {
                    foreach (var r in report)
                    {
                        writer.WriteLine(r.DisplayingValue);
                    }
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void ReportForm_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
           
        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) { }

        private void Type_nomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type.SelectedIndex == +0)
            {
                groupBox3.Enabled = false;
            }
            else if (Type.SelectedIndex == +1)
            {
                groupBox3.Enabled = true;
            }
            else if (Type.SelectedIndex == -1)
            {
                groupBox3.Enabled =false;
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
