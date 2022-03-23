using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Coiffure
{
    public class Appsetting
    {
        Configuration conf;
        public Appsetting()
        {
        }
        public string GetConnectionString(string key)
        {
            return "scf";
        }
    }
}
