int[] grades = { 59, 82, 70, 56, 92, 98, 85 };

IEnumerable<int> lowerGrades =
    grades.OrderByDescending(g => g);

Console.WriteLine("All grades except the top three are:");
foreach (int grade in lowerGrades)
{
    Console.WriteLine(grade);
}

Console.WriteLine("The top three grades are:");

lowerGrades = lowerGrades.Skip(3);
foreach (int grade in lowerGrades)
{
    Console.WriteLine(grade);
}