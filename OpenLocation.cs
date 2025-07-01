using System;

internal class ProjectOpenLocation
{
    /* Проект "Открытие локаций" - гибкий шаблон для будущих скриптов в Unity по выдаче доступа
    к определенным локациям игрового мира, удобно добавлять новые "локации" (OpenLocation) */
    // Так же присутствует концепция скрипта для хранения характеристик персонажа в игре на Unity (PlayerStats)
    public class PlayerStats
    {
        public static float characterHealth;
        public static float characterStamina;
        public static float characterLevel = 9;
        public static float gold = 1000;

    }

    public class OpenLocation
    {
        public static string locationName;
        public static string firstLocation = "Meadows";
        public static string secondLocation = "Forest";

        public static float locationOpenRequiredGold;
        public static float locationOpenRequiredLevel;

        public static bool isSecondLocationOpened;

        static void Main(string[] args)
        {
            openLocationForest();
            Console.WriteLine(isSecondLocationOpened);
        }
        public static void LocationOpenMethod()
        {
            if (PlayerStats.characterLevel >= locationOpenRequiredLevel)
            {
                Console.WriteLine($"Congrats! You've reached the pertinent level {locationOpenRequiredLevel} to " +
                    $"unlock a New Location - {locationName}!");
                isSecondLocationOpened = true;
            }
            else
            {
                Console.WriteLine($"Oh, you don't have needed level ({locationOpenRequiredLevel}) to unlock new location!" +
                    $" Your current level is {PlayerStats.characterLevel}.");
                Console.Write($"Well, you can buy the access to this location with {locationOpenRequiredGold} Gold. " +
                    $"Do you want to do this? Y / N: ");
                string purchaseAnswer = Console.ReadLine();
                if (purchaseAnswer == "Y")
                {
                    if (PlayerStats.gold >= locationOpenRequiredGold)
                    {
                        PlayerStats.gold -= locationOpenRequiredGold;
                        isSecondLocationOpened = true;
                        Console.WriteLine($"Purchase successful! Now you have {PlayerStats.gold} Gold.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough Gold to buy access to this location :(");
                    }
                }
                else if (purchaseAnswer == "N")
                {
                    Console.WriteLine("Your choice! We'll wait until you reach the required level or change your opinion :)");
                }
                else
                {
                    Console.WriteLine("Boom! Error! Please, enter the correct value next time.");
                }
            }
        }
        public static float openLocationForest()
        {
            locationName = secondLocation;
            locationOpenRequiredLevel = 10;
            locationOpenRequiredGold = 750;

            LocationOpenMethod();

            return PlayerStats.gold;
        }

    }
}
