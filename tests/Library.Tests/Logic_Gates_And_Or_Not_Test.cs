using NUnit.Framework;

namespace Library.Tests;
public class LogicGatesAndOrNotTests
{


    [Test]
    public void Test_Or_1()
    {
        const bool valor1 = true;
        const bool valor2 = true;
        ILogicGate valor_funcion = new CompuertaOr(valor1, valor2);
        Assert.AreEqual(true, valor_funcion.Evaluate());
    }

    [Test]
    public void Test_Or_2()
    {
        const bool valor1 = true;
        const bool valor2 = false;
        ILogicGate valor_funcion = new CompuertaOr(valor1, valor2);
        Assert.AreEqual(true, valor_funcion.Evaluate());
    }

    [Test]
    public void Test_Or_3()
    {

        const bool valor1 = false;
        const bool valor2 = true;
        ILogicGate valor_funcion = new CompuertaOr(valor1, valor2);
        Assert.AreEqual(true, valor_funcion.Evaluate());
    }
    [Test]
    public void Test_Or_4()
    {
        const bool valor1 = false;
        const bool valor2 = false;
        ILogicGate valor_funcion = new CompuertaOr(valor1, valor2);
        Assert.AreEqual(false, valor_funcion.Evaluate());
    }


    [Test]
    public void Test_And_1()
    {

        const bool valor1 = true;
        const bool valor2 = true;
        ILogicGate valor_funcion = new CompuertaAnd(valor1, valor2);
        Assert.AreEqual(true, valor_funcion.Evaluate());
    }

    [Test]
    public void Test_And_2()
    {

        const bool valor1 = true;
        const bool valor2 = false;
        ILogicGate valor_funcion = new CompuertaAnd(valor1, valor2);
        Assert.AreEqual(false, valor_funcion.Evaluate());
    }

    [Test]
    public void Test_And_3()
    {

        const bool valor1 = false;
        const bool valor2 = true;
        ILogicGate valor_funcion = new CompuertaAnd(valor1, valor2);
        Assert.AreEqual(false, valor_funcion.Evaluate());
    }

    [Test]
    public void Test_And_4()
    {

        const bool valor1 = false;
        const bool valor2 = false;
        ILogicGate valor_funcion = new CompuertaAnd(valor1, valor2);
        Assert.AreEqual(false, valor_funcion.Evaluate());
    }

    [Test]
    public void Test_Not_1()
    {
        const bool valor1 = true;
        ILogicGate valor_funcion = new CompuertaNot(valor1);
        Assert.AreEqual(false, valor_funcion.Evaluate());
    }

    [Test]
    public void Test_Not_2()
    {
        const bool valor1 = false;
        ILogicGate valor_funcion = new CompuertaNot(valor1);
        Assert.AreEqual(true, valor_funcion.Evaluate());
    }
}
