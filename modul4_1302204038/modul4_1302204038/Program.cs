using System;
using System.Collections.Generic;

namespace modul4_1302204038
{
    class main
    {
        static void Main(string[] args)
        {
            SimpleDataBase<int> ab = new SimpleDataBase<int>();
            ab.AddNewData(12);
            ab.AddNewData(34);
            ab.AddNewData(56);
            ab.PrintAllData();
        }
    }

    class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            this.storedData = new List<T>();
            this.inputDates = new List<DateTime>();
        }

        public void AddNewData(T newData)
        {
            this.storedData.Add(newData);
            this.inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for(int i = 0; i < this.inputDates.Count; i++)
            {
                Console.WriteLine("Data " + i + "berisi" + this.storedData[i] + 
                    "yang disimpan pada waktu UTC : " + this.inputDates[i]);
            }
        }
    }
}
