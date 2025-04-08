/// Write a program in C# to calculate area of triangle,
/// square and rectangle. Write 3 different functions
/// for each shape to take dimensions of figure and
/// display the area. You may create menus.

void ClearConsole()
{
    Console.Clear();
    Console.SetCursorPosition(0, 0);
    Console.WriteLine("╔════ Area Calculator ════╗");
    Console.WriteLine("║                         ║");
    Console.WriteLine("║                         ║");
    Console.WriteLine("║                         ║");
    Console.WriteLine("║                         ║");
    Console.WriteLine("║                         ║");
    Console.WriteLine("╚═════════════════════════╝");
}

void LoadMenu()
{
    ClearConsole();
    Console.SetCursorPosition(2, 1);
    Console.Write("Select command:");
    Console.SetCursorPosition(2, 2);
    Console.Write("T - Triangle");
    Console.SetCursorPosition(2, 3);
    Console.Write("S - Square");
    Console.SetCursorPosition(2, 4);
    Console.Write("R - Rectangle");
    Console.SetCursorPosition(2, 5);
    Console.Write("Q - Quit");
    Console.SetCursorPosition(18, 1);
}

void PauseUntilKeystroke() {
    bool pause = true;
    while (pause) {
        Console.ReadKey();
        pause = false;
    }
}

void TriangleArea()
{
    ClearConsole();
    Console.SetCursorPosition(2, 1);
    Console.Write("Triangle Area");
    Console.SetCursorPosition(2, 2);
    Console.Write("Base Length  :");
    Console.SetCursorPosition(2, 3);
    Console.Write("Height Length:");
    Console.SetCursorPosition(17, 2);
    double baseLength = Convert.ToDouble(Console.ReadLine());
    Console.SetCursorPosition(17, 3);
    double heightLength = Convert.ToDouble(Console.ReadLine());
    Console.SetCursorPosition(2, 5);
    Console.Write($"Area: {baseLength*heightLength/2}");
    PauseUntilKeystroke();
}

void SquareArea()
{
    ClearConsole();
    Console.SetCursorPosition(2, 1);
    Console.Write("Square Area");
    Console.SetCursorPosition(2, 2);
    Console.Write("Side Length  :");
    double sideLength = Convert.ToDouble(Console.ReadLine());
    Console.SetCursorPosition(2, 5);
    Console.Write($"Area: {sideLength * sideLength}");
    PauseUntilKeystroke();
}

void RectangleArea()
{
    ClearConsole();
    Console.SetCursorPosition(2, 1);
    Console.Write("Rectangle Area");
    Console.SetCursorPosition(2, 2);
    Console.Write("Width Length :");
    Console.SetCursorPosition(2, 3);
    Console.Write("Height Length:");
    Console.SetCursorPosition(17, 2);
    double widthLength = Convert.ToDouble(Console.ReadLine());
    Console.SetCursorPosition(17, 3);
    double heightLength = Convert.ToDouble(Console.ReadLine());
    Console.SetCursorPosition(2, 5);
    Console.Write($"Area: {widthLength * heightLength}");
    PauseUntilKeystroke();
}

ClearConsole();
ConsoleKeyInfo menuSelection;
char choice = '0';
while (choice!='q')
{
    LoadMenu();
    menuSelection = Console.ReadKey();
    choice = menuSelection.KeyChar;
    switch (char.ToLower(choice))
    {
        case 't':
            TriangleArea();
            break;
        case 's':
            SquareArea();
            break;
        case 'r':
            RectangleArea();
            break;
        case 'q':
            Console.SetCursorPosition(0,7);
            break;
    }
}
