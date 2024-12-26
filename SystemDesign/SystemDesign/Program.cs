namespace SystemDesign
{
    //Singleton design pattern
    internal class Program
    {
        public static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetInstance();
            Singleton singleton2 = Singleton.GetInstance();
            Console.WriteLine(singleton1.GetHashCode());
            Console.WriteLine(singleton2.GetHashCode());
            //Console.WriteLine("Hello, World!");
        }
    }
}
