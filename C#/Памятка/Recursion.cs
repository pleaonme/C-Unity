// Recurtion Methods
// Can be used instead of loops by method calling itself

private static void Main(string[] args) {
  Console.WriteLine(IncrementNumber(0, 10, 2)); //  Start with zero, go by 2, end with 10
}

private static int IncrementNumber(int number, int maxNumber, int incrementalNumber) {
  if(number < 5) {
    return IncrementNumber(number + incrementalNumber, maxNumber, incrementalNumber); // Call method again with changed value
  } else {
    return number; //  When condition is true, return the value
  }
}
