using BasicCore;

internal class Program
{
    private static void Main(string[] args)
    {
        FlipCoin flipCoin = new FlipCoin();
        flipCoin.Main(args);

        LeapYear leapYear = new LeapYear();
        leapYear.Main(args);

        Powerof2 powerof2 = new Powerof2();
        powerof2.Main(args);

        HarmonicNumber harmonicNumber = new HarmonicNumber();
        harmonicNumber.FindHarmonicNumber();

        Factors factors = new Factors();
        factors.CalculateFactor();

        QuotientRemainder quotientRemainder = new QuotientRemainder();
        quotientRemainder.Main(args);

        Swapping swapping = new Swapping();
        swapping.Main(args);

    }
}