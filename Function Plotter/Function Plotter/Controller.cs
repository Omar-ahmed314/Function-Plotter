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
            Point point;
            Queue<string> expression = expressionParse(equation);
            List<Point> points = new List<Point>();
            if (expression == null)
                return null;
            for (int i = minValue; i <= maxValue; i++)
            {
                point = new Point();
                point.XCoordinate = i;
                point.YCoordinate = calculateExpression(expression, i);
                points.Add(point);
            }
            return points;
            
        }
        private Queue<string> expressionParse(string equation)
        {
            equation = spaceAroundOperators(equation);
            string [] array = equation.Split(' ');
            Stack<string> operators = new Stack<string>();
            Queue<string> output = new Queue<string>();
            foreach (string s in array)
            {
                if (char.IsDigit(char.Parse(s)) | s.Equals("x"))
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
            string modifiedEquation = "";
            Regex r = new Regex(@"[+*/^-]");
            for(var i = 0; i < equation.Length; i++)
            {
                if (r.IsMatch(equation[i].ToString()))
                {
                    modifiedEquation += " " + equation[i] + " ";
                }
                else if(int.TryParse(equation[i].ToString(), out _) | equation[i].Equals('x'))
                {
                    modifiedEquation += equation[i];
                }
            }
            return modifiedEquation;
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
        private double calculateExpression(Queue<string> exp, int x)
        {
            Stack<double> result = new Stack<double>();
            Queue<string> expression = new Queue<string>(exp);
            double num1, num2;
            string top;
            while(expression.Count > 0)
            {
                top = expression.Dequeue();
                if(int.TryParse(top, out _))
                {
                    result.Push(Convert.ToDouble(top));
                }
                else if (top.Equals("x"))
                {
                    result.Push(Convert.ToDouble(x));
                }
                else
                {
                    switch (top)
                    {
                        case "+":
                            num1 = result.Pop();
                            num2 = result.Pop();
                            result.Push(num1 + num2);
                            break;
                        case "-":
                            num1 = result.Pop();
                            num2 = result.Pop();
                            result.Push(num2 - num1);
                            break;
                        case "*":
                            num1 = result.Pop();
                            num2 = result.Pop();
                            result.Push(num1 * num2);
                            break;
                        case "/":
                            num1 = result.Pop();
                            num2 = result.Pop();
                            result.Push(num2 / num1);
                            break;
                        case "^":
                            num1 = result.Pop();
                            num2 = result.Pop();
                            result.Push(Math.Pow(num2, num1));
                            break;
                        case "sin":
                            num1 = result.Pop();
                            result.Push(Math.Sin(num1));
                            break;
                        case "cos":
                            num1 = result.Pop();
                            result.Push(Math.Cos(num1));
                            break;
                        case "tan":
                            num1 = result.Pop();
                            result.Push(Math.Tan(num1));
                            break;

                    }
                }


            }
            return result.Pop();
        }
    }
}
