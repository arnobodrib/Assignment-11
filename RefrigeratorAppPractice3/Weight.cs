using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    


    public class Weight
    {
        public int MaxWeight { get; set; }
        public List<int> ItemNo = new List<int>();
        public List<Double> WeightUnit = new List<double>();
        public double CurrentW=0;
        public double RemainW;

        public void AddItemWeight(int i, double w)
        {
            ItemNo.Add(i);
            WeightUnit.Add(w);

        }

        public double CurrentWeight(int i, double w)
        {
            CurrentW = CurrentW + Convert.ToDouble(i) * w;
            return CurrentW;

        }

        public double RemainWeight(int m)
        {
            RemainW = m - CurrentW;
            return RemainW;
        }



    }

    


}
