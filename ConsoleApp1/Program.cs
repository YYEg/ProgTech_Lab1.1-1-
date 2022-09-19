    namespace FirstApplication
    {
        public class Logic
        {
            public static double CalculateSquareArea(int squareSide)
            {
                double squareArea = Math.Pow(squareSide, 2);
                return squareArea;
            }

            public static double CalculateCircleArea(int circleRadius)
            {
                double circleArea = Math.Pow(circleRadius, 2) * Math.PI;
                return circleArea;
            }

            public static string Compare(double squareArea, double circleArea)
            {
                           
                string outMessage = "";
                if (squareArea > circleArea)
                {
                    outMessage = "Площадь квадрата больше площади круга!";
                }
                else if (circleArea > squareArea)
                {
                    outMessage = "Площадь круга больше площади квадрата!";
                }
                else
                {
                    outMessage = "Площади круга и квадрата одинаковы!";
                }
                return outMessage;
            }

            public static string DoCompare(int squareSide, int circleRadius)
             {
                double squareArea = Logic.CalculateSquareArea(squareSide);
                double circleArea = Logic.CalculateCircleArea(circleRadius);
                string outMessage = Logic.Compare(squareArea, circleArea);
                return outMessage;
            }
        }
        public class Program
        {
       /* private static int circleRadius;*/

        static void Main(string[] args)
            {
                //НАЧАЛО взаимодейтсвия с пользователем
                Console.WriteLine("Введите длинну стороны квадрата");
                var squareSide = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите R круга");
                var сircleRadius = int.Parse(Console.ReadLine());
                //КОНЕЦ взаимодейтсвия с пользователем

                //НАЧАЛО логики
                var outMassage = Logic.DoCompare(squareSide, сircleRadius);
                //КОНЕЦ логики

                //НАЧАЛО взаимодейтсвия с пользователем
                Console.WriteLine(outMassage);
                Console.ReadLine();
                //КОНЕЦ взаимодейтсвия с пользователем
            }
        }
    }

