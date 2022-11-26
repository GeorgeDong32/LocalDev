string userName = Environment.UserName;

string _appdataPath = $"C:\\Users\\{userName}\\AppData\\Local";

Console.WriteLine(_appdataPath);

string LocalMKPath = Path.Combine(_appdataPath, "GoodPass", "MKconfig.txt");

var LocalMKHash = "";
var ts = File.ReadAllTextAsync(LocalMKPath);

try
{
    LocalMKHash = File.ReadAllText(LocalMKPath);
}
catch (System.IO.DirectoryNotFoundException)
{
    LocalMKHash = "Not found";
}
catch (System.IO.FileNotFoundException)
{
    LocalMKHash = "Not found";
}
finally
{
    if (LocalMKHash == "")
    {
        Console.WriteLine("Empty");
        Console.WriteLine(ts.Result);
    }
    else
    {
        Console.WriteLine(LocalMKHash);
        Console.WriteLine(ts.Result);
    }
    if (ts.Result == String.Empty)
    {
        Console.WriteLine("Empty");
    }
    else
    {
        Console.WriteLine("Not empty");
    }
}