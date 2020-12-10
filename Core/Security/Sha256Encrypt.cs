using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security
{
    public class Sha256Encrypt : IEncryptor
    {
        public string encrypt(string input)
        {
            byte[] data = Encoding.ASCII.GetBytes(input);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = Encoding.ASCII.GetString(data);

            return hash;
        }
    }
}
