// Генератор Random
{
    Random rand = new Random();
    int round = 0; // Подбираем рандомное число в промежутке от 0 до 10 и записываем в переменную v
                   // 0 - включительно, 10 - не включительно
    Random random = new Random();
    float health1 = rand.Next(90, 101);
    float damage1 = rand.Next(5, 16); ;
    float armorProtect1 = rand.Next(100, 151);

    float health2 = rand.Next(90, 101); ;
    float damage2 = rand.Next(5, 16); ;
    float armorProtect2 = rand.Next(100, 151);



    while (health1 > 0 && health2 > 0)
    {
        Console.WriteLine("Round " + round);
        Console.WriteLine($"Player 1 has {health1} health, {damage1} damage, {armorProtect1} armor.");
        Console.WriteLine($"Player 2 has {health2} health, {damage2} damage, {armorProtect2} armor.");
        health1 -= damage2 / (armorProtect1 / 100);
        health2 -= damage1 / (armorProtect2 / 100);
        round++;
        Console.ReadKey();
    }
    Console.WriteLine(" ");
    if (health1 > 0)
    {
        Console.WriteLine("Player 1 win the fight!");
    }
    else if (health2 > 0)
    {
        Console.WriteLine("Player 2 win the fight!");
    }
    else
    {
        Console.WriteLine("Draw!");
    }

}
