using System;
using System.Globalization;

static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
		DateTime result;
		
		if (DateTime.TryParseExact(appointmentDateDescription, "MMMM d, yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
		{
    		return result;
		}
        if (DateTime.TryParseExact(appointmentDateDescription, "M/d/yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
		{
           return result;
		}
		if (DateTime.TryParseExact(appointmentDateDescription, "dddd, MMMM d, yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
		{
     
  			return result; 
		}
		else
		{
    		return new DateTime(0001, 00, 0, 0, 0, 0);
		}
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
        return appointmentDate < DateTime.Now ? true : false;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        return appointmentDate.Hour >= 12 && appointmentDate.Hour < 18 ? true : false;
    }

    public static string Description(DateTime appointmentDate)
    {
        string check = string.Empty;
		
		switch (appointmentDate.Hour)
		{
    		case var hour when hour >= 0 && hour < 12:
       		 	check = "AM";
       		 	break;
    		case var hour when hour >= 12 && hour < 24:
        		check = "PM";
        		break;
    		default:
        		check = "Invalid hour";
        		break;
		}
        return $"You have an appointment on {appointmentDate.ToString("M/d/yyyy")} {appointmentDate.ToString("h:mm:ss tt")}.";
    }

    public static DateTime AnniversaryDate()
    {
        return new DateTime(2023, 9, 15, 0, 0, 0);
    }
}
