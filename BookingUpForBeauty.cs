static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
        DateTime.TryParse(appointmentDateDescription, out DateTime appointmentDate);
        return appointmentDate;
    }

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;

    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate.ToString()}.";

    public static DateTime AnniversaryDate() => new DateTime(2025, 9, 15, 0, 0, 0);
}
