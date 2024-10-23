Console.WriteLine("Введите день и месяц вашего рождения");

string Age = Console.ReadLine();

string[] twoNumb = Age.Split('.');
foreach (string nums in twoNumb)
{
    Console.WriteLine($"Число: {nums}");
}

    int date = Convert.ToInt32(twoNumb[0]);
    int month = Convert.ToInt32(twoNumb[1]);


    Console.WriteLine($"День");
    foreach (var day in twoNumb[0])
    {
        Console.WriteLine($"{day}");
    }
    Console.WriteLine($"Месяц");
    foreach (var mon in twoNumb[1])
    {
        Console.WriteLine($"{mon}");
    }

string text = "Ваш знак зодиака ";

    switch (month)
    {
    case (03):
            if (date >= 21)
            { Console.WriteLine(text + "Овен"); }
           else { Console.WriteLine(text + "Рыбы"); }
            break;

    case (04):
            if (date >= 21)
            { Console.WriteLine(text + "Телец"); }
            else { Console.WriteLine(text + "Овен"); }
            break;

    case (05):
        if (date >= 21)
        { Console.WriteLine(text + "Близнецы"); }
        else { Console.WriteLine(text + "Телец"); }
        break;

    case (06):
        if (date >= 22)
        { Console.WriteLine(text + "Рак"); }
        else { Console.WriteLine(text + "Близнецы"); }
        break;

    case (07):
        if (date >= 23)
        { Console.WriteLine(text + "Лев"); }
        else { Console.WriteLine(text + "Рак"); }
        break;

    case (08):
        if (date >= 24)
        { Console.WriteLine(text + "Дева"); }
        else { Console.WriteLine(text + "Лев"); }
        break;

    case (09):
        if (date >= 25)
        { Console.WriteLine(text + "Весы"); }
        else { Console.WriteLine(text + "Дева"); }
        break;

    case (010):
        if (date >= 24)
        { Console.WriteLine(text + "Скорпион"); }
        else { Console.WriteLine(text + "Весы"); }
        break;

    case (011):
        if (date >= 23)
        { Console.WriteLine(text + "Стрелец"); }
        else { Console.WriteLine(text + "Скорпион"); }
        break;

    case (012):
        if (date >= 22)
        { Console.WriteLine(text + "Козерог"); }
        else { Console.WriteLine(text + "Стрелец"); }
        break;

    case (013):
        if (date >= 21)
        { Console.WriteLine(text + "Водолей"); }
        else { Console.WriteLine(text + "Козерог"); }
        break;
    
    case (014):
        if (date >= 21)
        { Console.WriteLine(text + "Рыбы"); }
        else { Console.WriteLine(text + "Водолей"); }
        break;
}
