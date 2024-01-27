namespace task7;

public class Math
{
    public double Abs(double value)
    {
        if (value < 0) return value * (-1);
        else return value;
    }
    public float Abs(float value)
    {
        if (value < 0) return value * (-1);
        else return value;
    }
    public int Abs(int value)
    {
        if (value < 0) return value * (-1);
        else return value;
    }
    public double Pow(double x, double y)
    {
        double s = 1;
        for (int i = 0; i < y; i++)
        {
            s *= x;
        }
        return s;
    }
    public double Sqrt(double d)
    {
        for (int i = 0; i <= d; i++)
        {
            if (i * i == d) return i;
        }
        return 0;
    }
    public int Max(int val1, int val2)
    {
        if (val1 > val2) return val1;
        else return val2;
    }
    public int Min(int val1, int val2)
    {
        if (val1 < val2) return val1;
        else return val2;
    }
    const double PI = 3.14;
    const double E = 2.71;
}
