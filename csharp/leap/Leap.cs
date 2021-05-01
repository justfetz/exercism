using System;

public static class Leap
{
    /*
    on every year that is evenly divisible by 4
    except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400
    */
    public static bool IsLeapYear(int year)
    {
        if (year % 4 == 0 && year % 400 == 0) 
        {
            return true;
        } else
        {
            return year % 4 == 0 && year % 100 != 0;
        }
        throw new NotImplementedException("You need to implement this function.");
    }
}