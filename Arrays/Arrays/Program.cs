string[,] table2D = new string[3, 3];
bool gameContinue = true;
int turn = 0;

while (gameContinue)
{
    Console.Clear();

    string table = $"{table2D[0, 0]} {table2D[0, 1]} {table2D[0, 2]}\n{table2D[1, 0]} {table2D[1, 1]} {table2D[1, 2]}\n{table2D[2, 0]} {table2D[2, 1]} {table2D[2, 2]}\n";
    Console.WriteLine(table);

    if (turn == 0)
    {
        Console.WriteLine("Select number of the column to put the X: ");
        int column = int.Parse(Console.ReadLine());

        Console.WriteLine("Select number of the line to put the X: ");
        int line = int.Parse(Console.ReadLine());

        table2D[column, line] = "X";
        turn = 1;
    }
    else
    {
        Console.WriteLine("Select number of the column to put the O: ");
        int column = int.Parse(Console.ReadLine());

        Console.WriteLine("Select number of the line to put the O: ");
        int line = int.Parse(Console.ReadLine());

        table2D[column, line] = "O";
        turn = 0;
    }

    Console.WriteLine("Someone Won? (s/n)");
    string response = Console.ReadLine();

    if (response == "s")
        gameContinue = false;
}