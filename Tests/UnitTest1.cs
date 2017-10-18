using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Surgery;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Patient patient = new Patient()
        {
            Name = "F",
            BirthPlace ="Bp",
            BirthDate = "1989.05.21",
            TAJ=123456789
        };
        

        [TestMethod]
        public void Validate_Fail()
        {
            var patientFVM = new PatientFormViewModel(patient);
            Assert.IsFalse(patientFVM.PatientValidate());
        }

        [TestMethod]
        public void Validate_Pass()
        {
            patient.Name = "Feri";
            var patientFVM = new PatientFormViewModel(patient);
            Assert.IsTrue(patientFVM.PatientValidate());
        }

    }
}
