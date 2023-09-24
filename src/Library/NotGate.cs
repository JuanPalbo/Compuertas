namespace Library;

public class CompuertaNot: ILogicGate
{
    private bool input;

    public CompuertaNot(bool input)
    { 
        this.input = input;
    }

    public bool Evaluate()
    {
        return !input;
    }
}
