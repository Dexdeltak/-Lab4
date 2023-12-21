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
    public partial class FormCreateClient : Form
    {
        public FormCreateClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientCompany newClient = new ClientCompany(
                IDGenerator.GenerateRandomId(16),
                textBox1.Text,
                textBox2.Text
            );
            PostalCompany.Instance.onMessage += PostalCompany.Instance.EventHandlerExistsClient;
            PostalCompany.Instance.AddCompanyClient(newClient);
            //MessageBox.Show($"Successfully created", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
