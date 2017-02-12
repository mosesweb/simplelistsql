using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftSphinxly
{
    class Article
    {
        private String name;
        private String description;
        private float price;
        private int id;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }
        public float Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public int ID
        {
            set
            {
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public Article(String Name, String Desc, float Price)
        {
            this.name = Name;
            this.description = Desc;
            this.price = Price;
        }
        public Article()
        {
            this.name = "";
            this.description = "";
            this.price = 0;
        }
    }
}
