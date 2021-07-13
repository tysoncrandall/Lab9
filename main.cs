using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Object Oriented Programming - Employee");

    Employee unknown = new Employee();
    unknown.Intro(); 

    Employee john = new Employee("john", "smith", 1234, 45);
    john.Intro();
  }
}