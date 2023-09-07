using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackStatic
{
    internal class StackExample
    {
        private int maxSize; // Tamaño máximo de la pila
        private int top;     // Índice del elemento superior
        private int[] stack; // Arreglo para almacenar elementos

        public StackExample(int size)
        {
            maxSize = size;
            top = -1;
            stack = new int[maxSize];
        }

        public void Push(int item)
        {
            if (top < maxSize - 1)
            {
                stack[++top] = item;
            }
            else
            {
                Console.WriteLine("La pila está llena. No se puede agregar más elementos.");
            }
        }

        public int Pop()
        {
            if (top >= 0)
            {
                return stack[top--];
            }
            else
            {
                Console.WriteLine("La pila está vacía. No se puede sacar ningún elemento.");
                return -1; // Valor de retorno predeterminado para indicar un error
            }
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void DisplayStack()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Stack elements:");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
            else
            {
                Console.WriteLine("The stack is empty");
            }
        }
    }
}
