using System.Collections.Generic;

namespace Challenges
{

    public class ArrayToAdd : IArrayToAdd
    {
        //Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
        public bool DoesArrayContainTwoNumbersThatEqualk(int k, int[] array)
        {
            HashSet<int> neededValues = new HashSet<int>(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                if (neededValues.Contains(array[i]))
                {
                    return true;
                }

                neededValues.Add(k - array[i]);
            }

            return false;
        }
    }
}
