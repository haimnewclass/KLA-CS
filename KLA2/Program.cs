// See https://aka.ms/new-console-template for more information
using KLA2;
using System.Collections.Generic;

KLA2.A.Manager manager = new KLA2.A.Manager();
KLA2.A.Employee emp = manager.CreateEmployee(122, "aaaa", 10);
manager.AddEmp(emp);














Manager manager = new();
manager.Run();
BeerCup beerCup = new BeerCup();
CoffeeCup coffeeCup = new CoffeeCup();
BaseCup baseCup = new BaseCup();
coffeeCup.Color = "BLACK";
coffeeCup.Capacity = 200;
coffeeCup.HasPlatte= true;

baseCup = coffeeCup;
string color = baseCup.Color;
baseCup.Color = "RED";

object o = coffeeCup;
object o1 = beerCup;

System.Collections.ArrayList arrayList = new System.Collections.ArrayList();



Item i1 = new Item("134535435635623");
i1.Price = 10;
i1.Name = "Cola";
i1.CountInStock = 100;

Item i2 = new Item("456");
i2.Price = 20;
i2.Name = "Bisli";
i2.CountInStock = 100;

i1.Purchase(10);
i2.Purchase(20);

StaticSample staticSample1 = new StaticSample();
StaticSample staticSample2 = new StaticSample();
staticSample1.Id= 1;
staticSample2.Id =2;
staticSample1.Print();
staticSample2.Print();
staticSample1.Print();
StaticSample.Count += 100;
staticSample2.Print();

StaticSample.FixCount(10);

PropSample propSample = new PropSample();
 
propSample.ChildCount = 5;
propSample.ChildCount = 25;
Console.WriteLine(propSample.ChildCount);

Console.WriteLine("Hello, World!");

Student student;

student = new Student(112, "sddsd");
student.Age = 3;
student.SetAge(5);
Student student2 = student;
student = new Student(234234);






Editor editor = new Editor();
int? StudentCount;
int a = 12 ;
int b;
student2.Run(editor, ref a,out b);
student2.Id++ ;

int c = int.Parse("123");
if(int.TryParse("12*3", out b))
{
    ///
}

student2 = null;

if (student2==null)
{
    student2 = new Student(134);
}
/// 
student2.Run(editor,ref a,out b);
StudentCount = 34;
StudentCount = null;
if (StudentCount==null)
{
    StudentCount = 90;
}

/// Heap
/// Stack 

Console.WriteLine();