using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Model
{
    public class appLogin
    {
        private bool r;
        private int code;
        private string message;

        public appLogin()
        {
        }

        public appLogin(bool r, int code, string message)
        {
            this.R = r;
            this.Code = code;
            this.Message = message;
        }

        public bool R { get => r; set => r = value; }
        public int Code { get => code; set => code = value; }
        public string Message { get => message; set => message = value; }
    }
}
