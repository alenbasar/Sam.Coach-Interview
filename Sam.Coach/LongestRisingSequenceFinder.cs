using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Sam.Coach
{
    public class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
       {
           var numbersArr = numbers.ToArray();
           List<int> tempLongestRisingSequence = new List<int>();
           List<int> longestRisingSequence = new List<int>();
           int highestCount = 0;
           int currentMax;
           for (int i = 0; i < numbersArr.Length; i++)
           {
               currentMax = int.MinValue;
               for (int j = i + 1; j < numbersArr.Length; j++)
               {
                   if (numbersArr[j] > currentMax)
                   {
                       tempLongestRisingSequence.Add(numbersArr[j]);
                       currentMax = numbersArr[j];
                   }
               }
               if (highestCount < tempLongestRisingSequence.Count)
               {
                   highestCount = tempLongestRisingSequence.Count;
                   longestRisingSequence = new List<int>(tempLongestRisingSequence);
               }
               tempLongestRisingSequence.Clear();
           }
           return longestRisingSequence as IEnumerable<int>;
       });
    }
}
