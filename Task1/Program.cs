using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        class Corner
        {
            int gradus;
            int minute;
            int second;
            public int Gradus
            {
                get
                {
                    return gradus;
                }
                set
                {
                    gradus = value;
                }
            }
            public int Minute
            {
                get
                {
                    return minute;
                }
                set
                {
                    minute = value;
                }
            }
            public int Seccond
            {
                get
                {
                    return second;
                }
                set
                {
                    second = value;
                }
            }

            public Corner(int gradus, int min, int sec)
            {
                this.gradus = gradus;
                this.minute = minute;
                this.second = second;
            }
            public double ToRadians()
            {
                return gradus * Math.PI / 180 + minute * Math.PI / (180 * 60) + second * Math.PI / (180 * 3600);

                static void Main(string[] args)
                {
                    Console.WriteLine("Введите угол с указанием градусов, минут, секунд (ввести 3 целочисленных значения)");
                    int gradus = Convert.ToInt32(Console.ReadLine());
                    int minute = Convert.ToInt32(Console.ReadLine());
                    int second = Convert.ToInt32(Console.ReadLine());

                    Corner corner = new Corner(gradus, minute, second);
                    double radians = corner.ToRadians();
                    Console.WriteLine(radians);
                    Console.ReadKey();
                }
            }
        }
    }
}
