using System;

namespace _19.TheaThePhotographer_Secondway
{
    public class TheaThePhotographer_Secondway
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

            TimeSpan totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);

            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
