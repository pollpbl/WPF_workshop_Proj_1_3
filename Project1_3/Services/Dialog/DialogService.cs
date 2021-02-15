using Project1_3.BusinessLogic.Models;
using Project1_3.BusinessLogic.Services.Dialog;
using Project1_3.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_3.Services.Dialog
{
    class DialogService : IDialogService
    {
        public (bool, NameOutputData) GetName(NameInputData data)
        {
            var nameWindow = new NameWindow(data);
            if (nameWindow.ShowDialog() == true)
            {
                return (true, nameWindow.Result);
            }
            else
            {
                return (false, null);
            }
        }
    }
}
