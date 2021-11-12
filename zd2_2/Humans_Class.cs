using System;
using System.Collections.Generic;
using System.Text;

namespace zd2_2
{
    public class Humans
    {
        public string Family { get; set; }
        public string Name { get; set; }
        public string Otch { get; set; }
        public int Age { get; set; }
        public int Ves { get; set; }

            public Humans(string Family1, string Name1, string Otch1, int Age1, int Ves1)
            {
                this.Family = Family1;
                this.Name = Name1;
                this.Otch = Otch1;
                this.Age = Age1;
                this.Ves = Ves1;
            }

            //get
            public string getName()
            {
                return this.Name;
            }
            public string getFamily()
            {
                return this.Family;
            }
            public string getOtch()
            {
                return this.Otch;
            }
            public int getAge()
            {
                return this.Age;
            }
            public int getVes()
            {
                return this.Ves;
            }
            //set
            public void setName(string Name)
            {
                this.Name = Name;
            }
            public void setFamily(string Family)
            {
                this.Family = Family;
            }
            public void setOtch(string Otch)
            {
                this.Otch = Otch;
            }
            public void setAge(int Age)
            {
                this.Age = Age;
            }
            public void getVes(int Ves)
            {
                this.Ves = Ves;
            }
    }
}
