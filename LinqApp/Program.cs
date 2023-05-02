// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        /* Дано целое число K (> 0) и целочисленная последовательность A. Найти теоретико-множественную
           разность двух фрагментов A: первый содержит все четные числа, а второй — все числа с порядковыми
           номерами, большими K. В полученной последовательности (не содержащей одинаковых элементов)
           поменять порядок элементов на обратный.
           **/
        
        var k = 5;
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var even = a.Where(x => x % 2 == 0);
        var greaterThanK = a.Skip(k);
        var result = even.Union(greaterThanK).Distinct().Reverse();
        Console.WriteLine(string.Join(", ", result));

        /*
    Даны целые числа K1 и K2 и целочисленные последовательности A и B. Получить последовательность,
содержащую все числа из A, большие K1, и все числа из B, меньшие K2. Отсортировать полученную
последовательность по возрастанию.
         */
        var k1 = 3;
        var k2 = 7;
        int[] a2 = { 2, 4, 6, 8, 10 };
        int[] b = { 1, 3, 5, 7, 9 };
        var greaterThanK1 = a2.Where(x => x > k1);
        var lessThanK2 = b.Where(x => x < k2);
        var combined = greaterThanK1.Concat(lessThanK2).OrderBy(x => x);
        Console.WriteLine(string.Join(", ", combined));

        /*
         Исходная последовательность содержит сведения об абитуриентах. Каждый элемент
последовательности включает следующие поля:
<Фамилия> <Год поступления> <Номер школы>
Для каждой школы вывести общее число абитуриентов за все годы и фамилию первого из абитуриентов
этой школы, содержащихся в исходном наборе данных (вначале указывать номер школы, затем число
абитуриентов, затем фамилию). Сведения о каждой школе выводить на новой строке и упорядочивать
по возрастанию номеров школ.
         */
        string[] applicants = { "Ivanov 2001 1", "Ivanova 2001 2", "Petrov 2002 1", "Sidorov 2003 1", "Abdullaev 2002 2", "Tsoy 2002 2" };
        var schools = new Dictionary<int, List<string>>();
        foreach (var applicant in applicants)
        {
            var parts = applicant.Split(' ');
            var schoolNumber = int.Parse(parts[2]);
            if (!schools.ContainsKey(schoolNumber))
            {
                schools[schoolNumber] = new List<string>();
            }
            schools[schoolNumber].Add(applicant);
        }
        foreach (var schoolNumber in schools.Keys.OrderBy(x => x))
        {
            var applicantsForSchool = schools[schoolNumber];
            Console.WriteLine($"School {schoolNumber}: {applicantsForSchool.Count} applicants, {applicantsForSchool.First()}");
        }
    }
}

