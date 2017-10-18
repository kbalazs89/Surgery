using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surgery.dal
{
    public class PatientDbModel
    {
        public string Name { get; set; }
        public string BirthPlace { get; set; }
        public string BirthDate { get; set; }
        public int TAJ { get; set; }
        public string BNO { get; set; }
        public string Comment { get; set; }
    }
}
