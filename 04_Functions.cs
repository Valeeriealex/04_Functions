using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

//namespace Tasks_IJunior
//{
    //internal class _04_Functions
    //{
    //    static void Main(string[] args)
    //    {
            //    //Будет 2 массива: 1) фио 2) должность.
            //    //Описать функцию заполнения массивов досье, функцию форматированного вывода, функцию поиска по фамилии и функцию удаления досье.  

            //    const string MenuFillOutADossier = "1";
            //    const string MenuConclusionOfTheDossier = "2";
            //    const string MenuDeletionOfDossier = "3";
            //    const string MenuSearchByName = "4";
            //    const string MenuExit = "5";

            //    string[] arrayNames = new string[6] { "Сидоров Петр Сидорович", "Петров Петр Петрович", "Александрова Александра Александровна", "Петров Питр Петрович", "Иванов Иван Иванович", "Иванов Иоан Иванович" };
            //    string[] arrayPosts = new string[6] { "директор", "менеджер", "программист", "директор", "менеджер", "программист" };
            //    bool isWorking = true;

            //    while (isWorking)
            //    {
            //        Console.WriteLine($"\nВыберете действие:\n" + MenuFillOutADossier + " добавить досье\n"
            //            + MenuConclusionOfTheDossier + " вывести все досье\n"
            //            + MenuDeletionOfDossier + " удалить досье\n" + MenuSearchByName + " поиск по фамилии\n"
            //            + MenuExit + " выйти\n");
            //        string userChose = Console.ReadLine();

            //        switch (userChose)
            //        {
            //            case MenuFillOutADossier:
            //                AddDossier(ref arrayNames, ref arrayPosts);
            //                break;

            //            case MenuConclusionOfTheDossier:
            //                PrintDossier(arrayNames, arrayPosts);
            //                break;

            //            case MenuDeletionOfDossier:
            //                DeleteDossier(ref arrayNames, ref arrayPosts);
            //                break;

            //            case MenuSearchByName:
            //                SearchByLastName(arrayNames, arrayPosts);
            //                break;

            //            case MenuExit:
            //                isWorking = false;
            //                break;
            //        }
            //    }
            //}

            //static void AddDossier(ref string[] arrayNames, ref string[] arrayPosts)
            //{
            //    Console.WriteLine("Введите ФИО сотрудника: ");
            //    string newName = Console.ReadLine();
            //    Console.WriteLine("Введите должность сотрудника: ");
            //    string newPost = Console.ReadLine();
            //    arrayNames = AddData(arrayNames, newName);
            //    arrayPosts = AddData(arrayPosts, newPost);
            //}

            //static string[] AddData(string[] array, string name)
            //{
            //    string[] tempArray = new string[array.Length + 1];

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        tempArray[i] = array[i];
            //    }

            //    tempArray[tempArray.Length - 1] = name;
            //    array = tempArray;
            //    return array;
            //}

            //static void PrintDossier(string[] arrayNames, string[] arrayPosts)
            //{
            //    int index = 1;

            //    for (int i = 0; i < arrayNames.Length; i++)
            //    {
            //        Console.Write($"[{index}] {arrayNames[i]} {arrayPosts[i]} - ");
            //        index++;
            //    }
            //}

            //static void SearchByLastName(string[] arrayNames, string[] arrayPosts)
            //{
            //    Console.WriteLine("Введите фамилию для поиска: ");
            //    string nameForSearch = Console.ReadLine();
            //    char delimiter = ' ';
            //    bool isNameExist = false;

            //    for (int i = 0; i < arrayNames.Length; i++)
            //    {
            //        string[] lastName = arrayNames[i].Split(delimiter);

            //        if (lastName[0].ToLower() == nameForSearch.ToLower())
            //        {
            //            Console.WriteLine($"Сотрудник с фамилией {nameForSearch}: {arrayNames[i++]}");
            //            isNameExist = true;
            //        }
            //    }

            //    if (isNameExist == false)
            //    {
            //        isNameExist = false;
            //        Console.WriteLine("Такой фамилии нет в массиве\n");
            //    }
            //}

            //static void DeleteDossier(ref string[] arrayNames, ref string[] arrayPosts)
            //{
            //    Console.WriteLine("Введите номер ФИО сотрудника для удаления: ");
            //    int nemberOfNameForDeletion = int.Parse(Console.ReadLine());

            //    if (nemberOfNameForDeletion > 0 && nemberOfNameForDeletion <= arrayNames.Length)
            //    {
            //        int index = nemberOfNameForDeletion - 1;
            //        arrayNames = RemoveData(arrayNames, index);
            //        arrayPosts = RemoveData(arrayPosts, index);
            //        Console.WriteLine($"Сотрудник с номером {nemberOfNameForDeletion} удален из массива: ");
            //        PrintDossier(arrayNames, arrayPosts);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Такого номера нет в массиве\n");
            //    }
            //}

            //static string[] RemoveData(string[] array, int name)
            //{
            //    string[] tempArray = new string[array.Length - 1];

            //    for (int i = 0; i < name - 1; i++)
            //    {
            //        tempArray[i] = array[i];
            //    }

            //    for (int i = name; i < tempArray.Length; i++)
            //    {
            //        tempArray[i] = array[i + 1];
            //    }

            //    array = tempArray;
            //    return array;

            //Разработайте функцию, которая рисует некий бар в определённой позиции. Она также принимает некий закрашенный процент.  

            //    int positionX = 0;
            //    int positionY = 5;
            //    char symbolHelth = '#';
            //    bool isWorking = true;

            //    while (isWorking)
            //    {
            //        Console.WriteLine("Введите максимальный %: ");
            //        int maxHelth = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine($"Введите % жизни не более {maxHelth}: ");
            //        int precentHelth = Convert.ToInt32(Console.ReadLine());

            //        DrawBar(maxHelth, symbolHelth, positionX, positionY, precentHelth);

            //        Console.WriteLine();
            //    }
            //}

            //static void DrawBar(int maxValue, char symbol, int positionX, int positionY, int precent)
            //{
            //    int minPrecent = 0;
            //    int maxPrecent = 100;
            //    char openingSymbol = '[';
            //    char closingSymbol = ']';
            //    char symbolEmptiness = '_';

            //    if (precent >= minPrecent && precent <= maxValue)
            //    {
            //        string bar = "";
            //        int precentHelth = maxValue * precent / maxPrecent;
            //        int precentEmptiness = maxPrecent - precentHelth;

            //        bar = FillBar(symbol, precentHelth);

            //        Console.SetCursorPosition(positionX, positionY);
            //        Console.Write(openingSymbol);
            //        Console.Write(bar);

            //        bar = FillBar(symbolEmptiness, precentEmptiness);

            //        Console.WriteLine(bar + closingSymbol);
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Введите число, которое не превышает {maxValue}% и не менее {minPrecent}%");
            //    }
            //}

            //static string FillBar(char symbolFilling, int precentFilling)
            //{
            //    string barFillingNew = new string(symbolFilling, precentFilling);

            //    return barFillingNew;
            //}

            //Написать функцию, которая запрашивает число у пользователя(с помощью метода Console.ReadLine() )
            //и пытается сконвертировать его в тип int(с помощью int.TryParse())
            //Если конвертация не удалась у пользователя запрашивается число повторно до тех пор, пока не будет введено верно.
            //После ввода, который удалось преобразовать в число, число возвращается.

            //    int number = ConvertNumber();

            //    Console.WriteLine($"\nЧисло {number} сконвертировано");
            //    Console.WriteLine();
            //}

            //static int ConvertNumber()
            //{
            //    bool isWorking = true;
            //    int number = 0;

            //    while (isWorking)
            //    {
            //        Console.WriteLine("\nВведите число для конвертации: ");
            //        string userNumber = Console.ReadLine();

            //        if (int.TryParse(userNumber, out number))
            //        {
            //            isWorking = false;
            //        }
            //        else
            //        {
            //            Console.Clear();
            //            Console.WriteLine($"{userNumber} не сконвертировано");
            //        }
            //    }

            //    return number;

            //Сделать игровую карту с помощью двумерного массива.
            //Сделать функцию рисования карты.
            //Помимо этого, дать пользователю возможность перемещаться по карте и взаимодействовать с элементами.

