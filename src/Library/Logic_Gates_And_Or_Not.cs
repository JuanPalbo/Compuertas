namespace Logic_Gates_And_Or_Not
public bool CompuertaNot(bool Input)
{
    bool Input_negado = !(Input);
    return Input_negado;
}

public bool CompuertaAnd(bool Input1, bool Input2)
{
    bool Output_And = Input1 && Input2;
    return Output_And;
}

public bool CompuertaOr(bool Input1, bool Input2)
{
    bool Output_Or = Input1 || Input2;
    return Output_Or;
}


