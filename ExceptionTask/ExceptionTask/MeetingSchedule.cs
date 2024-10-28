namespace ExceptionTask;

internal class MeetingSchedule
{
    private Meeting[] meetings;
    private int count;
    public MeetingSchedule(int capacity)
    {
        meetings = new Meeting[capacity];
        count = 0;

    }
    public void SetMeeting(DateTime fromDate, DateTime toDate, string fullName)
    {
        for (int i = 0; i <count; i++)
        {
            if ((fromDate < meetings[i].ToDate && toDate > meetings[i].FromDate))
            {
                throw new ReservedDateIntervalException();
            }
            
        }
        if (fromDate > toDate)
        { 
        
            throw new WrongDateIntervalException();
        
        }
        if (count < meetings.Length)
        {
            meetings[count] = new Meeting(fromDate, toDate, fullName);
            count++;
        }
        else 
        {
            Console.WriteLine($"Gorush capacity-miz dolub yeni gorush elave ede bilmirik!!!");
        }
    
    }
}
