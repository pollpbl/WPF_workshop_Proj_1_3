using Project1_3.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_3.BusinessLogic.Services.Dialog
{
    public interface IDialogService
    {
        (bool, NameOutputData) GetName(NameInputData data);
    }
}
