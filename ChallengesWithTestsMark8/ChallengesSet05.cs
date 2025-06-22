using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (n == 0) throw new DivideByZeroException();

            int next = startNumber + 1;

            while (next % n != 0)
            {
                next++;
            }

            return next;        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue == 0)
                {
                    biz.Name = "CLOSED";
                }
            }        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                    return false;
            }

            return true;        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2) return 0;

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";

            var cleanedWords = words
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .Select(w => w.Trim());

            return string.Join(" ", cleanedWords) + (cleanedWords.Any() ? "." : "");        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count < 4) return new double[0];

            return elements
                .Where((val, index) => (index + 1) % 4 == 0)
                .ToArray();        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2) return false;

            HashSet<int> seen = new HashSet<int>();

            foreach (var num in nums)
            {
                int complement = targetNumber - num;
                if (seen.Contains(complement))
                    return true;

                seen.Add(num);
            }

            return false;
        }        }
    }