//            Console.CursorVisible = false;

//            char[,] map = CreateMap(out int pacmanX, out int pacmanY, out char pacman, out char wall, out char road, out int allStrawberry, out char strawberry);
//            DrawMap(map);

//            int collectStrawberry = 0;

//            bool isWotking = false;

//            while (isWotking == false)
//            {
//                int cursorPositionX = 10;
//                int cursorPositionY = 0;
//                Console.SetCursorPosition(cursorPositionX, cursorPositionY);
//                Console.Write($"Собранные ягодки: {collectStrawberry}");

//                HandleInput(ref pacmanX, ref pacmanY, map, wall, road);
//                DrawSymbol(pacmanX, pacmanY, pacman);

//                collectStrawberry = CollectStrawberry(map, collectStrawberry, strawberry, pacmanX, pacmanY);
//                isWotking = IsFinish(collectStrawberry, allStrawberry);
//            }

//            int cursorPositionExitX = 10;
//            int cursorPositionExitY = 2;
//            Console.SetCursorPosition(cursorPositionExitX, cursorPositionExitY);
//            Console.Write("Ура! Вы собрали все ягодки! ");
//        }

//        static char[,] CreateMap(out int pacmanX, out int pacmanY, out char pacman, out char wall, out char road, out int allStrawberry, out char strawberry)
//        {
//            pacmanX = 1;
//            pacmanY = 1;
//            pacman = '@';
//            wall = '#';
//            road = ' ';
//            strawberry = '.';
//            allStrawberry = 0;

