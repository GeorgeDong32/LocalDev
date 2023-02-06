var time = new DateTime(2022, 12, 2, 23, 32, 59);
var timePatch1 = (char)(48 + time.Month + time.Minute);
var timePatch2 = (char)(48 + time.Hour + time.Day);
var timePatch = timePatch1.ToString() + timePatch2.ToString();
Console.WriteLine(timePatch);
Console.WriteLine((int)timePatch1);
Console.WriteLine((int)timePatch2);
Console.WriteLine((char)126);