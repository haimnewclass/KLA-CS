// See https://aka.ms/new-console-template for more information
using KLA4;
using KLA4.Abs;

AbstractClass abstractClass = new AbstractClass();
abstractClass.Run();

InheritenceList inheritenceList = new InheritenceList();
inheritenceList.Add("111111");
inheritenceList.Add("222222");
inheritenceList.Add("666666");
int len = inheritenceList.Length;


PriceCalculate priceCalculate = new PriceCalculate();
priceCalculate.Run();




InterfaceSamples interfaceSamples = new InterfaceSamples();
interfaceSamples.Run();




Console.WriteLine("Hello, World!");
Exc Exc = new Exc();
try
{
    Exc.Run();
}
catch(Exception ex)
{

}
