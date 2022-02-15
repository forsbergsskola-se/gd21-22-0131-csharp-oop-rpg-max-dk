class Program
{
    static void Main()
    {
        Console.WriteLine($"Lerp from 100 to 200 with t(0):{SuperMath.Lerp(100,200,0)}");
    }
}
static class SuperMath
{
    public static float Lerp(float from, float to, float t)
    {
        return from + (to - from) * t;
    }
}