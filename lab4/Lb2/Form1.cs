using Lb2.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listParcel.DataSource = ClientCardSingleton.Instance.GetUnfinishedOperations();
            listParcel.DisplayMember = "ToString";
            listParcel.ResetBindings();
        }

        private void deliveryCourierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sbutton form3 = new sbutton();
            form3.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void savingToDemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fbutton form2 = new fbutton();
            form2.Show();
        }

        private void savingToDemandToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbutton form3 = new tbutton();
            form3.Show();
        }

        private void courierAndLoadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foubutton form4 = new foubutton();
            form4.Show();
        }

        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            // Получаем выбранный элемент
            IDelivery selectedDelivery = (IDelivery)listParcel.SelectedItem;

            // Проверяем, был ли выбран элемент
            if (selectedDelivery != null)
            {
                ClientCardSingleton.Instance.ReceivePackage(selectedDelivery);
            }
        }

        private void buttonSeacrh_Click(object sender, EventArgs e)
        {

        }

        private void addNewCardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCreateCard fcd = new FormCreateCard();
            fcd.Show();
        }

        private void addClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateClient fcd = new FormCreateClient();
            fcd.Show();
        }

        private void deleteCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDeleteCard fdc = new FormDeleteCard();
            fdc.Show();
        }

        private void taxesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = "";
            var taxArray = PostalCompany.Instance.UpdateTaxArray();

            for (int i = 0; i < taxArray.Length; i++)
            {
                output += $"Month {i + 1}: {taxArray[i]}$ \n";
            }

            MessageBox.Show(output, "Taxes by month", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
