using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloServer
{
    public interface IDBAccess
    {
        string GetNameID(int id); 
    }
}
