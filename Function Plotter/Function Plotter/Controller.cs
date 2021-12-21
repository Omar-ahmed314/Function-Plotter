using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Function_Plotter
{
    internal class Controller
    {
        private static Controller controller = null;

        private Controller(){}
        public static Controller instantiate()
        {
            if(controller == null)
            {
                controller = new Controller();
            }
            return controller;
        }
        public List<Point> plot(int minValue, int maxValue, string equation)
        {
            Queue<string> expression = expressionParse(equation);
            if (expression == null)
                return null;
            
            
        }
        private Queue<string> expressionParse(string equation)
        {
            equation = spaceAroundOperators(equation);
            string [] array = equation.Split(' ');
            Stack<string> operators = new Stack<string>();
            Queue<string> output = new Queue<string>();
            foreach (string s in array)
            {
                if (char.IsDigit(char.Parse(s)))
                {
                    output.Enqueue(s);
                }
                else if(s.Length > 1)
                {
                    operators.Push(s);
                }
                else if (s.Equals("("))
                {
                    operators.Push(s);
                }
                else if (s.Equals(")"))
                {
                    bool found = false;
                    while (operators.Any())
                    {
                        if (operators.Peek().Equals("("))
                        {
                            found = true;
                            operators.Pop();
                            break;
                        }
                        output.Enqueue(operators.Pop());
                    }
                    if (!found)
                    {
                        return null;
                    }
                }
                else
                {
                    Regex r = new Regex(@"[+^*/-]");
                    while(operators.Any() && r.IsMatch(operators.Peek()))
                    {
                        if(getPrecedence(s) <= getPrecedence(operators.Peek()))
                        {
                            output.Enqueue(operators.Pop());
                        }
                    }
                    operators.Push(s);
                }
            }
            while (operators.Any())
            {
                output.Enqueue(operators.Pop());
            }
            return output;
        }
        private string spaceAroundOperators(string equation)
        {
            for(var i = 0; i < equation.Length; i++)
            {
                if(equation[i].Equals("+") | equation[i].Equals("-") | equation[i].Equals("*") | equation[i].Equals("^") | equation[i].Equals("(") | equation[i].Equals(")"))
                {
                    equation.Insert(i, " ");
                    equation.Insert(i + 2, " ");
                }
            }
            return equation.Trim();
        }
        private int getPrecedence(string op)
        {
            switch (op)
            {
                case "^":
                    return 10;
                case "*":
                    return 5;
                case "/":
                    return 5;
                case "+":
                    return 1;
                case "-":
                    return 1;
            }
            return 0;
        }
    }
}
