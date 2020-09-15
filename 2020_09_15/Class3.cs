using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_09_15
{
    class Drama 
    {
        public string title;

        private string dre;
        private string maleActor;
        public string MaleActor 
        {
            get { return maleActor; }
            set { maleActor = value; }
        }
        //private string femalActor;
        //public string FemalActor
        //{
        //    get { return femalActor; }
        //    set { femalActor = value; }
        //}

        public string FemalActor { get; set; }
        public string Dre { get => dre; set => dre = value; }
    }

    class Class3
    {
        static void Main()
        {
            
        }
    }
}
