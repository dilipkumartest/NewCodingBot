using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace
TestAutomationFramework.Tests
{
public class ReverseString
    {
     [Test]
      public  static void Reversestr()
      {
            string input = "HelloWorld";
            string reversed="";

            Console.WriteLine("Input String : " + input);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                  reversed += input.ElementAt(i);
            }
            Console.WriteLine("Reverse String : " + reversed);
      }
    }
}