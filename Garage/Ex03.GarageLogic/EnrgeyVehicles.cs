using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class EnrgeyVehicles
    {
        public abstract void CreatEnrgey(float i_RemainingEnergy, float i_MaxEnergy);
        public abstract List<string> GetDetails(List<string> io_details);
    }
}
