using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Lab05Lib
{
    public class DecSHA512 : Decorator
    {
        public DecSHA512(IWriter writer) : base(writer) { }

        public override string Save(string message)
        {
            var data = Encoding.UTF8.GetBytes(message);
            using (SHA512 hash = SHA512.Create())
            {
                return base.Save($"{message}{Constant.Delimiter}{Convert.ToBase64String(hash.ComputeHash(data))}");
            }
        }
    }
}
