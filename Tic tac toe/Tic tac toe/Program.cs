using System;

class TicTacToe
{
    static char[,] board =
    {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
    };

    static char currentPlayer = 'X';

    static void Main()
    {
        while (true)
        {
            DrawBoard();
            PlayerMove();

            if (CheckWin())
            {
                DrawBoard();
                Console.WriteLine($"Гравець {currentPlayer} переміг!"); 
                break;
            }

            if (CheckDraw())
            {
                DrawBoard();
                Console.WriteLine("Нічия!");
                break;
            }

            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("Хрестики - Нолики");
        Console.WriteLine();
        Console.WriteLine($" {board[0, 0]} | {board[0, 1]} | {board[0, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[1, 0]} | {board[1, 1]} | {board[1, 2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[2, 0]} | {board[2, 1]} | {board[2, 2]} ");
        Console.WriteLine();
    }

    static void PlayerMove()
    {
        while (true)
        {
            Console.Write($"Гравець {currentPlayer}, введіть номер клітинки: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int move) && move >= 1 && move <= 9)
            {
                int row = (move - 1) / 3;
                int col = (move - 1) % 3;

                if (board[row, col] != 'X' && board[row, col] != 'O')
                {
                    board[row, col] = currentPlayer;
                    break;
                }
                else
                {
                    Console.WriteLine("Ця клітинка вже зайнята, спробуйте іншу.");
                }
            }
            else
            {
                Console.WriteLine("Некоректне значення, введіть число від 1 до 9.");
            }
        }
    }

    static bool CheckWin()
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) return true;
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i]) return true; 
        }

        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]) return true;
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;

        return false;
    }

    static bool CheckDraw()
    {
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O') return false;
        }
        return true;
    }
}
