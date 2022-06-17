using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPlants.Model
{
    [Serializable]
    ///<summary>
    ///
    /// </summary>
    internal class Record
    {
        public string nameofplants { get; set; }
        public DateTime DateRecord { get; private set; }
        public string typeofplants { get; set; }

        public Record(string NameOfPlants, string PriceOfPlants)
        {
            nameofplants = NameOfPlants;
            DateRecord = DateTime.Now;
            typeofplants = PriceOfPlants;
        }
        public override string ToString()
        {
            return $"Дата добавления растения: {DateRecord}, " + $"Название растения: {nameofplants}\n" +
                   $"Тип растения: {typeofplants}\n";
        }
    }
}