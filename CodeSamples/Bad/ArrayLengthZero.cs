namespace CodeSamples.Bad
{
    class ArrayLengthZero
    {
        public string[] Names { get; set; }

        public bool AreThereAnyNames()
        {
            return Names?.Length != 0;
        }
    }
}
