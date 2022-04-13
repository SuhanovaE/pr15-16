using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_16_2_
{
    class STUDENT
    {
        private string fio;
        private string group;
        private int physics;
        private int biology;
        private int math;
        private int russian;
        private int chemistry;


        public string FIO
        {
            get { return fio; }
            set { fio = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Physics
        {
            get { return physics; }
            set { physics = value; }
        }
        public int Biology
        {
            get { return biology; }
            set { biology = value; }
        }
        public int Math
        {
            get { return math; }
            set { math = value; }
        }
        public int Russian
        {
            get { return russian; }
            set { russian = value; }
        }
        public int Chemistry
        {
            get { return chemistry; }
            set { chemistry = value; }
        }

        public STUDENT()
        {
            fio = "Иванов И.И.";
            group = "ИСП.20А";
        }
        //конструктор с параметрами
        public STUDENT(string f, string g, int ph, int b, int m, int r, int ch)
        {
            fio = f;
            group = g;
            physics = ph;
            biology = b;
            math = m;
            russian = r;
            chemistry = ch;
        }
        //ввод инфо
        
        //вывод информации об объекте
        public string PrintInfo()
        {
            return $"Студент: {fio} " +
                $"Группа: {group} ";              
        }
        
}
}
