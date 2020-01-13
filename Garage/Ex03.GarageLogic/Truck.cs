using System.Collections.Generic;
using Utils;

namespace Ex03.GarageLogic
{
    class Truck : Vehicles
    {
        bool m_HaveHazardousMaterials;
        float m_VolumeOfCargo;

        public Truck(string i_ModelName, string i_LicenseNumber, EnrgeyVehicles i_EnrgeyType, float i_RemainingEnergy, string i_ManufacturerName, float i_CurrentAirPressure, bool i_HaveHazardousMaterials, float i_VolumeOfCargo)
        : base(i_ModelName, i_LicenseNumber, i_RemainingEnergy)
        {
            m_EnrgeyType = i_EnrgeyType;
            m_HaveHazardousMaterials = i_HaveHazardousMaterials;
            m_VolumeOfCargo = i_VolumeOfCargo;
            CreatWheels(12, i_ManufacturerName, i_CurrentAirPressure, 26);
            m_EnrgeyType.CreatEnrgey(i_RemainingEnergy, 110f);
            ((FuelVehicles)m_EnrgeyType).FuelType = FuelTypes.Soler;
           
        }
        public override List<string> GetDetails(List<string> io_Details)
        {
            io_Details.Add("Have Hazardous Materials:" + m_HaveHazardousMaterials.ToString());
            io_Details.Add("Volume Of Cargo:" + m_VolumeOfCargo);
            return io_Details;
        }
        public bool HaveHazardousMaterials
        {
            set
            {
                m_HaveHazardousMaterials = value;
            }
            get
            {
                return m_HaveHazardousMaterials;
            }
        }
        public float VolumeOfCargo
        {
            set
            {
                m_VolumeOfCargo = value;
            }
            get
            {
                return m_VolumeOfCargo;
            }
        }
    }
}
