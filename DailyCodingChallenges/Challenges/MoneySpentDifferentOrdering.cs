using System.Linq;

namespace Challenges
{
    public class MoneySpentDifferentOrdering : IMoneySpent
    {
        /// <summary>
        /// A person wants to determine the most expensive computer keyboard and USB drive that can be purchased with a give budget. Given price lists for keyboards and USB drives and a budget, find the cost to buy them. If it is not possible to buy both items, return .
        /// </summary>
        /// <param name="keyboards">the keyboard prices</param>
        /// <param name="drives">the drive prices</param>
        /// <param name="b">the budget</param>
        /// <returns>The Max Spendable amount or -1 if no combinations are within budget.</returns>
        public int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var orderedKeyboards = keyboards.OrderByDescending(x => x);
            var orderedDrives = drives.OrderBy(x => x);

            var maxSpendableMoney = -1;

            foreach (var keyboard in orderedKeyboards)
            {
                foreach (var drive in orderedDrives)
                {
                    var price = keyboard + drive;

                    if (price == b)
                    {
                        return price;
                    }
                    else if (price < b)
                    {
                        if (maxSpendableMoney < price)
                        {
                            maxSpendableMoney = price;
                        }
                    }
                }
            }

            return maxSpendableMoney;
        }
    }
}
