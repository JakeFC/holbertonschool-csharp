using System;
using System.Collections.Generic;

    class List
    {
        // returns a sorted list of all elements present in one or the other list but not both
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            var newList = new List<int> {};
            foreach (int a in list1)
            {
                if (!list2.Contains(a))
                    newList.Add(a);
            }
            foreach (int b in list2)
            {
                if (!list1.Contains(b))
                    newList.Add(b);
            }
            newList.Sort();
            return newList;
        }
    }