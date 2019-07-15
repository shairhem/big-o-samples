namespace BigONotation
{
    using System;

    public class TestFunctions
    {
        // Time Complexity O(n^2)
        public int[] Sort(int[] items)
        {
            int size, temp;
            size = items.Length;

            for(var i = 0; i < size - 1; i++)
            {
                for (var j = 0; j < size - 1; j++)
                {
                    if(items[j] > items[j+1])
                    {
                        temp = items[j];
                        items[j] = items[j + 1];
                        items[j + 1] = temp;
                    }
                }
            }

            return items;
        }

        // Time Complexity O(n)
        public int FindIndex(string[] items, string value)
        {
            var result = -1;
            for (var ctr = 0; ctr < items.Length; ctr++)
            {
                if (items[ctr] == value)
                {
                    result = ctr;
                    break;
                }
            }

            return result;
        }

        // Time Complexity O(NM)
        public int FindPattern(String txt, String pat)
        {
            int M = pat.Length;
            int N = txt.Length;
            int index = -1;
            /* A loop to slide pat one by one */
            for (int i = 0; i <= N - M; i++)
            {
                int j;

                /* For current index i, check for pattern  
                match */
                for (j = 0; j < M; j++)
                    if (txt[i + j] != pat[j])
                        break;

                // if pat[0...M-1] = txt[i, i+1, ...i+M-1] 
                if (j == M)
                    index = i;
            }

            return index;
        }

        // Time complexity O(n)
        // one word only; does not handle whitepace, symbols, and case
        public bool IsPalindrome(String value)
        {
            bool isPalindrome = false;
            int lenght = value.Length;
            for (var i = 0; i < lenght;  i++)
            {
                if (value[i] != value[lenght - 1 - i])
                    break;

                isPalindrome = true;
            }

            return isPalindrome;
        }

        // Time complexity O(log n)
        public int BinarySearchIterative(int[] inputArray, int key)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }
    }
}
