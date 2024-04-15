class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method

    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // => 40

    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int x)
    {
        return 40 - x;
    }

    // => 10


    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int y)
    {
        return y * 2;
    }
    // => 4

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int y, int a)
    {
        return y * 2 + a;
    }
    // => 26
}
