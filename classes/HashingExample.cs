using System;
using System.Security.Cryptography;
using System.Text;

public class HashingExample
{
    // we can create a string method that computes a SHA256 hashing algorithm
    /// <summary>
    /// One way hash of any given string.
    /// </summary>
    /// <param name="rawData">plaintext input</param>
    /// <returns>a new SHA256 HASH</returns>
    public string ComputeSHA256Hash(string rawData)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // create a new hash, by using a byte array is it's input
            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(rawData));
            // build a new string, using the StringBuilder class.
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte bytes in hash)
            {
                // add the "x2" as an "argument" to convert the bytearray to hexadecimal
                stringBuilder.Append(bytes.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}