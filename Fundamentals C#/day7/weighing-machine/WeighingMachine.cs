using System;

class WeighingMachine
{
    public int Precision { get; }
    public double TareAdjustment { get; set; } = 5.0;
    private double weight;

    public double Weight
    {
        get => weight;
        set
        {
            if(value<0) 
                throw new ArgumentOutOfRangeException(nameof(value), "No valid weight.");
            else
                weight = value;
        }
    }

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    public string DisplayWeight
    {
        get => $"{Math.Round(Weight - TareAdjustment, Precision).ToString($"F{Precision}")} kg"; 
    }
}
    
