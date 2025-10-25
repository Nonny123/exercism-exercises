using System;

static class AssemblyLine
{

    
    public static double SuccessRate(int speed)
    {
        return GetSuccessRate(speed)/100;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        return GetProductionRatePerHour(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
		var items = GetProductionRatePerHour(speed)/60;
		
		var itemsInt = (int)Math.Floor(items);
		
        return itemsInt;
    }

    private static double GetProductionRatePerHour(int speed)
    {
        double rate = GetSuccessRate(speed);
        return (speed * 221 * rate)/100;
    }


    private static double GetSuccessRate(int speed)
    {
        double rate = 0.00;
        switch (speed)
        {
            case 0:
                rate = 0;
                break;
            case int n when (n >= 1 && n <= 4):
                rate = 100;
                break;
            case int n when (n >= 5 && n <= 8):
                rate = 90;
                break;
            case 9:
                rate = 80;
                break;
            case 10:
                rate = 77;
                break;
            default:
                Console.WriteLine("The number is not within the given range.");
                break;  
        }

        return rate;
    }
}
