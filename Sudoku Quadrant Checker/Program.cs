using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku_Quadrant_Checker
{
    class Program
    {
        private static List<int> QuadrantMapper(List<int> quadrantIndex, List<int[]> sudoku,
            IEnumerable<KeyValuePair<int, int>> repeatedValue)
        {
            foreach (var quadrant in sudoku)
            {
                foreach (var item in repeatedValue)
                {
                    if (quadrant.Contains(item.Key))
                        quadrantIndex.Add(sudoku.IndexOf(quadrant) + 1);
                }
            }

            return quadrantIndex;
        }

        private static List<string[]> MakeSudoku(string[] arr)
        {
            return new List<string[]>
            {
                new[] { arr[0], arr[1], arr[2] },
                new[] { arr[3], arr[4], arr[5] },
                new[] { arr[6], arr[7], arr[8] }
            };
        }

        private static IEnumerable<KeyValuePair<int, int>> RepeatedValue(Dictionary<int, int> list, string[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == (arr[j]))
                        count++;
                }

                list[Convert.ToInt32(arr[i])] = count;
                count = 0;
            }

            return list.Where(x => x.Value > 1);
        }

        static void rowChecker(string row, Dictionary<int, int> list, List<int> quadrantIndex)
        {
            row = row.Trim('(', ')');

            string[] arr = row.Split(',');
            var sudoku = MakeSudoku(arr);

            //Todo Quartları yeniden tara
            IEnumerable<KeyValuePair<int, int>> repeatedValue = RepeatedValue(new Dictionary<int, int>(), arr);

            //Todo: Metot Tanımla:
            QuadrantMapper(quadrantIndex, sudoku, repeatedValue);
        }


        static void colChecker(string col, List<int> list, List<int> quadrantIndex)
        {
            col = col.Trim('(', ')');
            int count = 0;

            string[] arr = col.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == (arr[j]))
                        count++;
                }

                list[Convert.ToInt32(arr[i])] = count;
                count = 0;
            }

            //Todo Quartları yeniden tara
            
        }

        public static void SudokuQuadrantChecker(string[] strArr)
        {
            Dictionary<int, int> listRow = new Dictionary<int, int>();
            Dictionary<int, int> listCol = new Dictionary<int, int>();
            List<int> quadrantIndex = new();
            for (int i = 0; i < strArr.Length; i++)
            {
                rowChecker(strArr[i], listRow, quadrantIndex);
            }

            for (int i = 0; i < strArr.Length; i++)
            {
                List<int> list = SelectCol(strArr);

                colChecker(strArr[i], list, quadrantIndex);
            }

            var result = quadrantIndex.Distinct();

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        static List<int> SelectCol (string[] arr) 
        {
            List<int> list = new(); 
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    list.Add(Int32.Parse(arr[i].Trim('(', ')').Split(',')[j]));
                }
            }

            return list;
        }


        static void Main(string[] args)
        {
            // keep this function call here
            SudokuQuadrantChecker(new[]
            {
                "(1,2,3,4,5,6,7,8,1)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(1,x,x,x,x,x,x,x,x)",
                "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)", "(x,x,x,x,x,x,x,x,x)",
                "(x,x,x,x,x,x,x,x,x)"
            });
        }
    }
}