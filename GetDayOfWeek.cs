string GetCurrentDayOfWeek()
{
    DateTime nowDt = DateTime.Now;

    if (nowDt.DayOfWeek == DayOfWeek.Monday)
        return "월";
    else if (nowDt.DayOfWeek == DayOfWeek.Tuesday)
        return "화";
    else if (nowDt.DayOfWeek == DayOfWeek.Wednesday)
        return "수";
    else if (nowDt.DayOfWeek == DayOfWeek.Thursday)
        return "목";
    else if (nowDt.DayOfWeek == DayOfWeek.Friday)
        return "금";
    else if (nowDt.DayOfWeek == DayOfWeek.Saturday)
        return "토";
    else if (nowDt.DayOfWeek == DayOfWeek.Sunday)
        return "일";
    else
        return "";
}

int GetLastDayofMonth()
{
    var myDate = new DateTime(1980,8,3);
    var lastDayOfMonth = new DateTime(myDate.Year, myDate.Month, DateTime.DaysInMonth(myDate.Year, myDate.Month));
}
