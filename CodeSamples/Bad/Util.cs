using System;
using System.Diagnostics;
using System.Globalization;

namespace CodeSamples.Bad
{
    class FrequentFlyerService { }

    class PassengerService { }

    class PassengerModel { }

    class FrequentFlyerModel { }

    class Util
    {
        public bool IsEmpty(string str) => string.IsNullOrWhiteSpace(str);

        public int? ParseIntSafe(string input)
        {
            return int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out var result) ? 
                (int?)result : null;
        }

        public PassengerModel GetPassengerByName(string fullName)
        {
            // ... some code here ...
            return new PassengerModel();
        }

        public FrequentFlyerModel GetFrequentFlyerByName(string fullName)
        {
            // ... some code here ...
            return new FrequentFlyerModel();
        }

        public void ExecuteSafely(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Trace.TraceError(e.ToString());
            }
        }
    }
}
