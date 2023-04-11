using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class CountriesModel
    {
        public Datum[] data { get; set; }
        public Link[] links { get; set; }
        public Metadata metadata { get; set; }
    }

    public class Metadata
    {
        public int currentOffset { get; set; }
        public int totalCount { get; set; }
    }

    public class Datum
    {
        public string code { get; set; }
        public string[] currencyCodes { get; set; }
        public string name { get; set; }
        public string wikiDataId { get; set; }
    }

    public class Link
    {
        public string rel { get; set; }
        public string href { get; set; }
    }

    //public class CountriesModel
    //{
    //    public Datum[] data { get; set; }
    //    public Link[] links { get; set; }
    //    public Metadata metadata { get; set; }
    //}

    //public class Metadata
    //{
    //    public int currentOffset { get; set; }
    //    public int totalCount { get; set; }
    //}

    //public class Datum
    //{
    //    public string code { get; set; }
    //    public string[] currencyCodes { get; set; }
    //    public string name { get; set; }
    //    public string wikiDataId { get; set; }
    //}

    //public class Link
    //{
    //    public string rel { get; set; }
    //    public string href { get; set; }
    //}
}