namespace Practise;

public class Program
{
    static void Main(string[] args)
    {
        Hosbital hosbital = new Hosbital();
        Appointment app1 = new Appointment(1, "Naciba Rasulova", "Dr.Emin", new DateTime(2024, 11, 1, 13, 00, 00), new DateTime(2024, 11, 1, 14, 00, 00));
        Appointment app2 = new Appointment(2, "Taravat Rasulova", "Dr.Gulnama", new DateTime(2024, 11, 1, 11, 00, 00), new DateTime(2024, 11, 1, 12, 00, 00));
        Appointment app3 = new Appointment(3, "Aslan Rasulov", "Dr.Emin", new DateTime(2024, 11, 1, 10, 00, 00), new DateTime(2024, 11, 1, 12, 00, 00));
        Appointment app4 = new Appointment(4, "Elxan Rasulov", "Dr.Habil", new DateTime(2024, 11, 1, 13, 00, 00), new DateTime(2024, 11, 1, 15, 00, 00));
        hosbital.AddAppointment(app1);
        hosbital.AddAppointment(app2);
        hosbital.AddAppointment(app3);
        hosbital.AddAppointment(app4);
        int write = int.Parse(Console.ReadLine());
        switch (write)
        {
            case 1:
                Console.WriteLine($"Appointmenti yarat!");
                Console.WriteLine($"Pasientin adi");
                string patient = Console.ReadLine();
                Console.WriteLine($"Doktorun adi");
                string doctor = Console.ReadLine();
                Console.WriteLine($"Baslangic tarix :");
                DateTime startDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine($"Son tarix:");
                DateTime endDate = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Appointment yaradıldı.");
                break;
            case 2:
                Console.Write("Bitirmek istediyin appointment nomresini daxil et: ");
                int no = int.Parse(Console.ReadLine());
                hosbital.EndAppointment(no);
                Console.WriteLine($"Appointmenti bitir!");
                break;
            case 3:
                Console.WriteLine($"Butun appointmentlere bax!");
                foreach (var hosb in hosbital.GetAllAppointments())
                {
                    Console.WriteLine($"No: {hosb.No}, Pasiyent: {hosb.Patient}, Doktor: {hosb.Doctor}, Bashlangic: {hosb.StartDate}, Bitish: {hosb.EndDate}");
                }
                break;
               
            case 4:
                Console.WriteLine($"Bu hefteki appointmentlere bax!");
                foreach (var hosb in hosbital.GetWeeklyAppointment())
                {
                    Console.WriteLine($"No: {hosb.No}, Pasiyent: {hosb.Patient}, Doktor: {hosb.Doctor}, Bashlangic: {hosb.StartDate}, Bitish: {hosb.EndDate}");
                }
                break;
            case 5:
                Console.WriteLine($"Bugunki appointmentlere bax!");
                foreach (var hosb in hosbital.GetTodayAppointments())
                {
                    Console.WriteLine($"No: {hosb.No}, Pasiyent: {hosb.Patient}, Doktor: {hosb.Doctor}, Bashlangic: {hosb.StartDate}, Bitish: {hosb.EndDate}");
                }
                break;
            case 6:
                Console.WriteLine($"Bitmemish appointmentlere bax!");
                foreach (var hosb in hosbital.GetAllContinuingAppintments())
                {
                    Console.WriteLine($"No: {hosb.No}, Pasiyent: {hosb.Patient}, Doktor: {hosb.Doctor}, Bashlangic: {hosb.StartDate}, Bitish: {hosb.EndDate}");
                }
                break;
            case 7:
                Console.WriteLine($"Menudan chix!");
                break;
            default:
                Console.WriteLine($"Duzgun eded daxil edin!");
                break;
        }


    }
}
