namespace Prepare
{
    public class Class1
    {
        public void Run()
        {
            int a = 12;
            int? b = null;

            int g = b==null ? 1 : 2;

            b ??= 9;
            Class1 c = null;
            c??= new Class1();
            Console.WriteLine(b??=9);
        }
    }
}