// Recurtion Methods
// Can be used instead of loops by method calling itself

private static void Main(string[] args) {
  Console.WriteLine(IncrementNumber(0)); //  Start with zero
}

private static int IncrementNumber(int number) {
  if(number < 5) {
    return IncrementNumber(number + 1); // Call method again with changed value
  } else {
    return number; //  When condition is true, return the value
  }
}
