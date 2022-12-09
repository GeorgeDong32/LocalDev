/*test write
var data = new string[4] { "a", "b", "c", "d" };
var time = DateTime.Now;
var path = @".\test.csv";
File.AppendAllText(path, $"{data[0]},{data[1]},{data[2]},{data[3]},{time}", System.Text.Encoding.UTF8);
/*test read*/
var filePath = @".\test.csv";
var dataLines = File.ReadLines(filePath);
foreach (var line in dataLines)
{
    var data = line.Split(',');
    Console.WriteLine(data[0]);
    Console.WriteLine(data[1]);
    Console.WriteLine(data[2]);
    Console.WriteLine(data[3]);
    var time = DateTime.Parse(data[4]);
    Console.WriteLine(time);
}