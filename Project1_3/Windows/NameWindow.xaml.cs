using Project1_3.BusinessLogic.Models;
using Project1_3.BusinessLogic.ViewModels.Name;
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
using System.Windows.Shapes;
using Unity;
using Unity.Resolution;

namespace Project1_3.Windows
{
    /// <summary>
    /// Interaction logic for NameWindow.xaml
    /// </summary>
    public partial class NameWindow : Window, INameWindowAccess
    {
        private NameWindowViewModel viewModel;

        public NameWindow(NameInputData input)
        {
            InitializeComponent();

            viewModel = Dependencies.Container.Instance.Resolve<NameWindowViewModel>(new ParameterOverride("input", input),
                new ParameterOverride("access", this));

            DataContext = viewModel;
        }

        public NameOutputData Result => viewModel.Result;

        public void Close(bool result)
        {
            DialogResult = result;
            Close();
        }
    }
}
