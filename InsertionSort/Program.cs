//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

//int t = Convert.ToInt32(Console.ReadLine()!.Trim());

//for (int tItr = 0; tItr < t; tItr++)
//{
//    int n = Convert.ToInt32(Console.ReadLine()!.Trim());

//    List<int> arr = Console.ReadLine()!
//        .TrimEnd()
//        .Split(' ')
//        .Select(arrTemp => Convert.ToInt32(arrTemp))
//        .ToList();

//    var result = Result.CountInsertionSort(arr);

//    textWriter.WriteLine(result);
//}

// textWriter.Flush();
// textWriter.Close();

var testArray3 = new List<int> { 1, 5, 6, 2 };

Console.WriteLine(Result.CountInsertionSort(testArray3));
