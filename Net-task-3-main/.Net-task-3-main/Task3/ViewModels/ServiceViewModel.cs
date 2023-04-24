using System.Collections.Generic;
using Task3.Models;

namespace Task3.ViewModels
{
    public class ServiceViewModel
    {
        public List<Feature> Features { get; set; }
        public List<SerFeature> SerFeatures { get; internal set; }
    }
}
