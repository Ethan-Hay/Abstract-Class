namespace Abstract_Class
{
    public class Ford : Vehicle
    {
        public string color {get;set;}

        public void StartMyCar()
        {
            System.Console.WriteLine("The Ford has started");
        }
        
        public override void Drive()
        {
            System.Console.WriteLine("The Ford is driving");
        }

        public override void Brake()
        {
            System.Console.WriteLine("The Ford is braked");
        }

        public override void Refuel()
        {
            System.Console.WriteLine("The Ford is refueled");
        }
    }
}