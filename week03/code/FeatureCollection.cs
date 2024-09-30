using System.Reflection.Metadata;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    public string Type { get; set; }
    public Feature[] Features { get; set; }

    public class Feature
    {
        public string Type { get; set; }
        public Property Properties { get; set; }
    }
    public class Property
    {
        public decimal mag { get; set; }
        public string place { get; set; }
    }
}
