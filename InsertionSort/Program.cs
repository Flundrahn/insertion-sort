TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH")!, true);

int t = Convert.ToInt32(Console.ReadLine()!.Trim());

for (int tItr = 0; tItr < t; tItr++)
{
  int n = Convert.ToInt32(Console.ReadLine()!.Trim());

  int[] arr = Console.ReadLine()!
      .TrimEnd()
      .Split(' ')
      .Select(arrTemp => Convert.ToInt32(arrTemp))
      .ToArray();

  var result = Result.CountFiddyFiddySort(arr);

  textWriter.WriteLine(result);
}

textWriter.Flush();
textWriter.Close();
