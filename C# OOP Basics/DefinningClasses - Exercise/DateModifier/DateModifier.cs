﻿using System;

public class DateModifier
{
   public static int CalculateDifference(string firstDate, string secondDate)
    {
        var difference = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);

        return Math.Abs(difference.Days);
    }
}