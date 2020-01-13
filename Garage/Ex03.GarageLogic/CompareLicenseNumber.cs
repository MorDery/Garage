using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    class CompareLicenseNumber : IComparer<VehiclesGarage>
    {
        public int Compare(VehiclesGarage i_Vehicles1, VehiclesGarage i_Vehicles2)
        {

            if (i_Vehicles1 == null || i_Vehicles2 == null)
            {
                return 0;
            }
            return (i_Vehicles1.GetLicenseNumber()).CompareTo(i_Vehicles2.GetLicenseNumber());

        }
    }
}
