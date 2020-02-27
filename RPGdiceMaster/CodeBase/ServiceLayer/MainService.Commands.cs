using RPGdiceMaster.CodeBase.ServiceLayer.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGdiceMaster.CodeBase.ServiceLayer
{
    public static partial class MainService
    {
        #region handleCommand
        public static void handleCommand(ICommand command)
        {
            try
            {
                command.Execute();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
        #endregion
    }
}
