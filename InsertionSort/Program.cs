// TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

// int t = Convert.ToInt32(Console.ReadLine()!.Trim());

// for (int tItr = 0; tItr < t; tItr++)
// {
//     int n = Convert.ToInt32(Console.ReadLine()!.Trim());

//     int[] arr = Console.ReadLine()!
//         .TrimEnd()
//         .Split(' ')
//         .Select(arrTemp => Convert.ToInt32(arrTemp))
//         .ToArray();

//     int result = Result.insertionSort(arr);

//     textWriter.WriteLine(result);
// }

// textWriter.Flush();
// textWriter.Close();

var testArray1 = new int[] { 4, 3, 2, 1 };
// var testArray2 = new int[] { 1, 1, 1, 2, 2 };
// var testArray3 = new int[] { 2, 1, 3, 1, 2 };

// Console.WriteLine(Result.DoFredSort(testArray1));

var testArray3 = testArray1[3..4];

foreach (var number in testArray3)
{
    Console.Write(number);
}
// Console.WriteLine("");

// // Array.Sort(testArray1, 0, 3);

// foreach (var number in Result.DoInsertionSort(testArray3))
// {
//     Console.Write(number);
// }

// Console.WriteLine(Result.insertionSort(testArray1));
// Console.WriteLine(Result.insertionSort(testArray2));
// Console.WriteLine(Result.insertionSort(testArray3));
