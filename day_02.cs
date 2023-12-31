﻿namespace advent_of_code_2023
{
    public static class day_02
    {
        public static void part2()
        {
            var list = getInput();
            var sum = 0;
            var blue = 1;
            var green = 1;
            var red = 1;
            for (int i = 0; i < list.Count(); i++)
            {

                blue = 1;
                green = 1;
                red = 1;
                var gameSets = list[i].Replace(";", ",").Split(",");
                Console.WriteLine(gameSets);
                for (int k = 0; k < gameSets.Count(); k++)
                {

                    var number = int.Parse(gameSets[k].Where(Char.IsDigit).ToArray());
                    string color = new String(gameSets[k].Where(Char.IsLetter).ToArray());
                    switch (color)
                    {
                        case "red":
                            red = number >= red ? number : red;
                            break;
                        case "green":
                            green = number >= green ? number : green;
                            break;
                        case "blue":
                            blue = number >= blue ? number : blue;
                            break;
                    }
                }
                Console.WriteLine("game: " + i.ToString() + " red: " + red.ToString() + " green: " + green.ToString() + " blue: " + blue.ToString());
                sum += red * green * blue;
            }

            Console.WriteLine(sum);
        }

        public static List<string> getInput()
        {
            return new(){
                "2 blue, 4 green; 7 blue, 1 red, 14 green; 5 blue, 13 green, 1 red; 1 red, 7 blue, 11 green",
                "6 blue, 3 green; 4 red, 1 green, 7 blue; 2 green",
                "4 blue, 3 red; 2 blue, 4 red, 7 green; 1 blue, 6 red, 7 green; 5 green, 10 blue; 9 green, 1 blue, 6 red; 8 blue, 1 red, 12 green",
                "15 blue, 4 green, 5 red; 2 red, 2 green, 5 blue; 3 green, 13 blue; 17 blue, 1 green, 5 red",
                "11 green, 4 red, 3 blue; 8 blue, 6 green; 8 green, 2 red, 9 blue; 4 red, 16 blue; 8 blue, 10 red, 6 green; 9 blue, 3 red, 10 green",
                "4 green, 9 red, 2 blue; 7 red, 2 green, 15 blue; 13 red, 2 green, 6 blue; 5 green, 7 blue, 6 red; 19 red, 15 blue, 4 green",
                "12 blue, 5 red; 5 green, 6 blue; 5 red, 15 blue; 5 blue, 5 red, 5 green; 1 green, 11 blue, 2 red",
                "6 red, 11 green; 5 red, 2 blue, 7 green; 7 red, 6 green",
                "5 red, 1 blue, 11 green; 4 green, 1 blue; 8 green, 2 red; 1 green, 2 red, 2 blue; 3 green, 2 red",
                "7 blue, 4 red, 11 green; 13 green, 1 red, 1 blue; 7 blue, 6 green",
                "4 blue, 7 red, 2 green; 1 green, 14 red, 3 blue; 2 green, 5 red, 3 blue",
                "6 green, 6 blue, 1 red; 1 green, 3 red, 2 blue; 2 blue, 6 red, 7 green",
                "6 red, 10 green, 13 blue; 3 red, 12 green, 9 blue; 11 blue, 1 green; 4 red, 3 blue, 13 green; 12 green, 10 blue, 6 red; 13 blue, 3 green, 3 red",
                "8 green, 1 blue, 17 red; 7 green, 11 blue, 19 red; 19 red, 9 blue, 2 green; 8 green, 20 red, 12 blue; 16 red, 3 green, 11 blue",
                "3 red, 1 green, 5 blue; 9 blue, 4 green; 6 blue, 5 green, 9 red",
                "13 blue, 1 red; 2 blue, 2 green; 1 green; 10 blue, 8 red; 4 red, 3 green, 9 blue",
                "10 blue, 2 red; 3 green, 4 red; 6 blue, 1 red, 6 green; 5 green, 7 blue, 5 red",
                "3 red, 1 green; 2 red, 5 blue; 5 blue, 2 red",
                "7 green, 4 blue, 1 red; 1 green, 4 blue, 4 red; 6 blue, 8 green; 4 green, 2 blue, 1 red; 1 red, 1 blue, 2 green",
                "13 green, 1 red, 1 blue; 12 green, 1 blue; 5 green, 1 blue, 2 red; 16 green, 3 red; 2 red, 9 green",
                "8 red, 2 green, 2 blue; 5 red, 3 blue; 2 blue, 5 red, 2 green; 7 blue",
                "9 red, 12 blue, 7 green; 7 red, 13 blue, 4 green; 9 blue, 13 red, 1 green; 3 blue, 4 red, 5 green",
                "7 green, 12 red; 6 red, 7 green, 4 blue; 1 blue, 11 red, 5 green; 4 green, 2 blue, 6 red; 12 green, 6 red, 3 blue",
                "11 red, 4 blue; 9 blue, 6 green, 17 red; 8 green, 2 red; 16 blue, 6 red, 2 green",
                "7 red, 4 blue; 7 blue, 4 green; 10 blue, 4 red, 2 green; 6 green, 4 blue, 1 red; 10 blue, 2 red, 4 green",
                "7 green, 8 red, 6 blue; 5 red, 3 green, 2 blue; 13 blue, 6 green, 5 red; 10 blue, 4 red, 8 green; 2 red, 2 blue, 1 green; 8 blue, 1 green, 4 red",
                "7 green, 3 blue, 13 red; 1 green, 17 red, 1 blue; 16 red, 3 blue, 3 green; 5 green, 3 red, 5 blue; 13 red, 4 green, 8 blue; 6 blue, 2 green, 15 red",
                "8 blue, 5 red, 18 green; 1 green, 6 red; 7 blue, 18 green, 5 red; 16 green, 3 red, 7 blue; 6 blue, 18 green; 8 blue, 8 green, 7 red",
                "4 blue, 1 red; 6 blue, 1 red; 17 blue, 1 green",
                "1 red, 2 green, 5 blue; 2 blue, 7 green, 6 red; 11 blue, 4 red, 2 green; 5 green, 6 blue, 4 red; 5 red, 8 blue, 7 green",
                "10 green, 9 blue; 5 green, 9 blue, 1 red; 1 red, 8 blue",
                "3 red, 5 green; 5 red, 5 blue, 14 green; 2 red, 2 green; 11 green, 3 red, 5 blue",
                "7 blue, 10 green, 8 red; 18 blue, 15 green, 4 red; 6 red, 1 green; 18 blue, 8 red, 11 green",
                "3 green; 2 red, 5 green; 5 blue, 3 green; 3 blue, 5 green, 1 red",
                "1 blue, 5 green, 6 red; 3 green, 2 red, 3 blue; 4 red, 9 blue, 3 green; 1 green, 12 blue, 1 red",
                "14 green, 3 blue, 16 red; 1 green, 2 red, 4 blue; 4 blue, 9 green, 18 red; 4 blue, 4 green, 14 red; 4 blue, 11 green",
                "7 green, 2 blue, 3 red; 8 green, 9 red, 2 blue; 4 blue, 15 green, 18 red",
                "11 red, 1 blue, 6 green; 6 green, 2 blue, 1 red; 6 blue, 17 red, 2 green; 17 red, 9 blue, 3 green; 7 red, 7 blue, 3 green; 3 green, 7 red, 7 blue",
                "1 blue, 2 green; 1 blue, 2 green, 7 red; 1 blue, 4 red, 2 green; 1 blue, 12 red",
                "1 blue, 4 red, 15 green; 12 green, 1 blue, 15 red; 15 red, 8 green",
                "5 blue, 5 green, 1 red; 9 red, 8 green, 9 blue; 10 red, 10 blue, 4 green; 3 blue, 17 red, 3 green; 3 blue, 4 red, 2 green",
                "2 blue, 10 red, 17 green; 6 red, 10 green, 10 blue; 3 blue, 6 green, 8 red; 9 green, 2 blue, 8 red; 13 green, 5 blue; 4 red, 18 green, 11 blue",
                "8 red, 3 blue, 6 green; 2 red, 8 green, 10 blue; 5 blue, 9 red, 9 green; 1 green, 15 red, 8 blue",
                "11 green, 19 red, 14 blue; 1 red, 19 green, 9 blue; 7 green, 8 red, 10 blue; 14 green, 8 blue, 15 red; 7 green, 3 red, 2 blue",
                "4 green, 9 blue, 4 red; 7 blue, 13 green, 2 red; 12 green, 10 blue, 10 red",
                "10 red, 2 green, 1 blue; 10 red, 10 green, 1 blue; 1 blue, 13 green; 1 blue, 2 green, 10 red; 1 blue, 7 red, 11 green; 10 red, 5 green",
                "3 blue, 2 green, 12 red; 5 blue, 7 red; 5 green, 14 red; 12 red, 7 green, 5 blue",
                "5 red, 1 blue, 3 green; 7 red, 8 green, 4 blue; 4 blue, 5 green, 17 red; 1 blue, 12 red",
                "2 green, 7 red, 1 blue; 11 green, 5 red; 4 red, 1 blue, 1 green; 11 green, 1 blue, 7 red",
                "10 red, 3 blue, 6 green; 1 blue, 5 red, 3 green; 6 blue, 11 red, 12 green; 10 green",
                "18 blue, 1 green, 1 red; 15 blue; 13 blue, 11 green, 4 red; 8 red, 1 green, 18 blue; 10 green, 7 blue, 8 red",
                "13 green, 15 blue; 6 blue, 4 red, 8 green; 6 red, 13 green, 11 blue; 2 red, 7 green, 13 blue; 12 green, 2 blue, 3 red; 6 red, 11 green, 1 blue",
                "2 red, 2 green; 3 green, 1 blue, 1 red; 1 blue, 4 green, 7 red; 4 red, 1 blue; 4 red, 5 green, 2 blue",
                "8 blue, 2 red, 5 green; 6 green, 2 blue, 3 red; 1 blue, 8 green, 4 red",
                "6 green, 6 blue, 3 red; 13 green, 1 red; 2 blue, 1 red, 1 green; 14 green, 1 blue, 1 red; 1 blue, 2 red, 9 green; 9 green, 2 blue, 4 red",
                "4 green, 6 blue, 1 red; 5 red, 3 blue; 6 red, 1 blue; 9 green, 5 blue, 7 red",
                "5 red, 5 green, 8 blue; 11 red, 3 blue, 8 green; 7 green, 9 blue, 11 red; 3 green, 2 blue, 12 red",
                "3 green, 3 red; 4 red, 1 green; 1 red, 6 green; 5 green; 5 red, 1 blue, 3 green; 3 red, 1 blue",
                "2 green, 2 blue; 7 red, 18 green; 2 blue, 7 red, 16 green; 7 red, 10 green",
                "3 blue, 4 red; 4 blue, 3 red, 3 green; 16 green",
                "1 blue, 2 red, 8 green; 9 blue, 4 green, 12 red; 10 green, 2 red; 5 blue, 11 red, 1 green; 10 green, 3 blue, 8 red; 5 red, 2 green",
                "15 red, 10 blue, 7 green; 4 blue, 9 red, 4 green; 4 red, 2 blue, 2 green; 11 green, 2 red; 8 blue, 2 green; 2 green, 8 red, 8 blue",
                "2 green, 3 blue, 1 red; 7 blue, 5 red; 7 blue",
                "3 green, 5 blue, 6 red; 9 green, 4 red; 13 red, 1 blue, 5 green; 4 blue, 13 red, 8 green",
                "7 green, 1 blue; 1 red, 14 blue, 4 green; 8 blue, 6 red; 14 green, 4 red",
                "6 red, 11 green, 7 blue; 1 blue, 6 red; 13 red, 7 blue, 3 green; 8 red, 6 blue, 15 green; 7 green, 6 blue, 4 red; 4 red, 1 blue, 20 green",
                "4 blue, 9 green; 15 red, 16 green, 3 blue; 1 green, 14 red, 3 blue; 3 red, 2 blue, 3 green; 4 green, 3 blue, 12 red",
                "5 green, 3 blue, 2 red; 4 green, 8 blue, 11 red; 6 red, 6 blue, 4 green; 8 red, 5 blue, 7 green; 6 blue, 6 green, 11 red; 2 blue, 3 green, 3 red",
                "15 blue, 16 green, 5 red; 10 blue, 3 red, 13 green; 4 red, 5 blue, 2 green; 1 red; 11 green, 5 red, 15 blue",
                "8 red, 9 blue, 12 green; 3 red, 2 blue, 14 green; 10 blue, 1 red, 18 green; 1 blue, 7 red, 16 green; 3 green, 4 red, 16 blue; 10 green, 6 red",
                "12 blue, 7 red, 16 green; 2 red, 9 blue, 15 green; 1 red, 11 blue, 11 green; 15 red, 16 blue, 2 green",
                "1 blue, 11 red, 6 green; 1 red, 2 blue, 5 green; 4 green, 2 red; 2 green, 12 red",
                "1 blue, 1 red; 2 red, 4 blue, 2 green; 1 blue, 2 green, 10 red; 8 red",
                "12 red, 1 green, 4 blue; 1 red, 5 blue, 1 green; 11 green, 16 red, 7 blue; 7 red, 1 blue, 1 green; 12 red, 11 green, 12 blue; 11 green, 6 red",
                "12 green, 8 red, 3 blue; 7 red, 10 green; 1 green, 7 blue, 1 red",
                "4 green, 1 red, 3 blue; 7 blue, 3 green, 3 red; 4 blue, 2 red, 3 green; 4 blue, 1 green",
                "2 green, 12 blue, 10 red; 5 blue, 7 red; 2 red, 6 green; 1 blue, 2 red, 6 green",
                "2 green, 4 blue, 4 red; 8 green, 10 red, 10 blue; 5 green, 8 blue, 10 red; 6 green, 2 red",
                "3 green, 2 blue, 11 red; 8 red, 11 green, 1 blue; 1 blue, 16 red; 5 red, 7 green, 16 blue; 12 red, 7 green, 9 blue; 4 red, 20 blue, 12 green",
                "3 red, 5 green; 2 blue, 4 green; 2 red, 12 green, 4 blue; 10 green, 1 blue, 1 red; 4 blue, 3 red",
                "1 blue, 1 green, 1 red; 5 green, 3 red, 1 blue; 1 blue, 6 green; 1 green; 1 red, 5 green, 2 blue; 1 blue, 1 red, 3 green",
                "7 green, 10 blue, 3 red; 10 green, 12 red, 12 blue; 18 red, 8 green, 14 blue; 3 red, 3 green, 10 blue; 3 red, 1 blue, 5 green; 1 green, 8 blue",
                "9 red, 3 blue; 14 blue, 8 red, 3 green; 14 blue, 5 green, 4 red",
                "2 blue, 3 red, 6 green; 11 green, 2 red, 1 blue; 17 green, 3 blue, 3 red; 1 red, 1 blue; 1 red, 2 blue, 19 green",
                "3 green, 2 blue, 3 red; 4 red, 5 blue, 8 green; 15 green, 1 red, 9 blue; 12 green, 3 blue, 2 red",
                "15 green, 7 red, 10 blue; 2 blue, 2 red, 1 green; 4 red, 1 green, 9 blue; 7 red, 14 blue, 5 green",
                "1 green, 3 blue, 1 red; 2 blue, 1 green; 1 blue, 2 green, 1 red",
                "2 green, 6 blue, 5 red; 5 blue, 2 red; 3 red, 13 blue; 9 blue, 10 red, 1 green",
                "6 green, 10 red, 2 blue; 7 red, 1 blue, 8 green; 4 blue, 3 red, 5 green; 4 green, 4 blue, 10 red",
                "8 red, 7 blue; 4 green, 3 red, 1 blue; 5 blue, 2 green",
                "15 green, 14 red; 12 red, 16 green, 2 blue; 8 red, 10 green; 1 green, 6 red; 8 green, 12 red",
                "4 blue, 4 green, 9 red; 1 blue, 17 green; 1 green; 15 green, 3 blue, 12 red; 11 red, 1 blue, 7 green; 7 blue, 13 red, 8 green",
                "10 blue, 12 red; 10 blue, 11 green, 8 red; 1 blue, 11 green, 7 red; 10 blue, 15 red, 5 green; 11 red, 8 green, 9 blue; 10 green, 3 blue",
                "1 blue, 2 red; 4 red, 1 green, 5 blue; 3 red, 2 green; 2 green, 2 blue; 1 red, 5 blue, 1 green; 4 blue, 1 red, 2 green",
                "1 red, 1 blue, 3 green; 2 green, 6 blue; 1 green, 13 blue, 1 red; 3 green, 15 blue",
                "16 blue, 7 green, 5 red; 5 green, 5 blue, 6 red; 3 green, 17 blue, 10 red; 13 blue, 2 red, 1 green",
                "12 red; 1 blue, 6 red, 1 green; 9 red, 2 blue, 1 green; 1 green, 2 blue, 1 red; 15 red, 1 blue; 1 blue",
                "11 red, 6 blue, 13 green; 4 blue, 2 red, 12 green; 2 blue, 8 green, 10 red",
                "2 red, 1 blue; 4 green; 7 green, 1 blue, 1 red; 5 green, 2 red; 1 blue, 2 red, 9 green; 2 green, 3 red",
                " 7 red, 11 blue; 10 red, 5 blue, 1 green; 7 red, 1 green, 13 blue; 9 red; 9 red, 19 blue; 9 red, 9 blue"
            };
        }
    }
}
