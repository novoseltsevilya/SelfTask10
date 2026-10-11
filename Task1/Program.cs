using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Task1
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество градусов:");
            int grad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество минут:");
            int mins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество секунд:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(grad, mins, seconds);

            double result = angle.ToRadians();
            Console.WriteLine("Введенное значение градусов: {0}.\n" +
                "Введенное значение минут: {1}.\n" +
                "Введенное значение секунд: {2}.\n" +
                "Угол в радианах: {3}.\n" +
                "Для выхода нажмите любую клавишу:", angle.Gradus, angle.Mins, angle.Seconds, result);
            Console.ReadKey();
        }
    }
}