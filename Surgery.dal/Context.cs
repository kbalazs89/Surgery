using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surgery.dal
{
    public class Context
    {
        public List<PatientDbModel> Patients { get; } = new List<PatientDbModel>
        {
            new PatientDbModel{Name="Kovacs Bela",BirthPlace="Budapest",BirthDate="1980.05.31.", TAJ=234567182}
        };
    }
}
