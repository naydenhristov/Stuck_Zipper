using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1_6_Stuck_Zipper
{
    public class Stuck_Zipper
    {
        public static void Main()
        {
            List<int> numbersList1 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> numbersList2 = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int minLength1 = MinLength(numbersList1);
            int minLength2 = MinLength(numbersList2);

            int minLength = minLength1 > minLength2 ? minLength2 : minLength1;

            numbersList1 = RemoveLongNumbers(numbersList1, minLength);
            numbersList2 = RemoveLongNumbers(numbersList2, minLength);
            
            int maxLength = numbersList1.Count > numbersList2.Count ? 
                numbersList1.Count : numbersList2.Count;

            for (int i = 0; i < maxLength; i++)
            {
                if (i < numbersList2.Count)
                {
                    Console.Write(numbersList2[i] + " ");
                }
                if (i < numbersList1.Count)
                {
                    Console.Write(numbersList1[i] + " ");
                }
            }

            Console.WriteLine();
        }

        private static List<int> RemoveLongNumbers(List<int> numbersList, int minLength)
        {

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (Math.Abs(numbersList[i]).ToString().Length > minLength)
                {
                    numbersList.RemoveAt(i);
                    i--;
                }
            }

            return numbersList;
        }

        private static int MinLength(List<int> numbersList)
        {
            int minLength = int.MaxValue;
            
            foreach (int number in numbersList)
            {
                if (Math.Abs(number).ToString().Length < minLength)
                {
                    minLength = Math.Abs(number).ToString().Length;
                }
            }

            return minLength;
        }
    }
}
