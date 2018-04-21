using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_class_ComplNumb
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ComplNumb z1 = new ComplNumb();
            ComplNumb z2 = new ComplNumb();

            Console.WriteLine("Комплексные числа в данном примере представлены в виде : z = r + i");
            Console.WriteLine("где r - действительная часть числа, i - мнимая его часть.");
            Console.WriteLine();
            Console.Write("Введите целую часть первого комплексного числа: ");
            z1.r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            z1.i = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            z2.r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            z2.i = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Спасибо.      Операции с введенными числами :");
            Console.WriteLine("Сложение:       {0} + {1}i", (z1 + z2).r, (z1 + z2).i);
            Console.WriteLine("Вычитание:      {0} + {1}i", (z1 - z2).r, (z1 - z2).i);
            Console.WriteLine("Умножение:      {0} + {1}i", (z1 * z2).r, (z1 * z2).i);
            Console.WriteLine("Деление:        {0} + {1}i", (z1 / z2).r, (z1 / z2).i);

            Console.ReadKey();
        }
    }
}
