namespace ExceptionTask;

internal class ReservedDateIntervalException:Exception
{
    public ReservedDateIntervalException():base("Qeyd edilen tarix araliginda basqa gorus teyin olunub."){}
    public ReservedDateIntervalException(string message) : base(message) { }

}
internal class WrongDateIntervalException : Exception
{
    public WrongDateIntervalException() : base("Baslangic tarix bitis tarixinden daha erken olmalidir.") { }
    public WrongDateIntervalException(string message) : base(message) { }

}
