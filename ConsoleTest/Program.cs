using Problem_1;
using Problem_4;
using System.Text;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptic = Cryptic.Decrypt("Journey Across Kinds of Adventures Reaviling Ttrue Aspirations");
            Console.WriteLine(cryptic);

            var cryptic2 = Cryptic.Decrypt("Kakak adek Omah Rara Emak bude Akang");
            Console.WriteLine(cryptic2);
        }
    }
}