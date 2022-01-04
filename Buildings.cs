using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.Lesson4.Task1
{
    class Buildings
    {
        private int BuildingNumber;
        private double Height;
        private int Floor;
        private int FlatsNumber;
        private int EntranceNumber;
        const int FlatsInFloors = 5;
        private static int LastBuildingNumber;

        internal int GetBuildingNumber()
        {
            BuildingNumber = LastBuildingNumber + 1;
            return BuildingNumber;
        }

        internal double GetHeight()
        {
            return Height;
        }

        internal int GetFloor()
        {
            return Floor;
        }

        internal int GetFlatsNumber()
        {
            return FlatsNumber;
        }
        internal int GetEntranceNumber()
        {
            return EntranceNumber;
        }
        internal int SetBuildingNumber(int value)
        {
            return BuildingNumber = value;
        }

        internal double SetHeight(double value)
        {
            return Height = value;
        }

        internal int SetFloor(int value)
        {
            return Floor = value;
        }
        internal int SetFlatsNumber(int value)
        {
            return FlatsNumber = value;
        }

        internal int SetEntranceNumber(int value)
        {
            return EntranceNumber = value;
        }
        internal double CalculateFloorHeight(double Height, int Floor)
        {
            return Height * Floor;
        }

        internal int CalculateFlatsInEntrance(int Floors)
        {
            return Floors * FlatsInFloors;
        }
        internal int GetFlatsinFloor()
        {
            return FlatsInFloors;
        }


    }
}
