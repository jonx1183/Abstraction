public class Program
{
    public static void Main(string[] args)
    {
        Sinatra sinatra = new Sinatra();
        Console.WriteLine($"Tonight featuring {sinatra.GetName()}"); // 1) Use getName

        sinatra.Talk();
        // 2) Uncomment this
        sinatra.Sing();
        
        ISinger s = sinatra; // 3) Assign New Sinatra instead of null
        Console.WriteLine($"The singer is {s.GetName()}");
        s.Sing();

    }

    interface ISinger
    {
        String GetName();
        void Sing();

    }

   public class Sinatra: ISinger // implement the interface
    {
        public string GetName(){
            return "Testington";
        }

        public void Sing(){
            Console.WriteLine("Singing");
        }
        // Provide the interface implementation

        public void Talk()
        {
            Console.WriteLine("Good evening Las Vegas");
        }
    }
}