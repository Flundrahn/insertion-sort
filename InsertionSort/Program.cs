using InsertionSort;

//TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

//int t = Convert.ToInt32(Console.ReadLine()!.Trim());

//for (int tItr = 0; tItr < t; tItr++)
//{
//   int n = Convert.ToInt32(Console.ReadLine()!.Trim());

//   int[] arr = Console.ReadLine()!
//       .TrimEnd()
//       .Split(' ')
//       .Select(arrTemp => Convert.ToInt32(arrTemp))
//       .ToArray();

//   var result = Result.CountFredSort(arr);

//   textWriter.WriteLine(result);
//}

//textWriter.Flush();
//textWriter.Close();


//var testArray3 = new int[] { 1, 5, 6, 2 };


var arr = CreateIntegerArray(100000, 10000000);

Console.WriteLine(Result.CountFredSort(arr));

int[] CreateIntegerArray(int length, int upperBound)
{
    var random = new Random();
    var arr = new int[length];
    for (var i = 0; i < length; i++)
    {
        arr[i] = random.Next(0, upperBound + 1);
    }

    return arr;
}

