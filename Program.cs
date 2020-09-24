using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> Check = new List<IIdentifiable>();
            string lines = Console.ReadLine();
            while(lines != "End")
            {
                string[] input = lines.Split();
                if(input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    IIdentifiable human = new Citizen()
                    {
                        Name = name,
                        Age = age,
                        Id = id
                    };
                    Check.Add(human);
                }
                else if(input.Length == 2)
                {
                    string model = input[0];
                    string id = input[1];
                    IIdentifiable robot = new Robot()
                    {
                        Model = model,
                        Id = id
                    };
                    Check.Add(robot);
                }
                else
                {
                    Console.WriteLine("False data");
                }

                lines = Console.ReadLine();
            }
            string fakeId = Console.ReadLine();
            foreach(IIdentifiable Object in Check)
            {
                if (Object.Id.EndsWith(fakeId))
                {
                    Console.WriteLine(Object.Id);
                }
            }
            
            Console.ReadKey();
        }
    }
}
