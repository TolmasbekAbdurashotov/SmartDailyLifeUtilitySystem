using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("===== Smart Student Utility System =====");
            Console.WriteLine("1. Student Helper");
            Console.WriteLine("2. Salary Calculator");
            Console.WriteLine("3. Password Tools");
            Console.WriteLine("4. Exit");

            Console.Write("Tanlovni kiriting: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentHelper();
                    break;
                case 2:
                    SalaryCalculator();
                    break;
                case 3:
                    PasswordTools();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Noto‘g‘ri tanlov!");
                    break;
            }
        }
    }

    // ================= STUDENT HELPER =================
    static void StudentHelper()
    {
        while (true)
        {
            Console.WriteLine("\n=== Student Helper ===");
            Console.WriteLine("1. O'rtacha baho");
            Console.WriteLine("2. Eng yuqori baho");
            Console.WriteLine("3. Bahoni darajaga ajratish");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 4) break;

            switch (choice)
            {
                case 1:
                    int[] grades = new int[5];
                    int sum = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Baho {i + 1}: ");
                        grades[i] = int.Parse(Console.ReadLine());
                        sum += grades[i];
                    }

                    double avg = (double)sum / 5;
                    Console.WriteLine("O‘rtacha baho: " + avg);
                    break;

                case 2:
                    int[] arr = new int[5];
                    int max = int.MinValue;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write($"Baho {i + 1}: ");
                        arr[i] = int.Parse(Console.ReadLine());

                        if (arr[i] > max)
                            max = arr[i];
                    }

                    Console.WriteLine("Eng yuqori baho: " + max);
                    break;

                case 3:
                    Console.Write("Bahoni kiriting: ");
                    int grade = int.Parse(Console.ReadLine());

                    if (grade >= 90) Console.WriteLine("A");
                    else if (grade >= 80) Console.WriteLine("B");
                    else if (grade >= 70) Console.WriteLine("C");
                    else if (grade >= 60) Console.WriteLine("D");
                    else Console.WriteLine("F");
                    break;
            }
        }
    }

    // ================= SALARY CALCULATOR =================
    static void SalaryCalculator()
    {
        while (true)
        {
            Console.WriteLine("\n=== Salary Calculator ===");
            Console.WriteLine("1. Oylik maosh");
            Console.WriteLine("2. Soliq hisoblash");
            Console.WriteLine("3. Yillik daromad");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 4) break;

            switch (choice)
            {
                case 1:
                    Console.Write("Soatlik ish haqi: ");
                    double rate = double.Parse(Console.ReadLine());

                    Console.Write("Ishlagan soat: ");
                    int hours = int.Parse(Console.ReadLine());

                    double salary = rate * hours;
                    Console.WriteLine("Maosh: " + salary);
                    break;

                case 2:
                    Console.Write("Maoshni kiriting: ");
                    double income = double.Parse(Console.ReadLine());

                    double taxRate = (income > 5000000) ? 0.12 : 0.08;
                    double tax = Math.Round(income * taxRate, 2);

                    Console.WriteLine("Soliq: " + tax);
                    break;

                case 3:
                    Console.Write("Oylik daromad: ");
                    double monthly = double.Parse(Console.ReadLine());

                    Console.WriteLine("Yillik daromad: " + (monthly * 12));
                    break;
            }
        }
    }

    // ================= PASSWORD TOOLS =================
    static void PasswordTools()
    {
        while (true)
        {
            Console.WriteLine("\n=== Password Tools ===");
            Console.WriteLine("1. Uzunligini tekshirish");
            Console.WriteLine("2. Kuchliligini aniqlash");
            Console.WriteLine("3. Maskalash");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 4) break;

            switch (choice)
            {
                case 1:
                    Console.Write("Parol: ");
                    string p1 = Console.ReadLine();
                    Console.WriteLine("Uzunligi: " + p1.Length);
                    break;

                case 2:
                    Console.Write("Parol: ");
                    string p2 = Console.ReadLine();

                    bool hasUpper = false;
                    bool hasDigit = false;

                    foreach (char c in p2)
                    {
                        if (char.IsUpper(c)) hasUpper = true;
                        if (char.IsDigit(c)) hasDigit = true;
                    }

                    if (p2.Length >= 8 && hasUpper && hasDigit)
                        Console.WriteLine("Strong");
                    else
                        Console.WriteLine("Weak");
                    break;

                case 3:
                    Console.Write("Parol: ");
                    string p3 = Console.ReadLine();

                    for (int i = 0; i < p3.Length; i++)
                        Console.Write("*");

                    Console.WriteLine();
                    break;
            }
        }
    }
}