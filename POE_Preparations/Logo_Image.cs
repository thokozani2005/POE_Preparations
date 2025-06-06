﻿using System.IO;
using System;
using System.Drawing;


namespace POE_Preparations
{
    public class Logo_Image
    {
        public Logo_Image()
        {
            string logo_path = AppDomain.CurrentDomain.BaseDirectory;

            // Replace "bin\\Debug\\" with an empty string
            string new_path = logo_path.Replace("bin\\Debug\\", "");

            // Combine paths
            string full_location = Path.Combine(new_path, "OurLogo.png");

            // Check if the file exists
            if (!File.Exists(full_location))
            {
                Console.WriteLine("Error: Image file not found at " + full_location);
                return;
            }

            // Load and resize the image
            Bitmap image = new Bitmap(full_location);
            image = new Bitmap(image, new Size(100, 100));

            //Changing the color
            Console.ForegroundColor = ConsoleColor.Blue;


            // Convert to ASCII and print
            for (int height = 0; height < image.Height; height++)
            {
                for (int width = 0; width < image.Width; width++)
                {
                    Color pixelColor = image.GetPixel(width, height);
                    int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    char asciiChar = gray > 200 ? '.' : gray > 150 ? '*' : gray > 100 ? 'o' : gray > 50 ? '#' : '@';
                    Console.Write(asciiChar);
                }
                Console.WriteLine(); // Move to the next row
            }

            Console.WriteLine();

        }
    }
}