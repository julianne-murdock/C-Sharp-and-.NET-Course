using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    public class Employee : Person, IQuittable //inherit that interface and implement the Quit() method in any way you choose.
    {
        public override void SayName()
        {
            Console.WriteLine("Name: ");
            base.SayName();

        }
        public void Quit()
        {
            Console.WriteLine("this is the 'Quit' method \n");
        }
    }
}
