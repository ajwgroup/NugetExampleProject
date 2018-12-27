namespace NugetExampleProject
{
    /// <summary>
    /// An example class
    /// </summary>
    public static class ExampleClass
    {
        /// <summary>
        /// A function to return if the first number is greater than the second number.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static bool IsGreaterThan(this int firstNumber, int secondNumber)
        {
            return firstNumber > secondNumber;
        }
    }
}
