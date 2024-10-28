namespace ExceptionTask;

internal class Meeting
{
    public DateTime FromDate { get; set; }
    public DateTime ToDate { get; set; }
    public string FullName { get; set; }
    public Meeting(DateTime fromDate, DateTime toDate, string fullName)
    {
        this.FromDate = fromDate;
        this.ToDate = toDate;
        this.FullName = fullName;

    }
}
