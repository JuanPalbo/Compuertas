namespace Library.Tests;
using Logic_Gates_And_Or_Not;
public class Logic_Gates_And_Or_NotTests
{


[Test]
public void Test_Or_1()
{
    const bool valor1 = true;
    const bool valor2 = true;
    valor_funcion = CompuertaOr(valor1, valor2);
    Assert.AreEqual(true, valor_funcion);
}

[Test]
public void Test_Or_2()
{
    const bool valor1 = true;
    const bool valor2 = false;
    valor_funcion = CompuertaOr(valor1, valor2);
    Assert.AreEqual(true, valor_funcion);
}

[Test]
public void Test_Or_3()
{

    const bool valor1 = false;
    const bool valor2 = true;
    valor_funcion = CompuertaOr(valor1, valor2);
    Assert.AreEqual(true, valor_funcion);
}
[Test]
public void Test_Or_4()
{
    const bool valor1 = false;
    const bool valor2 = false;
    valor_funcion = CompuertaOr(valor1, valor2);
    Assert.AreEqual(false, valor_funcion);
}


[Test]
public void Test_And_1()
{

    const bool valor1 = true;
    const bool valor2 = true;
    valor_funcion = CompuertaAnd(valor1, valor2);
    Assert.AreEqual(true, valor_funcion);
}

[Test]
public void Test_And_2()
{

    const bool valor1 = true;
    const bool valor2 = false;
    valor_funcion = CompuertaAnd(valor1, valor2);
    Assert.AreEqual(false, valor_funcion);
}

[Test]
public void Test_And_3()
{

    const bool valor1 = false;
    const bool valor2 = true;
    valor_funcion = CompuertaAnd(valor1, valor2);
    Assert.AreEqual(false, valor_funcion);
}

[Test]
public void Test_And_4()
{

    const bool valor1 = false;
    const bool valor2 = false;
    valor_funcion = CompuertaAnd(valor1, valor2);
    Assert.AreEqual(false, valor_funcion);
}

[test]
public void Test_Not_1()
{
    const bool valor1= true
    bool valor_funcion = CompuertaNot(valor1);
    Assert.AreEqual (valor1_funcion , false)
}

[test]
public void Test_Not_2()
{
    const bool valor1= false
    bool valor_funcion = CompuertaNot(valor1);
    Assert.AreEqual (valor1_funcion , true )
}
}
