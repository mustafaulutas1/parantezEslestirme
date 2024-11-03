using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giriş yap:");
            string parantez = Console.ReadLine();

            if (ParantezKontrol(parantez))
            {
                Console.WriteLine("Doğru.");
            }
            else
            {
                Console.WriteLine("Yanlış.");
            }
            Console.ReadKey();
        }

        static bool ParantezKontrol(string parantez)
        {
            ArrayTypedStack stack = new ArrayTypedStack(parantez.Length);

            foreach (char character in parantez)
            {
                if (character == '(' || character == '{' || character == '[')
                {
                    stack.Push(character);
                }
                else if (character == ')' || character == '}' || character == ']')
                {
                    if (stack.IsEmpty())
                    {
                        return false; 
                    }

                    char son = (char)stack.Pop();
                    if (!Esle(son, character))
                    {
                        return false; 
                    }
                }
            }

            return stack.IsEmpty(); 
        }

        static bool Esle(char acılıs, char kapanıs)
        {
            return (acılıs == '(' && kapanıs == ')') ||
                   (acılıs == '{' && kapanıs == '}') ||
                   (acılıs == '[' && kapanıs == ']');
        }
    }
}
