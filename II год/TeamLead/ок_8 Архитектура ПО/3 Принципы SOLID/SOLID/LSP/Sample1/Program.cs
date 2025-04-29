using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Sample1
{
    internal class Program
    {
        /**
         Тип S будет подтипом T тогда и только тогда, когда каждому объекту oS типа S соответствует некий объект oT
        типа T таким образом, что для всех программ P, реализованных в терминах T, поведение P не будет меняться, если
        oT заменить на oS.*/
        /*public static void Main(string[] args)
        {
            Bird bird1 = new Bird();
            Bird bird2 = new Bird();
            Bird bird3 = new Bird();
            Ostrich bird4 = new Ostrich();

            Bird[] birds = new Bird[] { bird1, bird2, bird3, bird4 };

            FlyBirds(birds);


        }

        public static void FlyBirds(Bird[] birds)
        {
            foreach(Bird bird in birds)
            {
                if(bird.IsCanFly())
                {
                    bird.Fly();
                }
            }
        }*/
    }
}
