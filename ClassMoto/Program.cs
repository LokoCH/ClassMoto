using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMoto
{

    class Program
    {
        static void Main(string[] args)
        {
            Moto[] motos = new Moto[] {new Moto("Ямаха", "R1", Color.WHITE, 350, 0, Country.JAPAN),
                                       new Moto("Ducati", "Multistrada", Color.BLUE, 400, 0, Country.ITALY),
                                       new Moto("Harley-Davidson","Breakout",Color.BLACK,250,0,Country.USA),
                                       new Moto("Kawasaki","Z1000",Color.GREEN,260,0,Country.JAPAN),
                                       new Moto("Honda","CBR600RR",Color.RED,250,0,Country.JAPAN)
                                      };

            Random r = new Random();
            foreach (Moto item in motos)
            {
                // увеличиваем пробег
                item.increaseOdometr(r.Next(10000, 100000));
                Console.WriteLine(item);
            }
        }
    }
}
