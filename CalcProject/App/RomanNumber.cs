using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject.App
{
    public class RomanNumber
    {
        public static int Parse(String str)
        {
            char[] digits = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] digitValues = { 1, 5, 10, 50, 100, 500, 1000 };

            int pos = 1;  // позиція останньої цифри у str
            int ind = Array.IndexOf(digits, str[pos]);  // індекс цифри у масиві
            if(ind == -1)  // цифри немає у масиві
            {
                throw new ArgumentException($"Invalid digit '{str[pos]}'");
            }
            int res = digitValues[ind];  // остання цифра завжди з +

            ind = Array.IndexOf(digits, str[pos-1]);  // передостання цифра
            if (ind == -1)  // цифри немає у масиві
            {
                throw new ArgumentException($"Invalid digit '{str[pos - 1]}'");
            }
            if (digitValues[ind] < res) res -= digitValues[ind];
            else res += digitValues[ind];

            return res;
        }
    }
}
/*
 Римські числа
Складаються з римських цифр:
 I - 1
 V - 5
 X - 10
 L - 50
 C - 100
 D - 500
 M - 1000
За правилом: якщо після цифри наступна цифра є більшою,
 то вона віднімається від результату
 інакше - додається до результату
Наприклад
 II +1+1
 IV -1+5
 XL -10+50
 XV +10+5
 MCM +1000-100+1000 = 1900
 */