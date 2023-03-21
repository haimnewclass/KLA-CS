// See https://aka.ms/new-console-template for more information
using KLA2;

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