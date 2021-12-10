using System;

namespace W13__Jumat_Latihan
{
    class Swords
    {
       public string Name;
       public string subStat;
       public int subSTatValue;
       public bool isFiveStar;
       public int baseAtk;
        
    }
    class Polearms
    {
        public string Name;
        public string subStat;
        public int subSTatValue;
        public bool isFiveStar;
        public int baseAtk;
    }
    class Claymores
    {
        public string Name;
        public string subStat;
        public int subSTatValue;
        public bool isFiveStar;
        public int baseAtk;
    }
    class Catalysts
    {
        public string Name;
        public string subStat;
        public int subSTatValue;
        public bool isFiveStar;
        public int baseAtk;
    }
    class Bows
    {
        public string Name;
        public string subStat;
        public int subSTatValue;
        public bool isFiveStar;
        public int baseAtk;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Swords swords = new Swords();
            Polearms polearms = new Polearms();
            Claymores claymore = new Claymores();
            Catalysts catalysts = new Catalysts();
            Bows bows = new Bows();
        }
    }
}
