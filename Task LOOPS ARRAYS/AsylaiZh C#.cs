//int[] numbers = { 3, 7, 2, 9, 5, 1 };
//int sum = 0;
//foreach (int number in numbers)
//{
//    sum += number;
//}
//Console.WriteLine($"The sum of the numbers is: {sum}");

//Task2
//int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
//Array.Sort(temps);
//int min = temps[0];
//int max = temps[temps.Length - 1];
//Console.WriteLine("Min = " + min + ", Max = " + max);

//int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
//int min = temps[0];
//int max = temps[0];
//foreach (int temp in temps)
//{
//    min = Math.Min(min, temp);
//    max = Math.Max(max, temp);
//}
//Console.WriteLine("Min = " + min + ", Max = " + max);

//Task3
//string[] words = { "apple", "banana", "cherry", "date" };
//for (int i = 0; i < words.Length / 2; i++)
//{
//    string temp = words[i]; 
//    words[i] = words[words.Length - 1 - i]; 
//    words[words.Length - 1 - i] = temp; 
//}
//foreach (string word in words)
//{
//    Console.Write(word + " ");
//}

//string[] words = { "apple", "banana", "cherry", "date" };

//Array.Reverse(words);

//foreach (string word in words)
//{
//    Console.Write(word + " ");
//}

//Task4
//int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
//int evenCount = 0;
//int oddCount = 0;
//for (int i = 0; i < data.Length; i++)
//{
//    if (data[i] % 2 == 0)
//    {
//        evenCount++;
//    }
//    else
//    {
//        oddCount++;
//    }
//}
//Console.WriteLine("Even = " + evenCount);
//Console.WriteLine("Odd = " + oddCount);

//Task5
//int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
//List<int> unique = new();
//foreach (int num in raw)
//{
//    if (!unique.Contains(num))
//    {
//        unique.Add(num);
//    }
//}
//int[] result = unique.ToArray();
//foreach (int num in result)
//{
//    Console.Write(num + " ");
//}

//Task6
//int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
//int k = 3;
//k = k % arr.Length;
//int[] rotated = new int[arr.Length];
//int index = 0;
//for (int i = k; i < arr.Length; i++) rotated[index++] = arr[i];
//for (int i = 0; i < k; i++) rotated[index++] = arr[i];
//foreach (int num in rotated) Console.Write(num + " ");

//Task7
//Console.WriteLine(IsPalindrome("madam"));
//Console.WriteLine(IsPalindrome("hello"));
//Console.WriteLine(IsPalindrome("racecar"));
//Console.WriteLine(IsPalindrome("abba"));
//static bool IsPalindrome(string s)
//{
//    for (int i = 0; i < s.Length / 2; i++)
//        if (s[i] != s[s.Length - 1 - i]) return false;
//    return true;
//}

//Task8
//Console.WriteLine(Factorial(5));
//Console.WriteLine(Factorial(7));
//Console.WriteLine(Factorial(0));
//static long Factorial(int n)
//{
//    long result = 1;
//    for (int i = 2; i <= n; i++) result *= i;
//    return result;
//}

//Task9
//for (int i = 1; i <= 20; i++) Console.WriteLine(FizzBuzz(i));

//static string FizzBuzz(int n)
//{
//    if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz";
//    else if (n % 3 == 0) return "Fizz";
//    else if (n % 5 == 0) return "Buzz";
//    else return n.ToString();

//Task10
//double[] celsius = { 0, 20, 37, 100, -40 };

//foreach (double c in celsius)
//{
//    double f = ToFahrenheit(c);
//    Console.WriteLine(c + "°C = " + f + "°F");
//}
//static double ToFahrenheit(double c) => c * 9 / 5 + 32;
//static double ToCelsius(double f) => (f - 32) * 5 / 9;
