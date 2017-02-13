using System;

class PriceChangeAlert
{
    public static void Main()
    {
        int numOfPrices = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double currentPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numOfPrices - 1; i++)
        {
            double nextPrice = double.Parse(Console.ReadLine());
            double diff = GetDifference(currentPrice, nextPrice);
            bool isSignificantDiff = CheckSignificance(diff, threshold);
            string message = GetPriceEvaluation(nextPrice, currentPrice, diff, isSignificantDiff);
            Console.WriteLine(message);
            currentPrice = nextPrice;
        }
    }

    public static string GetPriceEvaluation(double currentPrice, double previousPrice, double diffCurrentPrevious, bool isSignificant)

    {
        string messageText = "";

        if (diffCurrentPrevious == 0)
        {
            messageText = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificant)
        {
            messageText = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, (diffCurrentPrevious * 100));
        }
        else if (isSignificant && (diffCurrentPrevious > 0))
        {
            messageText = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, (diffCurrentPrevious * 100));
        }
        else if (isSignificant && (diffCurrentPrevious < 0))
        {
            messageText = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, (diffCurrentPrevious * 100));
        }

        return messageText;
    }
    public static bool CheckSignificance(double difference, double thresholdValue)
    {
        if (Math.Abs(difference) >= thresholdValue)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static double GetDifference(double currentValue, double nextValue)
    {
        double result = (nextValue - currentValue) / currentValue;
        return result;
    }
}
