using System.ComponentModel.Design;
using System.Diagnostics.Metrics;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //da se vuvedat n na broi imena ot klaviaturata da se
            //tyrseno ime 
            // ako e v masiva da se otpecati na koe mqsato e
            //ako ne e v masiva (not found)
            //stringovete se sruvnqvat s string (compere)
            //masiv s name[]


            Console.Write("Kolko ime iskash bre: ");
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];
            for (int i = 0; i <= names.Length - 1; i++)
            {
                Console.Write($"name [{i}] = ");
                names[i] = Console.ReadLine();
            }
            Console.WriteLine("vuvedi turseno ime: ");
            string searchName = Console.ReadLine();
            bool isFound = false;
            int counter = 0;
            for (int k = 0; k < names.Length; k++)
            {
                if (searchName == names[k])
                {
                    Console.WriteLine($"{searchName} e na {k} pisicion");
                    counter++;
                    Console.WriteLine($"{searchName} se namira {counter} puti: ");
                }
                else
                {
                    isFound = false;
                }
                //kolko puti se srehta tursenoto ime v spisuka

            }
        }
    }
}
