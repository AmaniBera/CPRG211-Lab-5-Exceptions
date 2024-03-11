namespace Lab_5_Exceptions
{
    internal class Program
    {
        class MainClass
        {
            static void Main(string[] args)
            {
                //Creates the objects
                Circle circle1 = new Circle();
                Circle circle2 = new Circle();
                Circle circle3 = new Circle();
                int input;

                //Picks what which object to set
                Console.WriteLine("Radius: 1.Positive   2.Negative  3.Zero");
                Console.WriteLine("Emter input: ");
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        circle1.SetRadius(2.9);
                        break;
                    case 2:
                        circle2.SetRadius(-2.2);
                        break;
                    case 3:
                        circle3.SetRadius(0);
                        break;
                }

                

            }

            class Circle
            {
                double radius;

                public void SetRadius(double value)
                {
                    if (value > 0)
                    {
                        //sets the radius
                        radius = value;
                        ToString();
                    }
                    else if (value < 0)
                    {
                        throw new InvalidRadiusException(value); 
                    }
                    else 
                    { 
                        throw new InvalidRadiusException();
                    }
                }

                public void ToString()
                {
                    Console.WriteLine($"Radius: {radius}");
                }

            }
            class InvalidRadiusException : Exception
            {
                public InvalidRadiusException() : base("invalid radius!!!! Radius should be greater than zero.")
                {

                }

                public InvalidRadiusException(double radius) : base($"{radius} is an invalid radius!!! Radius should be greater than zero.")
                {

                }
            }
        }
    }
}
