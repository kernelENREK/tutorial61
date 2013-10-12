using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiCalculadora
{
    public class Operaciones
    {
        public int Sumar(int num1, int num2)
        {
            if (num1 >= int.MaxValue && num2 > 0)
                throw new ArgumentOutOfRangeException();

            if (num2 >= int.MaxValue && num1 > 0)
                throw new ArgumentOutOfRangeException();

            if (num2 == 33)
                Console.WriteLine(@"hacer algo");

            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
