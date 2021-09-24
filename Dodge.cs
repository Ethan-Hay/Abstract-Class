namespace Abstract_Class
{
    public class Dodge : Vehicle
    {
        public override void Drive()
        {
            System.Console.WriteLine("The Dodge is driving");
        }

        public override void Brake()
        {
            System.Console.WriteLine("The Dodge is braked");
        }

        public override void Refuel()
        {
            System.Console.WriteLine("The Dodge is refueled");
        }
    }
}