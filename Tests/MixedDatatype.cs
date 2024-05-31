using NUnit.Framework;

namespace
TestAutomationFramework.Tests
{
public class MixedDatatype
    {

     [Test]
      public  static void Mixeddata()
      {
          object[] data ={2,"Hello", 4.3,'b'} ;
          Console.WriteLine("Programmatically prove if it is possible to store mixed datatypes such as int, string, float, char all in one array.");
          foreach(var element in data)
          {
              Console.WriteLine("Mixed data in an array: " + element);
          }
          } 




      }



    
}