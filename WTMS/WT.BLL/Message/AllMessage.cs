using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WT.BLL.Message
{
    public static class AllMessage
    {
        public static string NullObjMessage(string objName)
        {
            string message = $"{objName} siyahınız boşdur";
            return message;
        }
    }
}
