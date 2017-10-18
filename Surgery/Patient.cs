using Surgery.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surgery
{
    public class Patient : BaseModel
    {
        string _name;
        string _birthPlace;
        string _birthDate;
        int _taj;

        public string Name { get { return _name; } set { _name = value; OnPropertyChange(); } }
        public string BirthPlace { get { return _birthPlace; } set { _birthPlace = value; OnPropertyChange(); } }
        public string BirthDate { get { return _birthDate; } set { _birthDate = value; OnPropertyChange(); } }
        public int TAJ { get { return _taj; } set { _taj = value; OnPropertyChange(); } }


        public Patient(PatientDbModel dbModel)
        {
            Name = dbModel.Name;
            BirthPlace = dbModel.BirthPlace;
            BirthDate = dbModel.BirthDate;
            TAJ = dbModel.TAJ;
        }

        public Patient()
        {

        }
    }
}
