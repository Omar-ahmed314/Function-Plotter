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

        private Controller() { }
        public static Controller instantiate()
        {
            if (controller == null)
            {
                controller = new Controller();
            }
            return controller;
        }
        public List<Point> plot(int minValue, int maxValue, string equation)
        {
            if (!(isValidParanthasis(equation) && isValidExpression(equation)))
                return null;
            Point point;
            Queue<string> expression = expressionParse(equation);
            List<Point> points = new List<Point>();
            if (expression == null)
                return null;
            for (int i = minValue; i <= maxValue; i++)
            {
                point = new Point();
                point.XCoordinate = i;
                try
                {
                    point.YCoordinate = calculateExpression(expression, i);
                }
                catch (Exception ex)
                {
                    return null;
                }
                points.Add(point);
            }
            return points;

        }
        private Queue<string> expressionParse(string equation)
        {
            equation = equation.ToLower();
            equation = spaceAroundOperators(equation);
            string[] array = equation.Split(' ');
            Stack<string> operators = new Stack<string>();
            Queue<string> output = new Queue<string>();
            foreach (string s in array)
            {
                if (int.TryParse(s, out _) | s.Equals("x") | s.Equals("e") | s.Equals("pi"))
                {
                    output.Enqueue(s);
                }
                else if (s.Length > 1)
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
                    if (operators.Any() && operators.Peek().Length > 1 && !int.TryParse(operators.Peek(), out _))
                    {
                        output.Enqueue(operators.Pop());
                    }
                }
                else
                {
                    Regex r = new Regex(@"[+^*/-]");
                    while (operators.Any() && r.IsMatch(operators.Peek()))
                    {
                        if (getPrecedence(s) <= getPrecedence(operators.Peek()))
                        {
                            output.Enqueue(operators.Pop());
                        }
                        else
                        {
                            break;
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
            string modifiedEquation = " ";
            Regex r = new Regex(@"[+*/^()-]");
            for (var i = 0; i < equation.Length; i++)
            {
                if (r.IsMatch(equation[i].ToString()))
                {
                    if (!modifiedEquation[modifiedEquation.Length - 1].Equals(' '))
                        modifiedEquation += " ";
                    modifiedEquation += equation[i] + " ";
                }
                else if (!equation[i].Equals(' '))
                {
                    modifiedEquation += equation[i];
                }
            }
            return modifiedEquation.Trim();
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
            while (expression.Count > 0)
            {
                top = expression.Dequeue();
                if (int.TryParse(top, out _))
                {
                    result.Push(Convert.ToDouble(top));
                }
                else
                {
                    switch (top)
                    {
                        case "x":
                            result.Push(Convert.ToDouble(x));
                            break;
                        case "e":
                            result.Push(Math.E);
                            break;
                        case "pi":
                            result.Push(Math.PI);
                            break;
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
                        case "log":
                            num1 = result.Pop();
                            result.Push(Math.Log10(num1));
                            break;
                        default:
                            throw new Exception();

                    }
                }


            }
            return result.Pop();
        }
        private bool isValidParanthasis(string expression)
        {
            Stack<int> paranthasis = new Stack<int>();
            foreach (char s in expression)
            {
                if (s.Equals('('))
                    paranthasis.Push(1);
                else if (s.Equals(')'))
                {
                    if (paranthasis.Any())
                        paranthasis.Pop();
                    else
                        return false;
                }
            }
            if (paranthasis.Any())
                return false;
            return true;
        }

        private bool isValidExpression(string expression)
        {
            Regex r = new Regex(@"((\(\))|(\)\()|\d\(|\)\d)");
            return !r.IsMatch(expression);
        }
    }
}

