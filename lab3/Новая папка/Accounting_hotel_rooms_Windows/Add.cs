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
    public partial class Add : Form
    {
        public Check_in Editing { get; set; }

        public Add()
        {
            InitializeComponent();
            Box_phone.Enabled = false;
            Box_email.Enabled = false;
        }

        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type.SelectedIndex == 0)
            {
                Box_phone.Enabled = false;
                Box_email.Enabled = true;
            }
            else
            {
                Box_phone.Enabled = true;
                Box_email.Enabled = false;
            }

        }


        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Box_name_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Box_name.SelectionStart = Box_name.MaskedTextProvider.LastAssignedPosition + 1;
            Box_name.SelectionLength = 0;
        }
        private void Box_familya_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Box_familya.SelectionStart = Box_familya.MaskedTextProvider.LastAssignedPosition + 1;
            Box_familya.SelectionLength = 0;
        }
        private void maskedphone_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            maskedphone.SelectionStart = maskedphone.MaskedTextProvider.LastAssignedPosition + 1;
            maskedphone.SelectionLength = 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Type.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите тип регистрации");
                return;
            }

            Check_in check;

            if (Type.SelectedIndex == 0)
            {
                check = new OnlineBooking();
                ((OnlineBooking)check).email = maskedemail.Text;
                //if (maskedemail.Text.Length < 5 || maskedemail.Text.Length > 20)
                //{
                //    MessageBox.Show("Email веден не верно!");
                //    return;
                //}
            }

            else
            {
                check = new TelephoneBooking();
                ((TelephoneBooking)check).phone = maskedphone.Text;
                //if (maskedphone.Text.Length < 15 || maskedphone.Text.Length > 15)
                //{
                //    MessageBox.Show("Номер веден не верно!");
                //    return;
                //}
            }
            

            //if (Box_name.Text.Length < 1)
            //{
            //    MessageBox.Show("Имя отсутствует!");
            //    return;
            //}

            //if (Box_familya.Text.Length < 1)
            //{
            //    MessageBox.Show("Фамилия отсутствует!");
            //    return;
            //}

            //if (Type_nomer.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Выберите тип номера");
            //    return;
            //}

       
            check.id = Editing != null ? Editing.id : null;
            check.email = maskedemail.Text;
            check.phone = maskedphone.Text;
            //check.ime.name = Box_name.Text;
            //check.ime.famil = Box_familya.Text;
            //check.nome.room_Number = Type_nomer.SelectedIndex + 1;
            //check.nome.date = dateTimePicker1.ToString();
            check.room_Number = Type_nomer.SelectedIndex + 1;
            check.name = Box_name.Text;
            check.famil = Box_familya.Text;
            check.date =  this.dateTimePicker1.Value.Date;

            if (Type_nomer.SelectedIndex == +0)
            {
                check.price_Number = 1000;
            }
            else if (Type_nomer.SelectedIndex == +1)
            {
                check.price_Number = 1200;
            }
            else if (Type_nomer.SelectedIndex == +2)
            {
                check.price_Number = 1600;
            }
            else if (Type_nomer.SelectedIndex == +3)
            {
                check.price_Number = 2500;
            }
            

            try
            {
                Program.Studio.Save(check);
                Close();
            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


   

        private void Label3_Click(object sender, EventArgs e) {/* выберите тип регистрции */}
        private void Label1_Click(object sender, EventArgs e) {/* введите номер */ }
        private void Label2_Click(object sender, EventArgs e) {/* введите email */}
        private void Label6_Click(object sender, EventArgs e) {/* введите имя */}
        private void Label7_Click(object sender, EventArgs e) {/* введите фамилию*/}
        private void Label4_Click(object sender, EventArgs e) {/*выберите номер*/ }
        private void Label5_Click(object sender, EventArgs e) {/*выберите дату заселения*/}
        private void Maskedemail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) { }
        private void Add_Load(object sender, EventArgs e) { }
        private void Type_nomer_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
    }
}

