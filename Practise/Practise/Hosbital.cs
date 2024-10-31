namespace Practise;

public class Hosbital
{
    public List<Appointment> Appointments= new List<Appointment>();
    

    public void AddAppointment(Appointment appointment)
    {
        Appointments.Add(appointment);
    }
    public void EndAppointment(int no)
    {
        Appointments.FindAll(a => a.No == no).ForEach(a =>
        {
            Console.WriteLine(a.EndDate);
        });
    }
    public Appointment GetAppointment(int no)
    {
        return Appointments.Find(a => a.No == no);
    }
    public List<Appointment> GetAllAppointments()
    {
        return Appointments;

    }
    public List<Appointment> GetWeeklyAppointment()
    {
        return Appointments.FindAll(a => (DateTime.Now - a.EndDate).TotalDays < 8);
    }
    public List<Appointment> GetTodayAppointments()
        {
        return Appointments.FindAll(a => (DateTime.Now.Date == a.StartDate.Date));
        }
    public List<Appointment> GetAllContinuingAppintments()
    {
        return Appointments.FindAll(a => a.StartDate <= DateTime.Now && a.EndDate >= DateTime.Now);
    }
}
