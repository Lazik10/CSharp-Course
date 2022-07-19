
const int SIZE = 9;

char[,] board = new char[SIZE, SIZE];

bool turn = false;
bool end = false;

void Reset()
{
    for (int i = 0; i < SIZE; i++)
    {
        for (int j = 0; j < SIZE; j++)
        {
            board[i, j] = ' ';
        }
    }
}

void Draw()
{
    Console.WriteLine("  123456789");

    for (int y = 0; y < SIZE; y++)
    {
        Console.Write(y + 1);
        Console.Write(" ");
        for (int x = 0; x < SIZE; x++)
        {
            Console.Write(board[x, y]);
        }
        Console.WriteLine();
    }
}

void CheckForDraw()
{
    int count = 0;
    foreach (var item in board)
    {
        if (item == 'X' || item == 'O')
            count++;
    }

    if (count >= SIZE * SIZE)
    {
        Console.WriteLine("Remíza.");
        end = true;
    }
}

void CheckForWinner(int posX, int posY)
{
    int startPositionX = posX - 1;
    int startPositionY = posY - 1;

    bool checkLeft = true, checkRight = true, checkUp = true, checkDown = true, checkTopLeft = true, checkDownRight = true, checkTopRight = true, checkDownLeft = true;

    int countLeft = 0;
    int countRight = 0;
    int countUp = 0;
    int countDown = 0;
    int countTopLeft = 0;
    int countDownRight = 0;
    int countTopRight = 0;
    int countDownLeft = 0;

    for (int i = 1; i <= 4; i++)
    {
        // Row
        if (startPositionX - i >= 0 && startPositionX - i < SIZE && startPositionY >= 0 && startPositionY < SIZE)
        {
            if (checkLeft && board[startPositionX - i, startPositionY] == (turn ? 'O' : 'X'))
                countLeft++;
            else
                checkLeft = false;
        }

        if (startPositionX + i >= 0 && startPositionX + i < SIZE && startPositionY >= 0 && startPositionY < SIZE)
        {
            if (checkRight && board[startPositionX + i, startPositionY] == (turn ? 'O' : 'X'))
                countRight++;
            else
                checkRight = false;
        }

        // Column
        if (startPositionX >= 0 && startPositionX < SIZE && startPositionY - i >= 0 && startPositionY - i < SIZE)
        {
            if (checkUp && board[startPositionX, startPositionY - i] == (turn ? 'O' : 'X'))
                countUp++;
            else
                checkUp = false;
        }

        if (startPositionX >= 0 && startPositionX < SIZE && startPositionY + i  >= 0 && startPositionY + i < SIZE)
        {
            if (checkDown && board[startPositionX, startPositionY + i] == (turn ? 'O' : 'X'))
                countDown++;
            else
                checkDown = false;
        }

        // Diagonal down
        if (startPositionX - i >= 0 && startPositionX - i < SIZE && startPositionY - i >= 0 && startPositionY - i < SIZE)
        {
            if (checkTopLeft && board[startPositionX - i, startPositionY - i] == (turn ? 'O' : 'X'))
                countTopLeft++;
            else
                checkTopLeft = false;
        }

        if (startPositionX + i >= 0 && startPositionX + i < SIZE && startPositionY + i >= 0 && startPositionY + i < SIZE)
        {
            if (checkDownRight && board[startPositionX + i, startPositionY + i] == (turn ? 'O' : 'X'))
                countDownRight++;
            else
                checkDownRight = false;
        }

        // Diagonal up
        if (startPositionX + i >= 0 && startPositionX + i < SIZE && startPositionY - i >= 0 && startPositionY - i  < SIZE)
        {
            if (checkTopRight && board[startPositionX + i, startPositionY - i] == (turn ? 'O' : 'X'))
                countTopRight++;
            else
                checkTopRight = false;
        }

        if (startPositionX - i >= 0 && startPositionX - i < SIZE && startPositionY + i >= 0 && startPositionY + i  < SIZE)
        {
            if (checkDownLeft && board[startPositionX - i, startPositionY + i] == (turn ? 'O' : 'X'))
                countDownLeft++;
            else
                checkDownLeft = false;
        }
    }

    if (countLeft + countRight >= 4 || countDown + countUp >= 4 || countTopLeft + countDownRight >= 4 || countDownLeft + countTopRight >= 4)
    { 
        end = true;
    }
}

void AskForPosition()
{
    Console.WriteLine();
    Console.WriteLine("Na řadě je hráč s {0}", turn ? "kolečky" : "křížky");
    int positionX, positionY;

    bool success;
    do
    {
        // Position X
        Console.Write("Zadej pozici X kam chceš táhnout: ");
        while (!int.TryParse(Console.ReadLine(), out positionX))
        {
            Console.WriteLine("Zadej prosím celé číslo");
        }

        // Position Y
        Console.Write("Zadej pozici Y kam chceš táhnout: ");
        while (!int.TryParse(Console.ReadLine(), out positionY))
        {
            Console.WriteLine("Zadej prosím celé číslo");
        }

        if (positionX > SIZE || positionX <= 0 || positionY > SIZE || positionY <= 0 || board[positionX - 1, positionY - 1] != ' ')
        {
            Console.WriteLine("Neplatná pozice, zadej ji prosím znovu.");
            success = false;
        }
        else
        {
            board[positionX - 1, positionY - 1] = turn ? 'O' : 'X';
            success = true;
        }
    }
    while (!success);

    CheckForWinner(positionX, positionY);
    CheckForDraw();
    turn = !turn;
}

Reset();
Draw();
while (!end)
{
    AskForPosition();
    Draw();
}

Console.Clear();
Draw();
Console.WriteLine("Vyhrál hráč s {0}", turn ? "kolečky" : "křížky");