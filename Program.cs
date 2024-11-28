namespace KH_Sikkerhet;

class Program
{
    static void Main(string[] args)
    {
        HashingExample hashingExample = new HashingExample();

        Console.WriteLine("Enter your username:");
        string? mockUser = Console.ReadLine();
        Console.WriteLine("Enter your password:");
        string? mockPassword = Console.ReadLine();
        Console.WriteLine($"Hello {mockUser}.");

        // we can hash the password we recieve by the user by using our ComputeSHA256 method
        string hashed = hashingExample.ComputeSHA256Hash(mockPassword);
        Console.WriteLine($"Hello {mockUser}. Your password is: {hashed}");
    }
}
