namespace Challenges
{
    public class MultiplyArray :IMultiplyArray
    {
        //Given an array of integers, return a new array such that each element at index i of the new array is the product of all the numbers in the original array except the one at i.
        public int[] MultiplyNumbersInArrayAndReturnArray(int[] array)
        {
            var resultArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                resultArray[i] = 1;

                for (int x = 0; x < array.Length; x++)
                {
                    if (i != x)
                    {
                        resultArray[i] = resultArray[i] * array[x];
                    }
                }
            }

            return resultArray;
        }
    }
}
