using System;


// Dates.cs
/* Date class with a month, day, and year */
// VeryAble 9-22-2017

class Dates
{
    public int month { get; set; } // Instance variable
    public int day { get; set; } // Instance variable
    public int year { get; set; } // Instance variable
    public string DisplayDate; // variable

    // Account constructor that receives three parameters
    public Dates(int month, int day, int year)
    {
        DisplayDate = $"{month}/{day}/{year}";
    }

    // Name property
    public int Month
    {
        get
        {
            return month;
        }

        private set // Can only be used within the class
        {
                month = value;
        }
    }

    public int Day
    {
        get
        {
            return day;
        }

        private set // Can only be used within the class
        {
                day = value;
        }
    }

    // Monthly salary turned yearly salary property with validation 
    public int Year
    {
        get
        {
            return year;
        }

        private set // Can be used only within the class
        {
                year = value;
        }
    }
    // Thanks for looking
}
