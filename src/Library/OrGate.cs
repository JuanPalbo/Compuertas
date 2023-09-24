namespace Library;

public class CompuertaOr: ILogicGate
{
    private bool input1;
    private bool input2;
    public CompuertaOr(bool input1, bool input2)
    {
        this.input1 = input1;
        this.input2 = input2;
    }
    public bool Evaluate()
    {
        return input1 || input2;
    }
}
