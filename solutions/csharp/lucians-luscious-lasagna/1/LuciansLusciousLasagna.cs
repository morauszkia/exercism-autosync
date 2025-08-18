class Lasagna
{
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    public int RemainingMinutesInOven(int elapsedMinutes)
    {
        return this.ExpectedMinutesInOven() - elapsedMinutes;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int elapsedMinutes)
    {
        return this.PreparationTimeInMinutes(layers) + elapsedMinutes;
    }
}
