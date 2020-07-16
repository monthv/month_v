using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class News
    {
        private string txUser;
        private string txPwd;

        public string TxUser
        {
            get
            {
                return txUser;
            }

            set
            {
                txUser = value;
            }
        }

        public string TxPwd
        {
            get
            {
                return txPwd;
            }

            set
            {
                txPwd = value;
            }
        }
    }
}
