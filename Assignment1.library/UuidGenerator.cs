using System;

namespace Assignment1.library
{
    public class UuidGenerator
    {
        public string GenerateUuidV4()
        {
            // Create a new Random object
            Random random = new Random();

            // Create an array to hold 16 bytes
            byte[] data = new byte[16];

            // Fill the array with random numbers
            random.NextBytes(data);

            // Set the version bits (version 4)
            data[6] = (byte)(data[6] & 0x0f | 0x40);

            // Set the variant bits
            data[8] = (byte)(data[8] & 0x3f | 0x80);

            // Convert to string with dashes
            string result = "";
            for (int i = 0; i < 16; i++)
            {
                if (i == 4 || i == 6 || i == 8 || i == 10)
                    result += "-";
                result += data[i].ToString("x2");
            }

            return result;
        }
    }
}