namespace Problem_1
{
    public class Denomination
    {
        public int Rupiah { get; set; }
        public int Coin { get; set; }
        public Denomination(int amount)
        {
            int[] typeAmount = { 100000, 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100 };
            for (int i = 0; i < typeAmount.Length; i++)
            {
                if (amount > 0)
                {
                    var modulo = amount % typeAmount[i];
                    if (amount.ToString().Length > 3) Rupiah += amount / typeAmount[i];
                    else Coin += amount / typeAmount[i];
                    amount = modulo;
                    continue;
                }
                break;
            }
        }
    }
}