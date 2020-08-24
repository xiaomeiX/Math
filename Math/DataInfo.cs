using System;


namespace Math
{
    public class DataInfo
    {
        public String Name { get; set; }
        public String Oper { get; set; }

        public int ValueOne { get; set; }
        public int ValueTwo { get; set; }

        public DataInfo()
        {
            this.Name = null;
            this.Oper = null;
            this.ValueOne = 0;
            this.ValueTwo = 0;

        }

        public DataInfo(string name, string op, int v1, int v2)
        {
            this.Name = name;
            this.Oper = op;
            this.ValueOne = v1;
            this.ValueTwo = v2;

        }

    }
}
