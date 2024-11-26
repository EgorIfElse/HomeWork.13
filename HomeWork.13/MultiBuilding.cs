using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork._13
{
    sealed class MultiBuilding : Building//класс наследник
    {
        public int floorBuilding { get; set; }

        public MultiBuilding(string addressBuilding, int lengthBuilding, int widthBuilding, int heightBuilding, int floorBuilding)

        : base(addressBuilding, lengthBuilding, widthBuilding, heightBuilding)
        {
            this.floorBuilding = floorBuilding;
        }

        public override string Print()
        {
            string multibuildung = base.Print();
            return multibuildung + $",количество этажей {floorBuilding}";
        }



    }
}
