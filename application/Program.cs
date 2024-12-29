namespace application;

class Program
{
    static void Main(string[] args)
    {
        DetectOsPlatform osPlatform = new DetectOsPlatform();

        if (osPlatform.IsMacOS())
        {
            Console.WriteLine("We're on macOS!");
        }
        else if (osPlatform.IsLinux())
        {
            Console.WriteLine("We're on Linux");
        }
        else if (osPlatform.IsWindows())
        {
            Console.WriteLine("We're on Windows");
        }
    }
}
