using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonOOP
{
    internal class Student : Person
    {
        private string iskola;
        private int hilyányzotnapok;
        public Student(string nev, int kor, string nem, string iskola) : base(nev, kor, nem)
        {
            this.iskola = iskola;
            this.hilyányzotnapok = 0;
        }
        public override string getGoal()
        {
            return "Be a junior software developer.";
        }
        public override string bemutatkozas()
        {
            throw new NotImplementedException();
        }
        public void skipday()
        {
            hilyányzotnapok++;
        }
    }
}
