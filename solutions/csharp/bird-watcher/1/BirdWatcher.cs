using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
       int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeek;
    }

    public int Today()
    {
        return birdsPerDay[birdsPerDay.Length-1];
    }

    public void IncrementTodaysCount()
    {
       birdsPerDay[birdsPerDay.Length-1]++;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.Exists(birdsPerDay, element => element == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
		int res = 0;
        for(int i = 0; i < numberOfDays; i++)
		{
			res += birdsPerDay[i];
		}
		
		return res;
    }

    public int BusyDays()
    {
        int res = 0;
        for(int i = 0; i < birdsPerDay.Length; i++)
		{
			if (birdsPerDay[i] >= 5)
			   res += 1;
		}
		return res;
    }
}