//            char[,] map =
//            {
//                                        {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
//                                        {wall,pacman,road,strawberry,road,strawberry,road,road,road,wall},
//                                        {wall,wall,road,road,wall,wall,wall,strawberry,road,wall},
//                                        {wall,road,strawberry,road,road,wall,strawberry,road,road,wall,},
//                                        {wall,road,road,strawberry,road,road,road,road,strawberry,wall,},
//                                        {wall,wall,wall,wall,wall,wall,wall,wall,wall,wall},
//            };

//            for (int i = 0; i < map.GetLength(0); i++)
//            {
//                for (int j = 0; j < map.GetLength(1); j++)
//                {
//                    if (map[i, j] == pacman)
//                    {
//                        pacmanX = i;
//                        pacmanY = j;
//                    }
//                    else if (map[i, j] == strawberry)
//                    {
//                        map[i, j] = strawberry;
//                        allStrawberry++;
//                    }
//                }
//            }

//            return map;
//        }

//        static void DrawMap(char[,] map)
//        {
//            for (int x = 0; x < map.GetLength(0); x++)
//            {
//                for (int y = 0; y < map.GetLength(1); y++)
//                {
//                    {
//                        Console.Write($"{map[x, y]}");
//                    }
//                }

//                Console.Write("\n");
//            }
//        }

//        static void HandleInput(ref int pacmanX, ref int pacmanY, char[,] map, char wall, char road)
//        {
//            ConsoleKeyInfo pressedKey = Console.ReadKey(true);

//            GetDirection(pressedKey, out int directionX, out int directionY);

//            int movementX = pacmanX + directionX;
//            int movementY = pacmanY + directionY;

//            if (directionX != 0 || directionY != 0)
//            {
//                if (map[movementX, movementY] != wall)
//                {
//                    DrawSymbol(pacmanX, pacmanY, road);
//                    pacmanX = movementX;
//                    pacmanY = movementY;
//                }
//            }
//        }

//        static void GetDirection(ConsoleKeyInfo pressedKey, out int directionX, out int directionY)
//        {
//            directionX = 0;
//            directionY = 0;

//            int increase = +1;
//            int decrease = -1;

//            ConsoleKey upArrow = ConsoleKey.W;
//            ConsoleKey downArrow = ConsoleKey.S;
//            ConsoleKey leftArrow = ConsoleKey.A;
//            ConsoleKey rightArrow = ConsoleKey.D;

//            if (pressedKey.Key == upArrow)     
//                directionX = decrease;
//            else if (pressedKey.Key == downArrow)
//                directionX = increase;
//            else if (pressedKey.Key == leftArrow)
//                directionY = decrease;
//            else if (pressedKey.Key == rightArrow)
//                directionY = increase;
//        }

//        static void DrawSymbol(int positionX, int positionY, char symbol)
//        {
//            Console.SetCursorPosition(positionY, positionX);
//            Console.Write(symbol);
//        }

//        static int CollectStrawberry(char[,] map, int collectStrawberry, int strawberry, int pacmanX, int pacmanY)
//        {
//            if (map[pacmanX, pacmanY] == strawberry)
//            {
//                collectStrawberry++;
//            }

//            return collectStrawberry;
//        }

//        static bool IsFinish(int collectStrawberry, int allStrawberry)
//        {
//            return collectStrawberry == allStrawberry;
//        }
//    }
//}

//Реализуйте функцию Shuffle, которая перемешивает элементы массива в случайном порядке. 

//            int[] array = { 1, 2, 3, 4, 5 };

//            PrintArray(array);
//            Shuffle(array);
//            PrintArray(array);
//        }

//        static void PrintArray(int[] array)
//        {   
//            for (int i = 0; i < array.GetLength(0); i++)
//            {
//                Console.Write(array[i] + " ");
//            }

//            Console.WriteLine();
//        }

//        static void Shuffle(int[] array)
//        {
//            int arrayLength = array.Length;
//            Random random = new Random();      

//            while (arrayLength > 1)
//            {
//                int shuffle = random.Next(arrayLength--);
//                int temp = array[arrayLength];
//                array[arrayLength] = array[shuffle];
//                array[shuffle] = temp;
//            }
//        }
//    }
//}