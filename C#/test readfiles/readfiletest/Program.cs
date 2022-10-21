string userName = Environment.UserName;

string _appdataPath = $"C:\\Users\\{userName}\\AppData\\Local";

Console.WriteLine(_appdataPath);

string LocalMKPath = Path.Combine(_appdataPath, "GoodPass", "MKconfig.txt");

var LocalMKHash = File.ReadAllText(LocalMKPath);

Console.WriteLine(LocalMKHash);