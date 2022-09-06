    namespace FirstApplication
    {
        public class Logic
        {
            public static double Square_area(int Square_Side)
            {
                double Sqare_S = Math.Pow(Square_Side, 2);
                return Sqare_S;
            }

            public static double Circle_area(int Circle_Radius)
            {
                double Circle_S = Math.Pow(Circle_Radius, 2) * 3.14;
                return Circle_S;
            }

            public static string Compare(double Square_S, double Circle_S)
            {
                string OutMessage = "";
                if (Square_S > Circle_S)
                {
                    OutMessage = "Площадь квадрата больше площади круга!";
                }
                else if (Circle_S > Square_S)
                {
                    OutMessage = "Площадь круга больше площади квадрата!";
                }
                else
                {
                    OutMessage = "Площади круга и квадрата одинаковы!";
                }
                return OutMessage;
            }
        }
        public class Program
        {
        
            static void Main(string[] args)
            {
                //НАЧАЛО взаимодейтсвия с пользователем
                Console.WriteLine("Введите R круга");
                var Circle_Radius = int.Parse(Console. ReadLine());
                Console.WriteLine("Введите длинну стороны квадрата");
                var Square_Side = int.Parse(Console.ReadLine());
                //КОНЕЦ взаимодейтсвия с пользователем

                //НАЧАЛО логики
                var Circle_S = Logic.Circle_area(Circle_Radius);
                var Square_S = Logic.Square_area(Square_Side);
                var OutMassage = Logic.Compare(Square_S, Circle_S);
                //КОНЕЦ логики

                //НАЧАЛО взаимодейтсвия с пользователем
                Console.WriteLine(OutMassage);
                Console.ReadLine();
                //КОНЕЦ взаимодейтсвия с пользователем
            }
        }
    }

