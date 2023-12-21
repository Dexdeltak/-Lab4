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
    public partial class FormCreateCard : Form
    {
        public FormCreateCard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientCard newClient = new ClientCard(
                IDGenerator.GenerateRandomId(16),
                textBox1.Text,
                textBox2.Text,
                textBox3.Text
            );

            PostalCompany.Instance.AddClientCard(newClient);

            MessageBox.Show($"Successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
