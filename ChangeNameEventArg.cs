using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class ChangeNameEventArg:EventArgs
    {
        public string OldName { get; private set; }
        public string NewName { get; private set; }

        public ChangeNameEventArg(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }
    }
}
