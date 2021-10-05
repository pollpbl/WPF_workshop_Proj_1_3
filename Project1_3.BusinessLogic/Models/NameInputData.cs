using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_3.BusinessLogic.Models
{
    public class NameInputData
    {
      public NameInputData(string defaultName)
      {
          DefaultName = defaultName;
      }

      public string DefaultName { get; }
    }
}
