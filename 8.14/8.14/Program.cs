Random rand = new Random();
int[] object_1 = new int[15];
int[] object_2 = new int[15];
int[] object_3 = new int[15];

Console.WriteLine($"{"Студент",15} {"первый предмет",15} {"второй предмет",15} {"третий предмет",15}");
for (int i = 0; i < 15; i++)
{
    object_1[i] = rand.Next(2, 5);
    object_2[i] = rand.Next(2, 5);
    object_3[i] = rand.Next(2, 5);
    Console.WriteLine($"{i + 1,15}{object_1[i],15}{object_2[i],15}{object_3[i],15}");
}
Console.WriteLine();

double students = 0;
double object_4_5 = 0;
double mark = 0;
double summa = 0;
for (int i = 0; i < 5; i++)
{
    if (i > 2)
    {
        students++;

    }

    if (i == 2)
    {
        students = Convert.ToDouble(object_1[i]);
        students++;
        object_4_5 += Convert.ToDouble(object_2[i]);
        object_4_5++;
        mark = Convert.ToDouble(object_3[i]);
        mark++;
        summa = students + object_4_5 + mark;

    }

}

Console.WriteLine("количество студентов, сдавших сессию без двоек: " + students);
Console.WriteLine("количество предметов, по которым были получены только оценки \"5\" и \"4\"" + object_4_5);
Console.WriteLine("количество двоек по каждому предмету: " + summa);

