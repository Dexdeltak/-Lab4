﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2.Forms
{
    public partial class tbutton : Form
    {
        public tbutton()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FreightDeliveryHoldForPickup newDelivery = new FreightDeliveryHoldForPickup(
               IDGenerator.GenerateRandomId(16),
               DateTime.Now,
               double.Parse(textBox2.Text),
               decimal.Parse(textBox3.Text),
               textBox4.Text,
               textBox5.Text,
               checkBox1.Checked,
               textBox6.Text,
               textBox7.Text,
               checkBox2.Checked,
               false
            );

            ClientCardSingleton.Instance.onMessage += ClientCardSingleton.Instance.EventHandlerSuccess;
            var result = ClientCardSingleton.Instance.SendPackage(newDelivery);
            PostalCompany.Instance.WriteLogToFile(newDelivery);
        }
    }
}
