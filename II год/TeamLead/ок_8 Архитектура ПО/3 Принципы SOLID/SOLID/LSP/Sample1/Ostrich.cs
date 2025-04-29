using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Sample1
{
    public class Ostrich : Bird
    {
        public Ostrich(): base(false)
        {
            
        } 

        public void Fly()
        {
            Console.WriteLine("Страус не умеет летать.");
        }

        public void Run()
        {
            Console.WriteLine("Страус бегает");
        }

    }
}
