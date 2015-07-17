namespace Minesweeper
{
    using System;
    using System.Collections.Generic;

    public class Mines
    {
        public static void Main()
        {
            const int BOARD_ROWS = 5;
            const int BOARD_COLUMNS = 10;
            const int MAXIMUM_OPENED_CELLS = 35;
            int openedCells = 0;

            char[,] questionsPlayBoard = CreatePlayBoard('?', BOARD_ROWS, BOARD_COLUMNS);
            char[,] bombsPlayBoard = PutBombs(BOARD_ROWS, BOARD_COLUMNS);
            List<Score> highScores = new List<Score>(6);

            string command = string.Empty;
            int row = 0;
            int col = 0;

            bool isBombOpened = false;
            bool isPlayBoardDrawn = false;
            bool allCellsOpened = false;

            do
            {
                if (!isPlayBoardDrawn)
                {
                    Console.WriteLine("Let's play Minesweeper. Try to find all fields without mines. " +
                    "Command 'top' shows high scores, 'restart' initiates a new game, 'exit' exits the application.");
                    DrawPlayBoard(questionsPlayBoard);
                    isPlayBoardDrawn = true;
                }

                Console.Write("Enter row and col, separated by a space: ");
                command = Console.ReadLine().Trim();
                if (command.Length == 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        string.IsNullOrWhiteSpace(command[1].ToString()) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row < questionsPlayBoard.GetLength(0) && col < questionsPlayBoard.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        DrawHighScores(highScores);
                        break;
                    case "restart":
                        questionsPlayBoard = CreatePlayBoard('?', BOARD_ROWS, BOARD_COLUMNS);
                        bombsPlayBoard = PutBombs(BOARD_ROWS, BOARD_COLUMNS);
                        DrawPlayBoard(questionsPlayBoard);
                        isBombOpened = false;
                        isPlayBoardDrawn = true;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, bye!");
                        break;
                    case "turn":
                        if (bombsPlayBoard[row, col] != '*')
                        {
                            if (bombsPlayBoard[row, col] == '-')
                            {
                                UpdatePlayBoards(questionsPlayBoard, bombsPlayBoard, row, col);
                                openedCells++;
                            }

                            if (MAXIMUM_OPENED_CELLS == openedCells)
                            {
                                allCellsOpened = true;
                            }
                            else
                            {
                                DrawPlayBoard(questionsPlayBoard);
                            }
                        }
                        else
                        {
                            isBombOpened = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! Invalid choise!\n");
                        break;
                }

                if (isBombOpened)
                {
                    DrawPlayBoard(bombsPlayBoard);
                    Console.Write("\nYou died with {0} points. Enter your name: ", openedCells);
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, openedCells);
                    if (highScores.Count < 5)
                    {
                        highScores.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < highScores.Count; i++)
                        {
                            if (highScores[i].PlayerPoints < score.PlayerPoints)
                            {
                                highScores.Insert(i, score);
                                highScores.RemoveAt(highScores.Count - 1);
                                break;
                            }
                        }
                    }

                    highScores.Sort((Score x1, Score x2) => x2.PlayerName.CompareTo(x1.PlayerName));
                    highScores.Sort((Score x1, Score x2) => x2.PlayerPoints.CompareTo(x1.PlayerPoints));
                    DrawHighScores(highScores);

                    questionsPlayBoard = CreatePlayBoard('?', BOARD_ROWS, BOARD_COLUMNS);
                    bombsPlayBoard = PutBombs(BOARD_ROWS, BOARD_COLUMNS);
                    openedCells = 0;
                    isBombOpened = false;
                    isPlayBoardDrawn = false;
                }

                if (allCellsOpened)
                {
                    Console.WriteLine("\nCongratulations! You have opened all 35 cells without stepping on mine.");
                    DrawPlayBoard(bombsPlayBoard);
                    Console.WriteLine("Enter your name: ");
                    string name = Console.ReadLine();
                    Score score = new Score(name, openedCells);
                    highScores.Add(score);
                    DrawHighScores(highScores);
                    questionsPlayBoard = CreatePlayBoard('?', BOARD_ROWS, BOARD_COLUMNS);
                    bombsPlayBoard = PutBombs(BOARD_ROWS, BOARD_COLUMNS);
                    openedCells = 0;
                    allCellsOpened = false;
                    isPlayBoardDrawn = false;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void DrawHighScores(List<Score> highScores)
        {
            Console.WriteLine("\nHigh scores:");
            if (highScores.Count > 0)
            {
                for (int i = 0; i < highScores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, highScores[i].PlayerName, highScores[i].PlayerPoints);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty scores!\n");
            }
        }

        private static void UpdatePlayBoards(char[,] questionsBoard, char[,] bombsBoard, int row, int col)
        {
            char bombsNearBy = CountBombsNearBy(bombsBoard, row, col);
            bombsBoard[row, col] = bombsNearBy;
            questionsBoard[row, col] = bombsNearBy;
        }

        private static void DrawPlayBoard(char[,] playBoard)
        {
            int row = playBoard.GetLength(0);
            int col = playBoard.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", playBoard[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreatePlayBoard(char mark, int rows, int cols)
        {
            char[,] playBoard = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playBoard[i, j] = mark;
                }
            }

            return playBoard;
        }

        private static char[,] PutBombs(int rows, int cols)
        {
            char[,] bombsPlayBoard = CreatePlayBoard('-', rows, cols);
            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                int random = new Random().Next(50);
                if (!bombs.Contains(random))
                {
                    bombs.Add(random);
                }
            }

            foreach (int item in bombs)
            {
                int col = item / cols;
                int row = item % cols;
                if (row == 0 && item != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                bombsPlayBoard[col, row - 1] = '*';
            }

            return bombsPlayBoard;
        }

        private static char CountBombsNearBy(char[,] playBoard, int row, int col)
        {
            int count = 0;
            int rows = playBoard.GetLength(0);
            int cols = playBoard.GetLength(1);

            if (row - 1 >= 0)
            {
                if (playBoard[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (playBoard[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (playBoard[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (playBoard[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (playBoard[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (playBoard[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (playBoard[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (playBoard[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}


