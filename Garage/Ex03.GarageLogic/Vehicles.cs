using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    public abstract class Vehicles
    {
        string m_ModelName;
        string m_LicenseNumber;
        float m_RemainingEnergy;
        List<Wheels> m_VehiclesWheels;
        public EnrgeyVehicles m_EnrgeyType;

        public Vehicles(string i_ModelName, string i_LicenseNumber, float i_RemainingEnergy)
        {
            m_ModelName = i_ModelName;
            m_LicenseNumber = i_LicenseNumber;
            m_RemainingEnergy = i_RemainingEnergy;  
        }
        public void CreatWheels(int i_NumOfWheels, string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            Wheels wheel = new Wheels(i_ManufacturerName, i_CurrentAirPressure, i_MaxAirPressure);
            m_VehiclesWheels = new List<Wheels>();
            for (int i = 0; i < i_NumOfWheels; i++)
            {
                m_VehiclesWheels.Add(wheel);
            }
        }
        public string LicenseNumber
        {
            get
            {
                return m_LicenseNumber;
            }
            set
            {
                m_LicenseNumber = value;
            }
        }
        public List<Wheels> VehiclesWheels
        {
            get
            {
                return m_VehiclesWheels;
            }
            set
            {
                m_VehiclesWheels = value;
            }
        }
        public float RemainingEnergy
        {
            get
            {
                return m_RemainingEnergy;
            }
            set
            {
                m_RemainingEnergy = value;
            }
        }
        public EnrgeyVehicles EnrgeyType
        {
            get
            {
                return m_EnrgeyType;
            }
        }
        public List<string> GetVehicleDetails(List<string> io_Details)
        {

            io_Details.Add("Model Name:" + m_ModelName);
            io_Details.Add("License Number:" + m_LicenseNumber);
            io_Details= m_VehiclesWheels[0].GetDetails(io_Details);
            io_Details = GetDetails(io_Details);
            io_Details = m_EnrgeyType.GetDetails(io_Details);
            return io_Details;
        }
        public abstract List<string> GetDetails(List<string> io_Details);
    }
}

