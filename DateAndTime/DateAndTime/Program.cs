/// <summary>
/// DateTime - represents a point in a timeline
/// </summary>

DateTime dateTime = new DateTime();
Console.WriteLine(dateTime);

// Year, month, day
dateTime = new DateTime(2016, 7, 15);
Console.WriteLine(dateTime);

// Year, month, day, hours, minutes, seconds
dateTime = new DateTime(2016, 7, 15, 3, 15, 0);
Console.WriteLine(dateTime);

// Now
dateTime = DateTime.Now;
Console.WriteLine(dateTime);

// Today, Month, Year, Hour, Minute, Second, Millisecond
dateTime = DateTime.Today;
Console.WriteLine(dateTime);

// Ticks - 18 digits number
long ticks = dateTime.Ticks;
Console.WriteLine(ticks);

// Day Of Week
Console.WriteLine(dateTime.DayOfWeek);
// Day of Year
Console.WriteLine(dateTime.DayOfYear);
// Month of Year
Console.WriteLine(dateTime.Month);
// Hour of the Day
Console.WriteLine(dateTime.Hour);
// Minute of the Day
Console.WriteLine(dateTime.Minute);
// Second of the Day
Console.WriteLine(dateTime.Second);
// Millisecond of the Day
Console.WriteLine(dateTime.Millisecond);

// Date
Console.WriteLine(dateTime.Date);

///
/// Methods
///

// AddDays(), AddMonths(), AddYears(), AddHours(), AddMinutes(), AddSeconds(), AddMilliseconds(), AddTicks()
// - they all return new instance of the time, we are actually adding TimeSpan

// UsDaylightSavingTime() - returns if the instance of the DateTime is in summer or winter time
Console.WriteLine(dateTime.IsDaylightSavingTime());

///
/// Static Methods
///

// DaysInMonth()
Console.WriteLine(DateTime.DaysInMonth(dateTime.Year, dateTime.Month));

// IsLeapYear()
Console.WriteLine(DateTime.IsLeapYear(dateTime.Year));

///
/// Parse and TryParse
///

DateTime date = DateTime.Parse(Console.ReadLine());
Console.WriteLine(date);

// Patterns
string pattern = "dd.M.yyyy";
DateTime parsedDate = DateTime.ParseExact(Console.ReadLine(), pattern, null);
Console.WriteLine(parsedDate);

Console.WriteLine(dateTime.ToString("MMMM, dddd, yyyy"));

// ToShortDateString(), ToShortTimeString(), ToLongDateString(), ToLongTimeString()
Console.WriteLine(dateTime.ToShortDateString());

///
/// UTC and Kind - Property
///

Console.WriteLine("UTC Now: " + DateTime.UtcNow);

// Local
dateTime = DateTime.Now;
Console.WriteLine("Kind: " + dateTime.Kind);

// Kind Date Time
DateTime kindDateTime = new DateTime(1991, 10, 21, 8, 20, 50, DateTimeKind.Utc);
Console.WriteLine(dateTime.ToUniversalTime());

/// <sumary>
/// TimeSpan - represents a time interval between two time points on a timeline
/// </sumary>

DateTime today = DateTime.Now;
Console.WriteLine(today.TimeOfDay); // TimeSpan - time between 00:00:00 that day and time stored in today.Now
DateTime yesterday = today.AddDays(-1);

TimeSpan day = today - yesterday;

// Properties
// Days, Hours, Minutes, Seconds, Milliseconds, Ticks
Console.WriteLine(day.Days);
Console.WriteLine(day.TotalDays);

Console.WriteLine(day.Hours);
Console.WriteLine(day.TotalHours);

// and so on...

// Methods - Constructors
TimeSpan ts = new TimeSpan(24, 0, 0);
TimeSpan ts1 = new TimeSpan(60, 12, 0, 0);

TimeSpan ts2 = TimeSpan.FromHours(24);
Console.WriteLine(ts2.Days);

DateTime birthday = new DateTime(1991, 1, 6, 0, 0, 0);
TimeSpan lifeLength = DateTime.Now - birthday;
Console.WriteLine(lifeLength.TotalSeconds);
Console.WriteLine("You are {0} years and {1} days old.", lifeLength.TotalDays / 365.25, lifeLength.TotalDays % 12);
Console.WriteLine("That is {0} days and {1} hours.", lifeLength.TotalDays, lifeLength.TotalHours);
