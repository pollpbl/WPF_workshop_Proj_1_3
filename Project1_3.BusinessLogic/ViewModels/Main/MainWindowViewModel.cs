using Project1_3.BusinessLogic.Models;
using Project1_3.BusinessLogic.Services.Dialog;
using Project1_3.BusinessLogic.Services.Messaging;
using Project1_3.BusinessLogic.ViewModels.Base;
using Project1_3.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project1_3.BusinessLogic.ViewModels.Main
{
    public class MainWindowViewModel : BaseViewModel
    {
        // Private fields -----------------------------------------------------

        private readonly IMainWindowAccess access;
        private readonly IDialogService dialogService;
        private readonly IMessagingService messagingService;

        private string data;

        // Private methods ----------------------------------------------------

        private void DoHello()
        {
            var defaultName = new NameInputData("World");
            
            (bool result, NameOutputData name) = dialogService.GetName(defaultName);
            if (result)
            {
                messagingService.Inform($"Hello, {name.Name}!");
            }
        }

        // Public methods -----------------------------------------------------

        public MainWindowViewModel(IMainWindowAccess access, IDialogService dialogService, IMessagingService messagingService)
        {
            this.access = access;
            this.dialogService = dialogService;
            this.messagingService = messagingService;

            HelloCommand = new AppCommand(obj => DoHello());
        }

        // Public properties --------------------------------------------------

        public ICommand HelloCommand { get; }
    }
}
