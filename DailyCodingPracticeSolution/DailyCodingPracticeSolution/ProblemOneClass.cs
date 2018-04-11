using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingPracticeSolution
{
   public class ProblemOneClass
   {
      public bool DoesListSumToPassedInInteger(int[] numberList, int returnNumber)
      {
         for(int i = 0; i < numberList.Length; i++)
         {
            for(int j = 0; j < numberList.Length; j++)
            {
               if(numberList[i] + numberList[j] == returnNumber)
               return true;
            }
         }

         return false;
      }
   }
}
