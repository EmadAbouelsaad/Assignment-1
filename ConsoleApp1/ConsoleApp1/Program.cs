namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            for (int i = 0; i < 9; i++)
            {
                PrintBoard(board);
                char symbol = i % 2 == 0 ? 'X' : 'O';
                Console.WriteLine($"{symbol}'s move > ");
                int x = -1, y = -1;
                while (!IsValidMove(board, ref x, ref y, symbol))
                {
                    Console.Write("Enter x (0-2) > ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter y (0-2) > ");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                board[x, y] = symbol;
            }

            PrintBoard(board);
            Console.WriteLine("Game over!");
        }

        static bool IsValidMove(char[,] board, ref int x, ref int y, char symbol)
        {
            if (x < 0 || x > 2 || y < 0 || y > 2)
            {
                Console.WriteLine("Invalid move. Try again.");
                return false;
            }
            else if (board[x, y] != ' ')
            {
                Console.WriteLine("Position already taken. Try again.");
                return false;
            }
            return true;
        }

        static void PrintBoard(char[,] board)
        {
            Console.WriteLine("| {0} | {1} | {2} |", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("| {0} | {1} | {2} |", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("| {0} | {1} | {2} |", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine();
        }
    }
}