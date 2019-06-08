using System;
using System.IO;

namespace _4._Copy_Binary_File
{
    class Program
    {
        static void Main()
        {
            using (var reader = new FileStream(@"../../../Resources/copyMe.png", FileMode.Open))
            {
                using (var writer = new FileStream(@"../../../Resources/copied.png", FileMode.Create))
                {
                    while (true)
                    {
                        var buffer = new byte[4096];

                        var byteSize = reader.Read(buffer, 0, buffer.Length);

                        if (byteSize < 1)
                        {
                            break;
                        }

                        writer.Write(buffer, 0, byteSize);
                    }
                }
            }
        }
    }
}
