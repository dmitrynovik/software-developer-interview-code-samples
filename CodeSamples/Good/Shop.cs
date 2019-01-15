using System.Collections.Generic;

namespace CodeSamples.Good
{
    public class Shop
    {
        public ICollection<string> ProductCodes { get; } = new HashSet<string>();

        public void AddProductCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                ProductCodes.Add(code);
            }
        }
    }
}
