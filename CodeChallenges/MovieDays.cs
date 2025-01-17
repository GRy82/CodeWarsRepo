﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChallenges
{
    //Lily likes to play games with integers. She has created a new game where she determines the difference between a number and its reverse.
    //  For instance, given the number 120, its reverse is 21. Their difference is 99. The number 12 reversed is 21, and their difference is 9.
    // She decides to apply her game to decision making.She will look at a numbered range of days and will only go to a movie on a beautiful day.
    // Given a range of numbered days, [i,... j] and a number k, determine the number of days in the range that are beautiful.Beautiful numbers are
    // defined as numbers where i - reverse(i) is evenly divisible by k.If a day's value is a beautiful number, it is a beautiful day. Return the
    // number of beautiful days in the range. Suffices to say that Lily is a weirdo.

    public class MovieDays
    {
        public static int BeautifulDays(int rangeStart, int rangeEnd, int divisor)
        {
            int beautifulDaysQty = 0;
            for(int i = rangeStart; i <= rangeEnd; i++)
                if (Math.Abs(i - Reverse(i)) % divisor == 0) beautifulDaysQty++;

            return beautifulDaysQty;
        }

        public static int Reverse(int number)
        {
             var reverse = number.ToString().ToCharArray().Reverse();
            return Convert.ToInt32(new string(reverse.ToArray()));
        }
    }
}
