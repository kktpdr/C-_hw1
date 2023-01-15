Console.WriteLine("Put a Number: "); 
   int numA = int.Parse(Console.ReadLine()); 
   Console.WriteLine("Put a Number: "); 
   int numB = int.Parse(Console.ReadLine()); 
   if (numA > numB ) Console.WriteLine($"max={numA}");
          else if (numB > numA) Console.WriteLine($"max={numB}");
          else Console.WriteLine("a=b"); 
   if (numA < numB ) Console.WriteLine($"min={numA}");
          else if (numB < numA) Console.WriteLine($"min={numB}");