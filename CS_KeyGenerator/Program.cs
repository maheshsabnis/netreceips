using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        using (var rNGCryptoServiceProvider = new RSACryptoServiceProvider())
        {
            var SigningSecretKey = new byte[64];
            rNGCryptoServiceProvider.TrySignData(SigningSecretKey);
            Console.WriteLine($"Secret Key is {Convert.ToBase64String(SigningSecretKey)}");
        }
        Console.ReadLine();
    }

}