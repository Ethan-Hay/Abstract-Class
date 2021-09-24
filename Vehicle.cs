namespace Abstract_Class
{
    public abstract class Vehicle
    {
        public string Make{get;set;}
        public string Model{get;set;}
        public void Start()
        {
            System.Console.WriteLine("The vehicle is running");
        }
        public void Stop()
        {
            System.Console.WriteLine("The vehicle is stopped");
        }
        public abstract void Drive()
        {
        
        }
        public abstract void Brake()
        {

        }
        public virtual void Refuel()
        {
            System.Console.WriteLine("The vehicle is refueled");
        }
    }
}