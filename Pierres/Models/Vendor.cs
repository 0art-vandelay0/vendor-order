using System.Collections.Generic;

namespace Pierres.Models
{
    public class Vendor
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }

        public Vendor(string vendorName, string vendorDescription)
        {
            Name = vendorName;
            Description = vendorDescription;
            _instances.Add(this);
            Id = _instances.Count;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
    }

}