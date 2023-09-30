namespace ConsoleApp
{
    internal class ClassA
    {
        public int CLassAIntProperty { get;private set; } = 1;
        public string CLassAStringProperty { get; private set; } = "string";

        public ClassA(int i) 
        {
            CLassAIntProperty = i;
        }

        public override string ToString()
        {
            return CLassAIntProperty.ToString() + CLassAStringProperty;
        }
    }
}
