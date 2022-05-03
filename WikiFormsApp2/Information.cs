using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiFormsApp2
{
    class Information
    {
        private string name;
        private string category;
        private string structure;
        private string definition;

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
    }
}
