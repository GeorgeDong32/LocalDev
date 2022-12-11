using GoodPass.Services;

var crypt = new GoodPassCryptographicServices();
var testStr = "TestGoodPassSES";
Console.WriteLine($"Test string: {testStr}");
var encStr = crypt.EncryptStr(testStr);
Console.WriteLine($"Encrypted string: {encStr}");
var decStr = crypt.DecryptStr(encStr);
Console.WriteLine($"Decrypted string: {decStr}");
Console.WriteLine($"Test string == Decrypted string: {testStr == decStr}");