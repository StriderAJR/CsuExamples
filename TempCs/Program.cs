using System;
using System.Collections.Generic;
using System.Linq;

namespace TempCs
{
    class Program
    {
        private string[] GetNumStrs()
        {
            List<string> nums = new List<string>();
            for(int i = '0'; i <= '9'; i++) nums.Add(i.ToString());
            return nums.ToArray();
        }

        private string[] GetDigitStrs()
        {
            string[] digits = new string['9' - '0' + 1];
            for(int sym = '0', i = 0; sym <= '9'; sym++, i++) digits[i] = sym.ToString();
            return digits;
        }

        private char[] GetSigns()
        {
            return new char[] { '+', '-', '*', '/' };
        }

        private void Test()
        {
            var nums = GetNumStrs();
            var signs = GetSigns();

            var bigArray = new List<string>();
            bigArray.AddRange(nums);
            bigArray.AddRange(signs.Select(x => x.ToString()));
            bigArray.Add(" ");

            string expression = "1    + 2 * 3 / 1";
            expression.Replace(" ", ""); // 1+2*3/1
            string[] parts = expression.Split(signs); // { 1, 2, 3, 1 }

            List<string> newList = new List<string>(parts);
            List<string> newList2 = parts.ToList();
        }

        private void Test2()
        {
            var nums = GetNumStrs();            
        }
        
        private static bool IsCorrectCoordinate(string coord)
        {
            char letter = coord[0];
            char num = coord[1];
            return coord.Length == 2 && letter >= 'A' && letter <= 'H' && num >= '1' && num <= '8';
        }

        private static string ReadCoord()
        {
            do
            {
                string input = Console.ReadLine().ToUpper();
                if (IsCorrectCoordinate(input)) 
                    return input;
                else                           
                    Console.WriteLine("Координата не корректна!");
            }
            while (true);
        }

        enum FigureType
        {
            Knight // !!!!!!!!!!!
        }

        private static FigureType ReadFigureType()
        {
            do
            {
                string input = Console.ReadLine();
                if (input == "0" || input.ToLower() == "knight")
                    return FigureType.Knight;
                else                           
                    Console.WriteLine("Тип фигуры не корректен! кокококо");
            }
            while (true);
        }

        private static bool IsKnightCorrect(string start, string end)
        {
            int dx = Math.Abs(end[0] - start[0]);
            int dy = Math.Abs(end[1] - start[1]);

            return dx + dy == 3 && dx * dy == 2;
        }

        private static bool IsQueenCorrect(string start, string end)
        {
            // Перепрыгивать через фигуры может только конь, 
            // поэтому при проверке нужно убедить, что никто не стоит на пути

            return true;
        }

        static void Main(string[] args)
        {
            char sym = 'A';
            char d = (char) (sym + 5);

            char[,] board = InitBoard();

            Console.Write("Введите тип фигуры (0 - Конь):");
            FigureType figure = ReadFigureType();

            Console.Write("Введите стартовую координату: ");
            string start = ReadCoord();

            Console.Write("Введите конечную координату: ");
            string end = ReadCoord();

            bool isCorrect = false;
            switch(figure)
            {
                case FigureType.Knight: 
                    isCorrect = IsKnightCorrect(start, end); 
                    break;
            }

            if (isCorrect)
                Console.WriteLine("Ваша фигура ходит правильно.");
            else
                Console.WriteLine("Такой ход не возможен для данной фигуры.");
        }

        private static char[,] InitBoard()
        {
            return new char[,] 
            {
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
                { 'P', 'P', 'P', 'P', 'P', 'P', 'P', 'P' },
                { 'R', 'B', 'K', 'Q', 'K', 'K', 'B', 'R' },
            };
        }
    }
}
