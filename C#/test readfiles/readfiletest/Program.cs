string userName = Environment.UserName;

string _appdataPath = $"C:\\Users\\{userName}\\AppData\\Local";

Console.WriteLine(_appdataPath);

string LocalMKPath = Path.Combine(_appdataPath, "GoodPass", "MKconfig.txt");

var LocalMKHash = "";

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
        Console.WriteLine("Empty");
    else
    {
        Console.WriteLine(LocalMKHash);
    }

}