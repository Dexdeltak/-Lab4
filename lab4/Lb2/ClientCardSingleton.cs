using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2
{
    public class ClientCardSingleton
    {
        private static ClientCard _instance;

        public static ClientCard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ClientCard("FZSCHXVNHLZ4Q8PH", "Jon Doe", "jon@gmail.com", "468504543323445");
                }
                return _instance;
            }
        }
    }
}
