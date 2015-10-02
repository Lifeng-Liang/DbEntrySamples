using System;
using Leafing.Data.Definition;

namespace OrmD
{
    [Cacheable, Serializable]
    public class SampleData : DbObjectModel<SampleData>
    {
        [Length(50)]
        public string Name { get; set; }

        public DateTime JoinDate { get; set; }

        public bool Enabled { get; set; }

        public string Addon { get; set; }

        public int Next { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var n = SampleData.FindById(1);
            Console.WriteLine(n == null);
        }
    }
}
