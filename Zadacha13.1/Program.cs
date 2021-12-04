using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите адрес здания: ");
            string address = Console.ReadLine();
            double length, width, height;
            Console.Write("Введите длину здания в метрах: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину здания в метрах: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту здания в метрах: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите количество этажей здания: ");
            int countFloors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            MultiBuilding multibuilding = new MultiBuilding(address,length,width,height,countFloors);
            multibuilding.Print();
            Console.ReadKey();
        }
    }
    class Building
    {
        string address = "без адреса";
        double length = 1;
        double width = 1;
        double height = 1;
        public string Address
        {
            set
            {
                if (value.Length>0)
                {
                    address = value;
                }
            }
            get
            {
                return address;
            }
        }
        public double Length
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка! Длина здания должны быть больше нуля. Величина приведена к базовому значению, равному 1 м.");
                }
                else if (value >= 1)
                {
                    length = value;
                }
                else
                {
                    Console.WriteLine("Какая то слишком маленькая у вас длина здания. Величина приведена к базовому значению, равному 1 м.");
                }
            }
            get
            {
                return length;
            }
        }
        public double Width
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка! Ширина здания должны быть больше нуля. Величина приведена к базовому значению, равному 1 м.");
                }
                else if (value >= 1)
                {
                    width = value;
                }
                else
                {
                    Console.WriteLine("Какая то слишком маленькая у вас ширина здания. Величина приведена к базовому значению, равному 1 м.");
                }
            }
            get
            {
                return width;
            }
        }
        public double Height
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка! Высота здания должны быть больше нуля. Величина приведена к базовому значению, равному 1 м.");
                }
                else if (value >= 1)
                {
                    height = value;
                }
                else
                {
                    Console.WriteLine("Какая то слишком маленькая у вас высота здания. Величина приведена к базовому значению, равному 1 м.");
                }
            }
            get
            {
                return height;
            }
        }
        public Building(string address, double length, double width, double hight)
        {
            Address = address;
            Length = length;
            Width = width;
            Height = hight;
        }
        public void Print()
        {
            Console.WriteLine("    Информация о здании:");
            Console.WriteLine("    - адрес здания: {0};",address);
            Console.WriteLine("    - длина здания составлет {0:N} м;",length);
            Console.WriteLine("    - ширина здания составлет {0:N} м;",width);
            Console.WriteLine("    - высота здания составлет {0:N} м;",height);
        }
    }
    sealed class MultiBuilding: Building
    {
        int countFloors = 1;
        public int CountFloors
        {
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Ошибка! Количество этажей здания должны быть больше нуля. Величина приведена к базовому значению, равному 1 м.");
                }
                else
                {
                    countFloors = value;
                }
            }
            get
            {
                return countFloors;
            }
        }
        public MultiBuilding(string address, double length, double width, double height, int countFloors)
            :base(address,length,width,height)
        {
            CountFloors = countFloors;
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("    - количество этажей здания составлет {0}.", countFloors);
        }
    }
}
