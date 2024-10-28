namespace ExceptionTask;

internal class Program
{
    static void Main(string[] args)
    {
        MeetingSchedule schedule = new MeetingSchedule(10);
        try
        {
            schedule.SetMeeting(new DateTime(2024, 11, 04, 18, 0, 0), new DateTime(2024, 11, 04, 22, 0, 0), "Naciba Rasulova");
            schedule.SetMeeting(new DateTime(2024, 11, 04, 20, 0, 0), new DateTime(2024, 11, 04, 23, 0, 0), "Taravat Rasulova");
        }
        catch (ReservedDateIntervalException)
        {
            Console.WriteLine("Tarix intervalinda problem var,saatlar ust-uste dusur");
        }
        catch (WrongDateIntervalException)
        {
            Console.WriteLine("Tarix sehvdir!");
        }
    }
}
