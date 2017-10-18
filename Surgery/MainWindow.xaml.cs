using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Surgery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _vm;
        public MainWindow()
        {
            InitializeComponent();
            _vm = new MainViewModel();
            DataContext = _vm;
        }

        private void NewPatientClick(object sender, RoutedEventArgs e)
        {
            PatientFormViewModel viewModel = new PatientFormViewModel(new Patient()) { IsNew = true };
            PatientFormWindow patientForm = new PatientFormWindow { DataContext = viewModel };
            patientForm.ShowDialog();
            _vm.PatientList.Add(viewModel.Patient);
            


        }

        private void ModifyPatientClick(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectedPatient != null)
            {
                PatientFormViewModel viewModel = new PatientFormViewModel(_vm.SelectedPatient);
                PatientFormWindow productForm = new PatientFormWindow { DataContext = viewModel };
                productForm.ShowDialog();
            }
        }

        private void TreatmentClick(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectedPatient != null)
            {
                TreatmentFormViewModel trViewModel = new TreatmentFormViewModel(_vm.SelectedPatient);
                TreatmentFormWindow trForm = new TreatmentFormWindow();
                trForm.ShowDialog();
            }

        }
    }
}
