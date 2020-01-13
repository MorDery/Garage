using System.Collections.Generic;
using Utils;

namespace Ex03.GarageLogic
{
    public class VehiclesGarage
    {
        string m_Name;
        string m_PhoneNumber;
        VehicleStatus m_Status;
        Vehicles m_Vehicle;

        public VehiclesGarage(string i_Name, string i_PhoneNumber, Vehicles i_Vehicle)
        {
            m_Name = i_Name;
            m_PhoneNumber = i_PhoneNumber;
            m_Status = VehicleStatus.InAmendment;
            m_Vehicle = i_Vehicle;

        }
        public VehicleStatus Status
        {
            get
            {
                return m_Status;
            }
            set
            {
                m_Status = value;
            }
        }
        public string GetLicenseNumber()
        {
            string licenseNumber = m_Vehicle.LicenseNumber;
            return licenseNumber;
        }
        public List<Wheels> GetVehiclesWheels()
        {
            return m_Vehicle.VehiclesWheels;
        }
        public float GetRemainingEnergy()
        {
            return m_Vehicle.RemainingEnergy;
        }
        public EnrgeyVehicles GetEnrgeyType()
        {
            return m_Vehicle.EnrgeyType;
        }
        public List<string> GetDetails()
        {
            List<string> details = new List<string>();
            details.Add("Name:" + m_Name);
            details.Add("Phone Number:" + m_PhoneNumber);
            details.Add("Status:" + m_Status.ToString());
            details = m_Vehicle.GetVehicleDetails(details);
            return details;
        }
    }
}
