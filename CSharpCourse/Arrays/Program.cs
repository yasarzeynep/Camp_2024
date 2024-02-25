
string[] students = new string[3];
students[0] = "Engin";
students[1] = "Derin";
students[2] = "Salih";

foreach (var student in students)
{
    Console.WriteLine(student);
}

#region çok boyutlu array
string[,] regions = new string[3, 2]
{
{ "İstanbul", "Edirne"},
{ "Ankara", "Niğde"},
{ "İzmir", "Muğla"},
};
for(int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for(int j = 0; j <= regions.GetUpperBound(1); j++)
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("-----------------------");
}
Console.WriteLine();
Console.ReadLine();
#endregion