using System;

class HelloWorld {
  //Public           : method can be accessed by anyone
  //Static           : method does not need to be instanced
  //Void             : method does not need to return anything
  //Main             : 'entry point' of the application
  //(string[] args) : method takes one argument, 'args', that is a string
  public static void Main (string[] args) {

    Console.WriteLine ("Hello World!");     //prints "Hello World! \n" to the console
    Console.ReadLine();                     //ReadLine so console doesnt close instantly after completion

  }
}
