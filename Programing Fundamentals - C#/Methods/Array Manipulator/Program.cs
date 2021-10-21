    using System;
    using System.Linq;

    namespace ArrayManipulator
    {
        class Program
        {
            static void Main(string[] args)
            {
                int[] array = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                string command = Console.ReadLine();
                while (command != "end")
                {
                    string[] specialCommand = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    string action = specialCommand[0];
                
                
                    if (action == "exchange")
                    {
                        int index = int.Parse(specialCommand[1]);

                        if (index >= array.Length || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                            command = Console.ReadLine();
                            continue;
                        }
                        MethodExchange(array, index);                   
                    }
                    else if (action == "max")
                    {
                        string evenOddCommand = specialCommand[1];
                        int evenOddnumber = MethodforEvenOdd(evenOddCommand);
                        int maxIndex = MethodForMax(array, evenOddnumber);
                        MethodForMinMax(maxIndex);
                    }
                    else if (action == "min")
                    {
                        string evenOddCommand = specialCommand[1];
                        int evenOddnumber = MethodforEvenOdd(evenOddCommand);
                        int minIndex = MethodForMin(array, evenOddnumber);
                        MethodForMinMax(minIndex); 
                    }
                    else if (action == "first")
                    {
                        int countCommand = int.Parse(specialCommand[1]);
                        int evenOddNumber = MethodforEvenOdd(specialCommand[2]);

                        if (countCommand > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            command = Console.ReadLine();
                            continue;
                        }

                        int[] firstNumbers = MethodForFirstNumbers(array, evenOddNumber, countCommand);
                        MethodForNewArrays(firstNumbers);
                    }
                    else if (action == "last")
                    {
                        int countCommand = int.Parse(specialCommand[1]);
                        int evenOddNumber = MethodforEvenOdd(specialCommand[2]);

                        if (countCommand > array.Length)
                        {
                            Console.WriteLine("Invalid count");
                            command = Console.ReadLine();
                            continue;
                        }

                        int[] lastNumbers = MethodForLastNumbers(array, evenOddNumber, countCommand);
                        MethodForNewArrays(lastNumbers);
                    }
                
                    command = Console.ReadLine();
                }
                MethodForNewArrays(array);
            }
     

            static int[] MethodForLastNumbers(int[] array, int evenOddNumber, int countCommand)
            {
                int arrayLength = 0;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (arrayLength == countCommand)
                    {
                        break;
                    }

                    if (array[i] % 2 == evenOddNumber)
                    {
                        arrayLength++;
                    }
                }

                int[] lastNumbers = new int[arrayLength];
                int counter = arrayLength - 1;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (arrayLength == 0)
                    {
                        break;
                    }
                    if (array[i] % 2 == evenOddNumber)
                    {
                        lastNumbers[counter--] = array[i];
                        arrayLength--;
                    }
                }

                return lastNumbers;
            }

            static int[] MethodForFirstNumbers(int[] array, int evenOddNumber, int countCommand)
            {
                int arrayLength = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (arrayLength == countCommand)
                    {
                        break;
                    }

                    if (array[i] % 2 == evenOddNumber)
                    {
                        arrayLength++;
                    }
                }

                int[] firstNumbers = new int[arrayLength];
                int counter = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (arrayLength == 0)
                    {
                        break;
                    }
                    if (array[i] % 2 == evenOddNumber)
                    {
                        firstNumbers[counter++] = array[i];
                        arrayLength--;
                    }
                }
                return firstNumbers;
            }

            static int MethodForMin(int[] array, int oddEven)
            {
                int minIndex = -1;
                int minNumber = int.MaxValue;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] < minNumber && array[i] % 2 == oddEven)
                    {
                        minNumber = array[i];
                        minIndex = i;
                    }
                }

                return minIndex;
            }

            static int MethodForMax(int[] array, int oddEven)
            {
                int maxIndex = -1;
                int maxNumber = int.MinValue;

                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] > maxNumber && array[i] % 2 == oddEven)
                    {
                        maxNumber = array[i];
                        maxIndex = i;
                    }
                }

                return maxIndex;
            }

            static void MethodExchange(int[] array, int index)
            {
                int[] leftArray = new int[index + 1];
                int[] rightArray = new int[array.Length - (index + 1)];

                for (int i = 0; i < leftArray.Length; i++)
                {
                    leftArray[i] = array[i];
                }
                int counter = 0;
                for (int i = index + 1; i < array.Length; i++)
                {
                    rightArray[counter++] = array[i];
                }
                for (int i = 0; i < rightArray.Length; i++)
                {
                    array[i] = rightArray[i];
                }
                counter = 0;
                for (int i = array.Length - (index + 1); i < array.Length; i++)
                {
                    array[i] = leftArray[counter++];
                }
            }
            static int MethodforEvenOdd(string evenOddCommand)
            {
                int number = 0;
                if (evenOddCommand == "odd")
                {
                    number = 1;
                }

                return number;
            }
            static void MethodForMinMax(int maxIndex)
            {
                if (maxIndex == -1)
                {
                    Console.WriteLine("No matches");
                }
                else
                {
                    Console.WriteLine(maxIndex);
                }
            }
            private static void MethodForNewArrays(int[] firstNumbers)
            {
                if (firstNumbers.Length == 0)
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine($"[{string.Join(", ", firstNumbers)}]");
                }
            }
        }
    }
