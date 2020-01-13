using System.Collections.Generic;
using Utils;

namespace Ex03.GarageLogic
{
    class Motorcycle : Vehicles
    {
        LicenseTypes m_LicenseType;
        int m_EngineCapacity;
        public Motorcycle (string i_ModelName, string i_LicenseNumber,EnrgeyVehicles i_EnrgeyType, float i_RemainingEnergy, LicenseTypes i_LicenseType, int i_EngineCapacity, string i_ManufacturerName, float i_CurrentAirPressure)
            :base(i_ModelName, i_LicenseNumber, i_RemainingEnergy)
        {
            m_EnrgeyType = i_EnrgeyType;
            m_LicenseType = i_LicenseType;
            m_EngineCapacity = i_EngineCapacity;
            CreatWheels(2, i_ManufacturerName, i_CurrentAirPressure, 33);
            if(i_EnrgeyType is ElectricVehicles)
            {
                m_EnrgeyType.CreatEnrgey(i_RemainingEnergy, 1.4f);
            }
            else
            {
                m_EnrgeyType.CreatEnrgey(i_RemainingEnergy, 8f);
                ((FuelVehicles)m_EnrgeyType).FuelType = FuelTypes.Octan95;
            }
        }
        public override List<string> GetDetails(List<string> io_Details)
        {
            io_Details.Add("License Type:" + m_LicenseType.ToString());
            io_Details.Add("Engine Capacity:" + m_EngineCapacity);
            return io_Details;
        }
        public LicenseTypes LicenseType
        {
            get
            {
                return m_LicenseType;
            }
            set
            {
                m_LicenseType = value;
            }
        }
        public int EngineCapacity
        {
            get
            {
                return m_EngineCapacity;
            }
            set
            {
                m_EngineCapacity = value;
            }
        }

    }
}
