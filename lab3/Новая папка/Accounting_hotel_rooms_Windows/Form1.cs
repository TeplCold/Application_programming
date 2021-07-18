using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting_hotel_rooms;

namespace Accounting_hotel_rooms_Windows
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            RefreshTable();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var add = new Add();
            add.ShowDialog();
            RefreshTable();
        }

        public void RefreshTable()
        { 
            Tableaddreport.Controls.Clear();
            Tableaddreport.RowStyles.Clear();
            
            var checks = Program.Studio.GetList();
            Tableaddreport.RowCount = checks.Count;
            
            
            for (var i = 0; i < checks.Count; i++)
            {
                var check = checks[i];
     
                var idLabel = new Label();
                idLabel.Text = "id:" + " " + check.id.ToString();
                idLabel.Width = 45;
                Tableaddreport.Controls.Add(idLabel, 0, i);

                var data = new Label();
                //data = checks.nome.date;
                data.Text = "Дата заезда:" + " " + check.date.ToString("d MMMM yyyy");
                data.Width = 235;
                Tableaddreport.Controls.Add(data, 1, i);


                var nomeLabel = new Label();
                //nomeLabel.Text = checks.nome.room_Number.ToString();
                nomeLabel.Text = "№_номера:" + " " + check.room_Number.ToString();
                nomeLabel.Width = 100;
                Tableaddreport.Controls.Add(nomeLabel, 2, i);
             
                var nomes = new Label();
                //nomes.Text = " " + checks.nome.price_Number + "р".ToString();
                nomes.Text = "+" + check.price_Number + "р".ToString();
                nomes.Width = 70;
                Tableaddreport.Controls.Add(nomes, 3, i);


                var e_m = new Label();
                e_m.Text = check is OnlineBooking? "Email:" + " " + check.email : "Телефон:" + " " + check.phone;
                e_m.Width = 220;
                Tableaddreport.Controls.Add(e_m, 4, i);

                var nameLabel = new Label();
               // nameLabel.Text = checks.ime.name.ToString();
                nameLabel.Text = "Имя:" + " " + check.name.ToString();
                nameLabel.Width = 150;
                Tableaddreport.Controls.Add(nameLabel, 5, i);

                var famLabel = new Label();
                // nameLabel.Text = checks.ime.famil.ToString();
                famLabel.Text = "Фамилия:" + " " + check.famil.ToString();
                famLabel.Width = 240;
                Tableaddreport.Controls.Add(famLabel, 6, i);


                ///---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
              
                var izmButton = new Button();
                izmButton.Text = "Изменить";
                izmButton.Click += (object sender, EventArgs e) =>
                {
                    var add = new Add();
                    add.Editing = check;
                    add.ShowDialog(); //показать 
                    RefreshTable();   // обновить таблицу
                }; 

                Tableaddreport.Controls.Add(izmButton, 7, i);
                izmButton.Width = 90;
                izmButton.Height = 27;
                
                ///---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ---------------------------------------- ----------------------------------------
                var deleteButton = new Button();
                deleteButton.Text = "Удалить";

                deleteButton.Click += (object sender, EventArgs e) =>
                {
                    var button = MessageBox.Show("Вы уверены что хотите удалить?", "Подтверждение", MessageBoxButtons.YesNo);
                    if (button == DialogResult.Yes)
                    {
                        Program.Studio.Delete(check.id.Value);
                        RefreshTable();
                    }
                };

                deleteButton.Width = 90;
                deleteButton.Height = 27;
                Tableaddreport.Controls.Add(deleteButton, 8, i);

                Tableaddreport.RowStyles.Add(new RowStyle()
                {
                    SizeType = SizeType.AutoSize
                }
                );
            }
        }
        
        
        ///отчет
        private void To_form_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.ShowDialog();
        }
        

        ///кнопка выход
        private void OutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void MenuToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
        private void Tableaddreport_Paint(object sender, PaintEventArgs e) { }
    }
}
