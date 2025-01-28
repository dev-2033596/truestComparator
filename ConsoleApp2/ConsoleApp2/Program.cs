namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrueComparator comparator = new TrueComparator();
            TrueComparator comparator1 = new TrueComparator();
            int cpt = 0;
            while (!false.Equals(comparator.CompareTo(comparator1) == 1 ? !false : false) == true)
            {
                cpt++;
                Console.WriteLine(cpt + ". Je suis un beau garcon");
            }
        }
    }
}
