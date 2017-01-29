using System;

namespace TheaThePhotographer
{
    public class TheaThePhotographer
    {
        public static void Main()
        {
            int picturesCount = int.Parse(Console.ReadLine());
            int filterTimePerPic = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTimePerPic = int.Parse(Console.ReadLine());

            double filteredPics = Math.Ceiling(picturesCount * ((double)filterFactor / 100));
            long filterTime = (long)picturesCount * filterTimePerPic;
            long uploadTime = (long)filteredPics * uploadTimePerPic;
            long totalTime = filterTime + uploadTime;

            TimeSpan resultTime = TimeSpan.FromSeconds(totalTime);

            Console.WriteLine($"{resultTime.Days:D1}:{resultTime.Hours:D2}:{resultTime.Minutes:D2}:{resultTime.Seconds:D2}");
        }
    }
}
