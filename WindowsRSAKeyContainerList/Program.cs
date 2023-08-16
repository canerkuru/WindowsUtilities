using System.Text;

var files = Directory.GetFiles(@"C:\ProgramData\Microsoft\Crypto\RSA\MachineKeys\");
var errors = new List<string>();

foreach (var f in files)
{
    try
    {
        var bytes = File.ReadAllBytes(f);
        var containerName = Encoding.ASCII.GetString(bytes, 40, bytes[8] - 1);

        Console.WriteLine(containerName);
    }
    catch (Exception e)
    {
        errors.Add(e.Message);
    }
}

if (errors.Any())
{
    Console.WriteLine("\n\nErrors:");

    foreach (var e in errors)
    {
        Console.WriteLine(e);
    }
}

Console.Read();