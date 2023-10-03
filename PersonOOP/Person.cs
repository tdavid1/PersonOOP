using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOOP
{
    internal abstract class Person
    {
        private string nev;
        private int kor;
        private string nem;

        public Person(string nev, int kor, string nem)
        {
            this.nev = nev;
            this.kor = kor;
            this.nem = nem;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Kor { get => kor; set => kor = value; }
        public string Nem{ get => nem; set => nem = value; }

        public abstract string bemutatkozas() 
        {
            return $"Hi, I'm {this.nev}, a {this.kor} year old {this.nem}.";
        }
        public abstract string getGoal() 
        { 
            return "My goal is: Live for the moment!";
        }
    }
}

