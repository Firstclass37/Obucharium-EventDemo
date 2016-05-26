using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ivan",12);
            person.OnChangeName += Show;
            person.Name = "Nikolay";
        }


        public static void Show(object sender, ChangeNameEventArg e)
        {
            Console.WriteLine( "name was changed from {0} to {1}",e.OldName,e.NewName);
        }
    }
}
