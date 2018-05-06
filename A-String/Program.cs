using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// http://ejudge.1gb.ru/cgi-bin/new-register?contest_id=9
/// String 10
/// На вход программы подается текст на английском языке, заканчивающийся точкой(другие символы “.” в тексте отсутствуют).
/// Требуется написать программу, которая будет определять и выводить на экран английскую букву, встречающуюся в этом тексте чаще всего, и количество там таких букв.
/// Строчные и прописные буквы при этом считаются не различимыми.
/// Если искомых букв несколько, то программа должна выводить на экран первую из них по алфавиту.
/// Например, пусть файл содержит следующую запись: It is not a simple task. Yes!
/// Чаще всего здесь встречаются буквы I, S и T (слово Yes в подсчете не учитывается, так как расположено после точки).
/// Следовательно, в данном случае программа должна вывести два символа, разделенных пробелом: I 3
/// </summary>
namespace A_String
{
    class Program
    {
        static void Main(string[] args)
        {
            // according to ASCII Alphabet Characters first symbol "A" has 65 decimal value
            const int convert = 65;
            const int alphabet = 26;
            int[] ch = new int[alphabet];

            //Prepare console
            Console.ForegroundColor = ConsoleColor.Green;

            //get string
            string str = Console.ReadLine();

            //cut string
            str = str.Substring(0, str.IndexOf('.'));

            //convert string
            str = str.ToUpper();
            
            //make frequency array of chars
            foreach(char c in str)
            {
                if ((int)c >= convert && (int)c < convert + alphabet) ch[(int)c - convert]++;
            }

            //find max frequency
            int max = 0;
            for (int i = 0; i < alphabet; i++) if (ch[max] < ch[i]) max = i;

            //print out first max frequency
            Console.WriteLine($"{(char)(max + convert)} {ch[max]}");
            
            Console.ReadKey();
        }
    }
}
