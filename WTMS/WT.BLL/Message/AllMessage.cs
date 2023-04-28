using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.BLL.Message
{
    public static class AllMessage
    {
        public static string FailedLogin = "İstifadəçi adı və password yalnışdır !";
        public static string ConfirmPassword = "Zəhmət olmasa parolunuzu təsdiq edin !";
        public static string AccountBlock = "Hesabınız bloklanıb\n Zəhmət olmasa sonra cəhd edin !";

        public static string NullObjMessage(string objName)
        {
            string message = $"{objName} siyahınız boşdur";
            return message;
        }
    }
}
