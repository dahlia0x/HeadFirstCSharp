using System;
using System.Collections.Generic;
using Cards;

namespace SortCard
{
    public class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value)
                return 1;
            else if (x.Value < y.Value)
                return -1;
            else
                return 0;
        }
    }
}
