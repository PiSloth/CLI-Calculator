
using System.Diagnostics;

string[] Maths =
{
    "Addition",
    "Subtraciton",
    "Division",
    "Multiplication",
    "Power",
};

bool terminaExit = false;
bool numIdentify = false;
int firstNum = 0;
int secNum = 0;
int answer = 0;
int userChoiceMaths = 0;

string greeting = "Hellow Welcome from CLI Calculator";

while (!terminaExit)
{
    if (!numIdentify)
    {
        Console.Write("Enter First Num => ");
        firstNum = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Enter Second Num => ");
        secNum = Convert.ToInt32(Console.ReadLine());
        numIdentify = true;
    }
    Console.WriteLine();
    Console.WriteLine(greeting);

    if (numIdentify)
    {
        Console.WriteLine($"Numbers -> {firstNum} , {secNum}");
    }
    Console.WriteLine();
    Console.WriteLine("This tow number is executed to");
    for (int i = 0; i < Maths.Length; i++)
    {
        Console.WriteLine($"{i + 1}-> {Maths[i]}");
    }
    Console.WriteLine("0-> Re assign numbers value");
    Console.WriteLine("99-> Exit from the room");

    Console.Write("Enter your choice : ");
    int userInput = Convert.ToInt32(Console.ReadLine());

    switch (userInput)
    {
        case 0:
            numIdentify = false;
            break;
        case 1:
            answer = firstNum + secNum;
            break;
        case 2:
            answer = firstNum - secNum;
            break;
        case 3:
            answer = firstNum / secNum;
            break;
        case 4:
            answer = firstNum * secNum;
            break;
        case 5:
            break;
        case 99:
            Console.WriteLine();
            Console.Write("Are you sure to exit?, yes/No => ");
            string userChoice = Console.ReadLine().ToLower();
            if (userChoice == "yes")
            {
                terminaExit = true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Looping again. . .");
            }
            break;
        default:
            Console.WriteLine("Make sure valid input ? ? ?");
            break;
    }
    if (userInput > 0 && userInput < 10)
    {
        userChoiceMaths = userInput - 1;
        Console.WriteLine($"[{firstNum} {Maths[userChoiceMaths]} {secNum}\n ..... Answer => {answer} .....]");
    }
}
