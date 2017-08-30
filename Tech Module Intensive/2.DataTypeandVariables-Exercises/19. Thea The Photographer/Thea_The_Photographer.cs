using System;

namespace _19.Thea_The_Photographer
{
    public class Thea_The_Photographer
    {
        public static void Main()
        {
            long picturesCount = long.Parse(Console.ReadLine());

            long singlePictureFilterTimeSeconds = long.Parse(Console.ReadLine());

            long filterPercentage = long.Parse(Console.ReadLine());

            long singlePicturesUploadTimeSeconds = long.Parse(Console.ReadLine());

            long filterTimeSeconds = picturesCount * singlePictureFilterTimeSeconds;

            long picturesToUploadCount = (long)(Math.Ceiling(picturesCount * filterPercentage / 100d));

            long totalUploadTimeSeconds = picturesToUploadCount * singlePicturesUploadTimeSeconds;

            long totalTimeNeededSeconds = filterTimeSeconds + totalUploadTimeSeconds;

            TimeSpan projectTime = TimeSpan.FromSeconds(totalTimeNeededSeconds);

            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}",
                projectTime.Days,
                projectTime.Hours,
                projectTime.Minutes,
                projectTime.Seconds);
        }
    }
}