using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mat1 = new Matrix<string>(2, 3);

            mat1[0, 0] = "1,1x";
            mat1[0, 1] = "1,2x";
            mat1[1, 0] = "2,1x";
            mat1[1, 1] = "2,2x";
            mat1[0, 2] = "1,3x";
            mat1[1, 2] = "2,3x";

            Console.WriteLine(mat1.Display());

            var mat2 = new Matrix<double>(2, 1);
            mat2[0, 0] = 1;
            mat2[1, 0] = 2;
            var mat3 = new Matrix<double>(1, 3);
            mat3[0, 0] = 3;
            mat3[0, 1] = 4;
            mat3[0, 2] = 5;
            var mult = mat2 * mat3;
            Console.WriteLine(mult.Display());

            var mat4 = new Matrix<double>(2, 1);
            mat4[0, 0] = 3;
            mat4[1, 0] = 5;
            var mat5 = new Matrix<double>(2, 1);
            mat5[0, 0] = 1;
            mat5[1, 0] = 2;
            var add = mat4 + mat5;
            Console.WriteLine(add.Display());

            var sub = mat4 - mat5;
            Console.WriteLine(sub.Display());

            if (mat5)
            {
                Console.WriteLine("true");
            }

            var mat6 = new Matrix<object>(2, 1);
            if (mat6)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            DisplayInReversed("ab-cd");
            DisplayInReversed("a-bC-dEf-ghIj");
            DisplayInReversed("");
            DisplayInReversed("Test1ng-Leet=code-Q!");
            DisplayInReversed(";.A");
        }

        static void DisplayInReversed(string str)
        {
            Console.WriteLine($"{str} reversed is {SpecialReversed(str)}");
        }

        private static string SpecialReversed(string str)
        {
            var result = str.ToCharArray();
            var indexEnd = result.Length - 1;
            var indexStart = 0;

            while (indexStart < indexEnd)
            {
                if (!char.IsLetter(result[indexStart]))
                    indexStart++;
                else if (!char.IsLetter(result[indexEnd]))
                    indexEnd--;

                else
                {
                    char tmp = result[indexStart];
                    result[indexStart] = result[indexEnd];
                    result[indexEnd] = tmp;
                    indexStart++;
                    indexEnd--;
                }
            }
            return String.Join("", result);
        }
    }
}
