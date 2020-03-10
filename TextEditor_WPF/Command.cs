using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextEditor_WPF
{
    public abstract class Command
    {
        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void UnExecute()
        {
            throw new System.NotImplementedException();
        }
    }
}