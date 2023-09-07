using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StackExample pila = new StackExample(5);
            bool salir = true;

            while (salir)
            {
                Console.WriteLine("// Select an option" +
                    "\n[1]: Enter a value " +
                    "\n[2]: Delete a value" +
                    "\n[3]: Show stack" +
                    "\n[4]: Exit");

                int opcion;

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.Clear();
                    continue;
                }

                switch (opcion)
                {

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter a value:");
                        pila.Push(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Clear();
                        if (!pila.IsEmpty())
                        {
                            int elementoDesapilado = pila.Pop();
                            Console.Clear();
                            Console.WriteLine("// Element popped from the stack: " + elementoDesapilado);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("The stack is empty");
                        }

                        break;

                    case 3:
                        Console.Clear();
                        pila.DisplayStack();
                        break;

                    case 4:
                        salir = false;
                        Console.Clear();
                        Console.WriteLine("Good bye");
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
