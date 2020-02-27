using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGdiceMaster.CodeBase.ServiceLayer.Commands
{
    public interface ICommand
    {
        void Execute();
    }
}
