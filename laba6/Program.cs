using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba6
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car = new Auto();
            car.init("Ford", "black", 300000);
            car.display();
            car.read();
            car.display();

            Autosale asale = new Autosale();
            asale.init(car, 3);
            asale.display();
            asale.read();
            asale.display();
        }
    }
}
