using System;
using System.Linq;

class BirdCount
{
    private int[] birdsPerDay;
   
    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] birdCountLastWeek = {0,2,5,3,7,8,4};
        return birdCountLastWeek;
    }

    public int Today()
    {
        int lastBirbCount = birdsPerDay.Length-1;
        return birdsPerDay[lastBirbCount];
    } 

    public void IncrementTodaysCount()
    {
        birdsPerDay[birdsPerDay.Length - 1]++;
    }

    public bool HasDayWithoutBirds()
    {
       return birdsPerDay.Contains(0)? true : false;
        
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int birdCount = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            birdCount += birdsPerDay[i];
        }
        return birdCount;
    }

    public int BusyDays()
    {
        int busyDays = 0;
        foreach (int birdNumber in birdsPerDay)
        {
            if (birdNumber >= 5)
                busyDays++;
        }
        return busyDays;
    }
}
