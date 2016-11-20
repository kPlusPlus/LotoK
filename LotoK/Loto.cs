using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoK
{
    public class Loto
    {
        public int[] Numbers;
        public int[] ReserveNumbers;
        Random random = new Random();
        int newNumber;

        public Loto()
        {
            Numbers = new int[5];
            ReserveNumbers = new int[2];
        }

        public void Generate()
        {
            for (int i = 0; i < 5; i++)
            {
                newNumber = random.Next(1, 50);
                if (!Numbers.Contains(newNumber))
                    Numbers[i] = newNumber;
                else
                    i--;
            }

            for (int j = 0; j < 2; j++)
            {
                newNumber = random.Next(1, 10);
                if (!ReserveNumbers.Contains(newNumber))
                    ReserveNumbers[j] = newNumber;
                else
                    j--;
            }
        }
    }
}
