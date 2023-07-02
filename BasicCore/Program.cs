using BasicCore;

internal class Program
{
    private static void Main(string[] args)
    {
        FlipCoin flipCoin = new FlipCoin();
        flipCoin.Main(args);

        LeapYear leapYear = new LeapYear();
        leapYear.Main(args);
    }
}