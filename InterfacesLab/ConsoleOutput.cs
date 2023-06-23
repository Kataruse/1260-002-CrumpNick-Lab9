using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    public class ConsoleOutput : IOutput
    {
        //TODO: Modify ConsoleOutput class so that it implements IOutput
        //Read the IOutput interface comments carefully to understand what each method should accomplish.

        public void Out(string output)
        {
            Console.Write(output);
        }

        public void OutNL(string output)
        {
            Console.WriteLine(output);
        }

        public void Divider()
        {
            Console.WriteLine("----------------------------------------------------------------------");
        }
    }
}
