using System.Text;

namespace Problem_4
{
    public class Cryptic
    {
        public static string Decrypt(string text)
        {
            if (text != null)
            {
                return text.Where(textChar => char.IsLetter(textChar) && char.IsUpper(textChar)).ToString();
            }
            return default;
        }
    }
}