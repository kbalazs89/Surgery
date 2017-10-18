using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surgery
{
    public class TreatmentFormViewModel : BaseModel
    {
        public Patient Patient { get; set; }
        public TreatmentFormViewModel(Patient patient)
        {
            Patient = patient;
        }
    }
}
