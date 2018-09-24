using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryMission
{
    class Program
    {
        static void Main(string[] args)
        {
            Officer LT = new Officer();
            LT.Command();
            Personell Joe = new Enlisted();
            Joe.Salute();
            LT.Salute();
            Tank Abrams = new Tank();
            Abrams.Mount();
            Abrams.Load();
            Abrams.Shoot();
            Console.WriteLine("Now the Helos!");
            Joe.Salute();
            Helicopter Apache = new Helicopter();
            Apache.Load();
            Apache.Mount();
            Apache.Fly();
            Apache.Shoot();
            Console.ReadLine();
        }
    }
}
