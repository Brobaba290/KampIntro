using System;

namespace CustomMyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> listem = new MyList<string>();
            listem.Add("Kaan");
            listem.Add("Haydar");
            listem.Add("Çağdaş");

            Console.WriteLine("Adet : " + listem.Count());

            foreach (var item in listem.Listem)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
