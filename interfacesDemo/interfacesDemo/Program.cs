using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWork [] workers = new IWork[3]
            {
                new Manager(),
                new worker(),
                new Mrobot()

            };
            foreach (var worker in workers)
            {
                worker.work();
                
            }
            IEat[] eats = new IEat[2]
                {
                new worker(),
                new Manager(),
                
            };
            foreach(var eat in eats) 
            {
               eat.eat();

            }
            ISalary[] salarys = new ISalary[2] 
            {
            new worker(),
            new Manager(),
            
            };
            foreach(var salary in salarys)
            {
                salary.getsalary();

            }
         

            Console.ReadLine();
        }
        interface IWork 
        {
            void work();
        
        }
        interface IEat
        {
            void eat();
        }
        interface ISalary
        {
            void getsalary();
        }

        class Manager : IWork, IEat, ISalary
        {
            public void eat()
            {
                Console.WriteLine("yemek ye");
            }

            public void getsalary()
            {
                Console.WriteLine("yonetici maaşı");
            }

            public void work()
            {
                Console.WriteLine("çalış");
            }
        }
        class worker : IWork, IEat, ISalary
        {
            public void eat()
            {
                Console.WriteLine("yemek ye ");
            }

            public void getsalary()
            {
                Console.WriteLine("çalışan maaşı");
            }

            public void work()
            {
                Console.WriteLine("çalış");
            }
        }
        class Mrobot : IWork
        {
            public void work()
            {
                Console.WriteLine("çalış");
            }
        }


    }
}
