using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiFormsApp2
{
    [Serializable]
    /* 6.1 Create a separate class file to hold the four data items of the Data Structure (use the Data Structure
     * Matrix as a guide). Use auto-implemented properties for the fields which must be of type “string”. Save the 
     * class as “Information.cs”.
    */
    class Information : IComparable<Information>
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

        public Information()
        { }

        public Information(string name)
        {
            this.name = name;
        }

        public Information(string name, string category, string structure, string definition)
        {
            this.name = name;
            this.category = category;
            this.structure = structure;
            this.definition = definition;
        }

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }
        public string Structure { get => structure; set => structure = value; }
        public string Definition { get => definition; set => definition = value; }

        int IComparable<Information>.CompareTo(Information other)
        {
            return name.CompareTo(other.Name);
        }
    }
}
