using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Surgery.dal;

namespace Surgery
{
    public class MainViewModel : BaseModel
    {
        public ObservableCollection<Patient> PatientList { get; set; }
        public Patient SelectedPatient { get; set; }

        public MainViewModel()
        {
            PatientList = new ObservableCollection<Patient>();
            var ctx = new Context();
            foreach (var product in ctx.Patients)
            {
                PatientList.Add(new Patient(product));
            }
        }
    }
}
