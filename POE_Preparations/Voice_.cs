using System.IO;
using System.Media;
using System;

namespace POE_Preparations
{
    // created a class seperately to store and play the voice recording
    public class Voice_
    {
        //a built in constructor
        public Voice_()
        {
            //getting the full location
            string full_location = AppDomain.CurrentDomain.BaseDirectory;

            Console.WriteLine(full_location);

            string new_path = full_location.Replace("bin\\Debug", "");

            try
            {
                string full_path = Path.Combine(new_path, "Welcome.wav");
                using (SoundPlayer myplayer = new SoundPlayer(full_path))
                {
                    myplayer.PlaySync();
                }

            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
            }

        }
    }
}