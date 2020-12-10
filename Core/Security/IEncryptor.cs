using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security
{
    public interface IEncryptor
    {
        string encrypt(string input);
    }
}
