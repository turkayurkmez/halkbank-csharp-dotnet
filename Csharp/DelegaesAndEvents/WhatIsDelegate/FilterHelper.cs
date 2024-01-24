using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsDelegate
{
    public static class FilterHelper
    {
        //public delegate bool Criteria(int number);




        public static int[] Filter(int[] numbersParameter, Func<int, bool> filterCriteria)
        {
            List<int> result = new List<int>();

            foreach (int i in numbersParameter)
            {
                if (filterCriteria(i))
                {
                    result.Add(i);

                }
            }
            return result.ToArray();
        }
    }
}
