using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
           

           Ford ford = new Ford();

           ford.Model = "Pinto";
           ford.color = "Yellow";
           ford.Start();
           ford.StartMyCar();

           Vehicle myFord = new Ford();

           myFord.Make = "Ford";
           myFord.color = "Red";
           myFord.Start();
        }
    }
}
