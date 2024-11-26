using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork._13
{
    internal class Building//базовый класс
    {
        public string addressBuilding { get; set; }

        public int lengthBuilding { get; set; }

        public int widthBuilding { get; set; }

        public int heightBuilding { get; set; }


        public Building(string addressBuilding, int lengthBuilding, int widthBuilding, int heightBuilding)
        {
            this.addressBuilding = addressBuilding;
            this.lengthBuilding = lengthBuilding;
            this.widthBuilding = widthBuilding;
            this.heightBuilding = heightBuilding;
        }

        public virtual string Print()
        {
            return $"Здание по адресу {addressBuilding} имеет габаритные размеры: длина - {lengthBuilding}м, ширина - {widthBuilding}м высота - {heightBuilding}м";
        }
    }
}
