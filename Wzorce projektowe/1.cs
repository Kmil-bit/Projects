using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp11
{
    //Zadanie 2
    public enum Operator
    {
        Add,
        Sub,
        Mul,
        Div,
        Pow
    }
    public interface IOperator
    {
        double Process(double a, double b);
    }
    public class OpenCloseCalculator
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public IOperator Operator { get; set; }



        public double Calculate()
        {
            return Operator.Process(Operand1, Operand2);
        }
    }



    class AddOperator : IOperator
    {
        public double Process(double a, double b)
        {
            return a + b;
        }



    }







    class Calculator
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public Operator Operator { get; set; }



        double Calculate(Operator op)
        {
            switch (Operator)
            {
                case Operator.Add:
                    return Operand1 + Operand2;
                case Operator.Sub:
                    return Operand1 - Operand2;
                case Operator.Mul:
                    return Operand1 * Operand2;
                case Operator.Div:
                    return Operand1 / Operand2;
                case Operator.Pow:
                    return Math.Pow(Operand1, Operand2);
            }
            return Double.NaN;
        }
    }
    //class AddressEmail
    //{
    //    public string Email { get; set; }
    //    public string Domain
    //    {
    //        get
    //        {
    //            return Email.Split("@")[1];
    //        }
    //    }
    //}
    //class Person
    //{
    //    public int ID { get; set; }
    //    public string Name { get; set; }
    //    public AddressEmail AddressEmail { get; set; }
    //}
    //class Producer
    //{
    //    public AddressEmail AddressEmail { get; set; }





    //}


    // Zadanie 3
    public abstract class Shape
    {


        public abstract double area();

    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }


        public override double area()
        {


            return Width * Height;
        }

    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }


        public override double area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }


    public class Triangle : Shape
    {
        public double BaseLength { get; set; }
        public double Height { get; set; }

        public Triangle(double baseLength, double height)
        {
            BaseLength = baseLength;
            Height = height;
        }
        public override double area()
        {
            return 0.5 * BaseLength * Height;
        }
    }


    public class Store
    {
        List<Shape> shapes = new List<Shape>();
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
        }
        public double Area()
        {
            double a = 0;
            foreach (var shape in shapes)
            {
                a += shape.area();

            }
            return a;
        }





        internal class Program
        {

            //SOLID
            //Single Responsibility Principle
            //Open Close Priciple
            static void Main(string[] args)
            {
                Store store = new Store();

                store.AddShape(new Rectangle(8, 6));
                store.AddShape(new Circle(13));
                store.AddShape(new Triangle(2, 7));

                Console.WriteLine("Łączna powierzchnia figur: " + store.Area());
                /*
                // KissExample();
                OpenCloseDemo();
            }
            class PowerOperator : IOperator
            {
                public double Process(double a, double b)
                {
                    return Math.Pow(a, b);
                }
            }
            private static void OpenCloseDemo()
            {
                OpenCloseCalculator calculator = new OpenCloseCalculator()
                {
                    Operand1 = 4,
                    Operand2 = 6,

                    Operator = new PowerOperator()



                };
                Console.WriteLine(calculator.Calculate());
            }
            private static void KissExample()
            {
                Console.WriteLine("Wpisz pierwszy składnik sumy");
                string s1 = Console.ReadLine();
                double a = 0;
                double b = 0;
                ParseString(s1, ref a);
                Console.WriteLine("Wpisz drugi składnik sumy");
                string s2 = Console.ReadLine();
                ParseString(s2, ref b);



                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            //Wprowadzenie tej metody wynika z zasady DRY
            private static void ParseString(string s1, ref double a)
            {
                try
                {
                    a = double.Parse(s1);
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Wpisano znak nie będący cyfrą");
                    Environment.Exit(1);
                }*/
            }
                
        }
    }
}