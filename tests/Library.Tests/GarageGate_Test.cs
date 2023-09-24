using NUnit.Framework;
using Library;

namespace Library.Tests;

public class GarageGate_Test
{


    [Test]
    public void Test_Garage()
    {
        const bool a = false;
        const bool b = false;
        const bool c = true;
        ILogicGate valor_garage = new GarageGate(a,b,c);
        Assert.AreEqual(true, valor_garage.Evaluate());
    }


    [Test]
    public void Test_Garage2()
    {
        const bool a = true;
        const bool b = true;
        const bool c = true;
        ILogicGate valor_garage = new GarageGate(a, b, c);
        Assert.AreEqual(true, valor_garage.Evaluate());
    }
    [Test]
    public void Test_Garage_Falso()
    {
        const bool a = true;
        const bool b = false;
        const bool c = true;
        ILogicGate valor_garage = new GarageGate(a, b, c);
        Assert.AreEqual(false, valor_garage.Evaluate());
    }
}
