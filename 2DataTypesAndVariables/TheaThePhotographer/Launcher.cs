using System;

namespace TheaThePhotographer
{
    public class Launcher
    {
        public static void Main()
        {
            int totalPics = int.Parse(Console.ReadLine());
            int filterTimePerPic = int.Parse(Console.ReadLine());
            int usefulPicsPercent = int.Parse(Console.ReadLine());
            int uploadTimePerPic = int.Parse(Console.ReadLine());

            long usefulPics = (long)Math.Ceiling(totalPics * (usefulPicsPercent / 100.0));
            long totalFilterTime = (long)totalPics * filterTimePerPic;
            long uploadUsefulTime = usefulPics * uploadTimePerPic;
            long totalTime = uploadUsefulTime + totalFilterTime;

            TimeSpan processTime = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", processTime.Days, processTime.Hours, processTime.Minutes, processTime.Seconds);
        }
    }
}
