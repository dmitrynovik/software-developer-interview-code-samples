namespace CodeSamples.Bad
{
    class ArrayLengthZero
    {
        public string[] Names { get; set; }

        public bool AreThereAnyNames => Names?.Length != 0;
    }
}
