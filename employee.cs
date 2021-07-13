using System;
class Employee {
    //Fields
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private double yearlysalary;
    private string employmentstatus;
    public string First;
    public string Last;
    public string Id;
    public int Age;


    public Employee()//Constructor with no parameters
    {
      First = firstname="Unknown";
      Last = lastname="Unknown";
      Id="Unknown";
      age=0;
      employmentstatus="active";
    }

    public Employee(string firstname, string lastname, int id, int age)
    {
      First = firstname;
      Last = lastname;
      Id = id.ToString();
      Age = age;
      employmentstatus = "active";
    }

    public void Intro()
    {
      Console.WriteLine("My name first name is " + First);
      Console.WriteLine("My name last name is " + Last);
      Console.WriteLine("My id is " + Id);
      Console.WriteLine("My age is " + Age);
      Console.WriteLine("My employment status is " + employmentstatus);
    }
}

