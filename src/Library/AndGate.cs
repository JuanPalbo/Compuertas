namespace Library
{
    public class CompuertaAnd : ILogicGate
    {
        private bool input1;
        private bool input2;

        public CompuertaAnd(bool input1, bool input2)
        {
            this.input1 = input1;
            this.input2 = input2;
        }

        public bool Evaluate()
        {
            return input1 && input2; 
        }
    }
}
