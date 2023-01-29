using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ies_admin_academ.Controller
{
    public static class IES_TextEncoder
    {
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }


        private const string SEPARATOR = "!";
        public static string joinString(string cad1, String cad2)
        {
            string r = "";
            r += Base64Encode(cad1);
            r += SEPARATOR;
            r += Base64Encode(cad2);

            return r;
        }
    }
}
