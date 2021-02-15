using Project1_3.BusinessLogic.Models;
using Project1_3.BusinessLogic.ViewModels.Base;
using Project1_3.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project1_3.BusinessLogic.ViewModels.Name
{
    public class NameWindowViewModel : BaseViewModel
    {
        private readonly INameWindowAccess access;
        private string name;

        private void DoOk()
        {
            access.Close(true);
        }

        private void DoCancel()
        {
            access.Close(false);
        }

        public NameWindowViewModel(INameWindowAccess access, NameInputData input)
        {
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            this.access = access ?? throw new ArgumentNullException(nameof(access));

            name = input.DefaultName;

            OkCommand = new AppCommand(obj => DoOk());
            CancelCommand = new AppCommand(obj => DoCancel());
        }

        public string Name
        {
            get => name;
            set => Set(ref name, value);
        }

        public NameOutputData Result => new NameOutputData(name);

        public ICommand OkCommand { get; }
        public ICommand CancelCommand { get; }
    }
}
