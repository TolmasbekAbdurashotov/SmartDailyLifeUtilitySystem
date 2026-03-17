using System;

class Program
{
    static void Main()
    {
    menu:
        Console.Clear();
        Console.WriteLine("==== Smart Daily Life Utility System ====\n" +
        "1. Health Tools\n" +
        "2. Shopping Helper\n" +
        "3. Text Tools\n" +
        "4. Exit\n");

        Console.Write("Enter command(1-4): ");
        int command = Convert.ToInt32(Console.ReadLine());

        if (command == 1)
        {
        healthMenu:
            Console.Clear();
            Console.WriteLine("=== Health Tools ===\n\n" +
            "1. BMI (Body Mass Index hisoblash)\n" +
            "2. Kunlik suv miqdorini hisoblash\n" +
            "3. Ideal vaznni aniqlash\n" +
            "4. Exit\n");

            Console.Write("Enter command(1-4): ");
            int healthCommand = Convert.ToInt32(Console.ReadLine());

            if (healthCommand == 1)
            {
                Console.Write("Buyingizni kiriting(metrda): ");
                double buy = Convert.ToDouble(Console.ReadLine());

                Console.Write("O'z tana vazningizni kiriting: ");
                double vazn = Convert.ToDouble(Console.ReadLine());

                double bmi = vazn / (buy * buy);

                Console.WriteLine($"Sizning BMI ko'rsatkichi: {bmi}");

                if (bmi < 18.5)
                    Console.WriteLine("Ozgin");
                else if (bmi >= 18.5 && bmi < 25)
                    Console.WriteLine("Normal vazn");
                else if (bmi >= 25 && bmi < 30)
                    Console.WriteLine("Ortiqcha vazn");
                else
                    Console.WriteLine("Semizlik");
            }
            else if (healthCommand == 2)
            {
                Console.Write("O'z tana vazningizni kiriting: ");
                double vazn = Convert.ToDouble(Console.ReadLine());

                double suvMiqdori = vazn * 0.033;
                Console.WriteLine($"Kunlik suv miqdori: {suvMiqdori} litr");
            }
            else if (healthCommand == 3)
            {
                Console.Write("Buyingizni kiriting(metrda): ");
                double buy = Convert.ToDouble(Console.ReadLine());

                double idealVazn = 22.5 * (buy * buy);
                Console.WriteLine($"Sizning ideal vazningiz: {idealVazn} kg");
            }
            else if (healthCommand == 4)
            {
                Console.WriteLine("Exiting Health Tools...");
                goto menu;
            }

            Console.Write("Health Tools ishini yakunlash(y/n): ");
            string exitHealth = Console.ReadLine();

            if (exitHealth.ToLower() == "y" || exitHealth.ToLower() == "yes")
                goto menu;

            goto healthMenu;
        }
        else if (command == 2)
        {
        shoppingCommand:
            Console.Clear();
            Console.WriteLine("=== Shopping Helper ===\n\n" +
            "1. Mahsulot umumiy narxini hisoblash\n" +
            "2. Chegirmali narxni hisoblash\n" +
            "3. Xarid byudjetini tekshirish\n" +
            "4. Exit\n");

            Console.Write("Enter command(1-4): ");
            int shoppingCommand = Convert.ToInt32(Console.ReadLine());

            if (shoppingCommand == 1)
            {
                Console.Write("Mahsulotlar sonini kiriting: ");
                int productCount = Convert.ToInt32(Console.ReadLine());

                double totalPrice = 0;

                for (int i = 1; i <= productCount; i++)
                {
                    Console.Write($"Mahsulot {i} narxini kiriting: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    totalPrice += price;
                }

                Console.WriteLine($"Umumiy narx: {totalPrice}");
            }
            else if (shoppingCommand == 2)
            {
                Console.Write("Asl narxni kiriting: ");
                double originalPrice = Convert.ToDouble(Console.ReadLine());
                 Console.Write("Chegirma foizini kiriting: ");
                double discountPercentage = Convert.ToDouble(Console.ReadLine());

                double discountedPrice = originalPrice * (1 - discountPercentage / 100);
                Console.WriteLine($"Chegirmali narx: {discountedPrice}");
            }
            else if (shoppingCommand == 3)
            {
                Console.Write("Xarid byudjetini kiriting: ");
                double budget = Convert.ToDouble(Console.ReadLine());

                Console.Write("Xarid qilinadigan mahsulotlar sonini kiriting: ");
                int productCount = Convert.ToInt32(Console.ReadLine());

                double totalCost = 0;

                for (int i = 1; i <= productCount; i++)
                {
                    Console.Write($"Mahsulot {i} narxini kiriting: ");
                    double price = Convert.ToDouble(Console.ReadLine());
                    totalCost += price;
                }

                if (totalCost <= budget)
                    Console.WriteLine("Sizning byudjetingiz yetarli.");
                else
                    Console.WriteLine("Sizning byudjetingiz yetarli emas.");
            }
            else if (shoppingCommand == 4)
            {
                Console.WriteLine("Exiting Shopping Helper...");
                goto menu;
            }

            Console.Write("Shopping Helper ishini yakunlash(y/n): ");
            string exitShopping = Console.ReadLine();

            if (exitShopping.ToLower() == "y" || exitShopping.ToLower() == "yes")
                goto menu;

            goto shoppingCommand;
        }
        else if (command == 3)
        {
        textMenu:
            Console.Clear();
            Console.WriteLine("=== Text Tools ===\n\n" +
            "1. Matn uzunligini aniqlash\n" +
            "2. Harflar sonini hisoblash\n" +
            "3. Matnni yashirish (mask)\n" +
            "4. Exit\n");

            Console.Write("Enter command(1-4): ");
            int textCommand = Convert.ToInt32(Console.ReadLine());

            if (textCommand == 1)
            {
                Console.Write("Matnni kiriting: ");
                string text = Console.ReadLine();

                Console.WriteLine($"Matn uzunligi: {text.Length}");
            }
            else if (textCommand == 2)
            {
                Console.Write("Matnni kiriting: ");
                string text = Console.ReadLine();

                int harfSoni = 0;

                foreach (char c in text)
                {
                    if (char.IsLetter(c))
                        harfSoni++;
                }

                Console.WriteLine($"Matndagi harflar soni: {harfSoni}");
            }
            else if (textCommand == 3)
            {
                Console.Write("Matnni kiriting: ");
                string text = Console.ReadLine();

                string maskedText = new string('*', text.Length);
                Console.WriteLine($"Yashirilgan matn: {maskedText}");
            }
            else if (textCommand == 4)
            {
                Console.WriteLine("Exiting Text Tools...");
                goto menu;
            }

            Console.Write("Text Tools ishini yakunlash(y/n): ");
            string exitText = Console.ReadLine();

            if (exitText.ToLower() == "y" || exitText.ToLower() == "yes")
                goto menu;

            goto textMenu;
        }
        else if (command == 4)
        {
            Console.WriteLine("Exiting Smart Daily Life Utility System...");
            return;
        }
        else
        {
            goto menu;
        }
    }
}