var teststr = "Test";
var teststr2 = "Test2";
var teststr3 = "Test3";
var tarstr = "test";
if (teststr.ToLower().Contains(tarstr.ToLower()))
{
    Console.WriteLine("Teststr contains tarstr");
}
if (teststr2.Contains(tarstr))
{
    Console.WriteLine("Teststr2 contains tarstr");
}
if (teststr3.Contains(tarstr))
{
    Console.WriteLine("Teststr3 contains tarstr");
}