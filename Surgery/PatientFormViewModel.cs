using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surgery.dal;

namespace Surgery
{
    public class PatientFormViewModel:BaseModel
    {
        public Patient Patient { get; set; }
        public bool IsNew { get; set; }

        Patient patient;
        public PatientFormViewModel(Patient Patient)
        {
            this.Patient = Patient;
            if (!IsNew)
                Save();
        }

        public bool PatientValidate()
        {
            return !string.IsNullOrEmpty(Patient.Name) && Patient.Name.Length > 3;
        }

        public void Save()
        {
            if (!IsNew)
                patient = new Patient { Name = Patient.Name, BirthPlace = Patient.BirthPlace, BirthDate = Patient.BirthDate, TAJ = Patient.TAJ};
        }

        public void OriginalValue()
        {
            Patient.Name = patient.Name;
            Patient.BirthPlace = patient.BirthPlace;
            Patient.BirthDate = patient.BirthDate;
            Patient.TAJ = patient.TAJ;
        }

    }
}
