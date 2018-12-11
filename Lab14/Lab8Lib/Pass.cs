using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8Lib
{
    public class Pass : IComparable
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Place { get; set; }
        public string Prop { get; set; }
        public int PassNum { get; set; }
        private string passSer;
        public string PassSer
        {
            get { return passSer; }
            set
            {
                if (value.Length > 2)
                {
                    throw new InvalidSerException();
                }
                else
                {
                    passSer = value;
                }
            }
        }
        public bool HasMarried { get; set; }
        public Pass() {}

        public Pass(string name, string country, string region, string place, string prop, int passNum, string passSer, bool hasMarried)
        {
            Name = name;
            Country = country;
            Region = region;
            Place = place;
            Prop = prop;
            PassNum = passNum;
            PassSer = passSer;
            HasMarried = hasMarried;
        }
        public string Info()
        {
            return Name + ", " 
                + Country + ", " 
                + Region + ", "
                + Place + ", " 
                + Prop+", "
                + PassNum + ", "
                + PassSer + ", "
                + HasMarried + ", ";
        }
        public int CompareTo(object obj)
        {
            Pass t = obj as Pass;
            return string.Compare(this.Name, t.Name);

        }
    }
}
