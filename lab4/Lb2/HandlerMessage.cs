using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb2
{
    public class HandlerMessage : EventArgs
    {
        readonly string Message;

        public HandlerMessage(string message)
        {
            Message = message;
        }

        public void MessageView()
        {
            Console.WriteLine(Message);
            MessageBox.Show(Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
