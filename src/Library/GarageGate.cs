namespace Library;

public class GarageGate : ILogicGate
{
    private bool A;
    private bool B;
    private bool C;

    public GarageGate(bool input1, bool input2, bool input3)
    {
        A = input1;
        B = input2;
        C = input3;
    }

    public bool Evaluate()
    {
        ILogicGate eval = new CompuertaAnd(A, B);
        bool state1;
        bool state2;
        if (eval.Evaluate())
        {
            state1 = true;
            eval = new CompuertaAnd(state1, C);
            return eval.Evaluate();
        }
        if(C)
        {
            eval = new CompuertaNot(A);
            state1 = eval.Evaluate();
            eval = new CompuertaNot(B);
            state2 = eval.Evaluate();
            eval = new CompuertaAnd(state1, state2);
            return eval.Evaluate();
        }
        return false;
    }
}