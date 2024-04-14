using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab05Lib
{
    public class DecMD5 : Decorator
    {
        public DecMD5(IWriter writer) : base(writer) { }

        public override string Save(string message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            using(MD5 md5 = MD5.Create())
            {
                return base.Save($"{message}{Constant.Delimiter}{Convert.ToBase64String(md5.ComputeHash(data))}");
            }

        }
    }
}
