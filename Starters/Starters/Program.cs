using System;

namespace Starters
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Calculator calc = new Calculator.Calculator();

        }
    }
}

namespace Calculator
{ 
    class Calculator
    {
        protected int size;
        protected float[] mathInputs;
        protected int[] action;

        protected float answer = 0;

        public Calculator()
        {
            UserInput();
            ArraySizer();
            UserInterface();
            Calculation();
            ShowCalculation();
        }

        private void UserInput()
        {
            Console.WriteLine("How many numbers are going to be inputted?: ");
            size = int.Parse(Console.ReadLine());
        }

        private void ArraySizer()
        {
            mathInputs = new float[size];
            action = new int[size - 1];
        }

        private void UserInterface()
        {
            for(int i = 0; i < size; i++)
            {
                Console.Clear();
                Console.Write("Value " + i + ": ");
                mathInputs[i] = float.Parse(Console.ReadLine());

                if(i + 1 != size)
                {
                    Console.Write("\n0: Add | 1: Subtract | 2: Divide | 3: Multiply\n\nYour Input: ");

                    action[i] = int.Parse(Console.ReadLine());
                }
            }
        }

        private void Calculation()
        {
            for(int i = 0; i < size-1; i++)
            {
                if(action[i] == 0) answer += mathInputs[i] + mathInputs[i + 1];
                if(action[i] == 1) answer += mathInputs[i] - mathInputs[i + 1];
                if(action[i] == 2) answer += mathInputs[i] / mathInputs[i + 1];
                if (action[i] == 3) answer += mathInputs[i] * mathInputs[i + 1];
            }
        }

        private void ShowCalculation()
        {
            Console.Clear();
            Console.WriteLine("Your answer: " + answer);
        }
    }
}
