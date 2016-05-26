using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    public class Person
    {
        private string name;
        private int age;

        public event EventHandler<ChangeNameEventArg> OnChangeName;
        public event EventHandler OnChangeAge;

        public string Name
        {
            get { return name; }
            set
            {
                if (OnChangeName != null)
                {
                    OnChangeName(this, new ChangeNameEventArg(Name,value));
                }
                name = value;
                
            }


        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    if (OnChangeAge != null)
                    {
                        OnChangeAge(this,new EventArgs());
                    }
                    else
                    {
                        throw new InvalidAgeExeption();
                    }
                }
                else
                {
                    if (OnChangeAge != null)
                    {
                        OnChangeAge(this,new EventArgs());
                    }
                    this.age = value;
                }

            }

        }

        public Person(string name,int age)
        {
            if (age < 0 || age > 100) throw new InvalidAgeExeption();
            this.name = name;
            this.age = age;
        }
    }
}
