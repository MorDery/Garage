using System.Collections.Generic;
using Utils;

namespace Ex03.GarageLogic
{
    class FuelVehicles : EnrgeyVehicles
    {
        FuelTypes m_FuelType;
        float m_CurrentFuelQuantity;
        float m_MaximumFuelQuantity;

        public void Refueling(FuelTypes i_FuelType, float i_AddFuel)
        {
            float newFuelQuantity = m_CurrentFuelQuantity + i_AddFuel;
            if(m_FuelType == i_FuelType && newFuelQuantity <= m_MaximumFuelQuantity)
            {
                m_CurrentFuelQuantity = newFuelQuantity;
            }
            else
            {
                ValueOutOfRangeException value = new ValueOutOfRangeException(0, m_MaximumFuelQuantity);
                throw value;
            }
        }
        public override void CreatEnrgey(float i_RemainingEnergy, float i_MaxEnergy)
        {
            if (m_CurrentFuelQuantity < 0 || m_CurrentFuelQuantity > m_MaximumFuelQuantity)
            {
                ValueOutOfRangeException value = new ValueOutOfRangeException(0, m_MaximumFuelQuantity);
                throw value;
            }
            else
            {
                m_CurrentFuelQuantity = i_RemainingEnergy;
            }
            m_MaximumFuelQuantity = i_MaxEnergy;
        }
        public FuelTypes FuelType
        {
            set
            {
                m_FuelType = value;
            }
        }
        public override List<string> GetDetails(List<string> io_Details)
        {
            io_Details.Add("Have Hazardous Materials:" + m_FuelType.ToString());
            io_Details.Add("Current Fuel Quantity:" + m_CurrentFuelQuantity);
            io_Details.Add("Maximum Fuel Quantity:" + m_MaximumFuelQuantity);
            return io_Details;
        }
    }
}
