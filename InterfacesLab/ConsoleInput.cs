using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLab
{
    public class ConsoleInput : IInput
    {
        //TODO: Modify ConsoleInput class so that it implements IInput
        //Read the IInput interface comments carefully to understand what each method should accomplish.

        public string GetCommand()
        {
            return Console.ReadLine();
        }

        public string GetCommand(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public string GetCommand(string prompt, string[] allowableValues)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            foreach (string item in allowableValues)
            {
                if (item == input)
                {
                    return input;
                }
            }
            return "";
        }

        public int GetInteger()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToInt32(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int GetInteger(int lowerBound, int upperBound)
        {
            int intInput;
            while (true)
            {
                string stringInput = Console.ReadLine();
                try
                {
                    intInput = Convert.ToInt32(stringInput);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (intInput >= lowerBound && intInput <= upperBound)
            {
                return intInput;
            }
            else
            {
                return -1;
            }
        }

        public double GetDouble()
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    return Convert.ToDouble(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public double GetDouble(double lowerBound, double upperBound)
        {
            double doubleInput;
            while (true)
            {
                string stringInput = Console.ReadLine();
                try
                {
                    doubleInput = Convert.ToDouble(stringInput);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            if (doubleInput >= lowerBound && doubleInput <= upperBound)
            {
                return doubleInput;
            }
            else
            {
                return -1;
            }
        }
    }
}
