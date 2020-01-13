using System.Collections.Generic;
using Utils;


namespace Ex03.GarageLogic
{
    public class Garage
    {
        public List<VehiclesGarage> m_VehiclesGarage = new List<VehiclesGarage>();
        
        public bool HaveVehicleInGarage(string i_LicenseNumber)
        {
            bool isExists = false;
            string licenseNumber;
            foreach (VehiclesGarage vehiclesGarage in m_VehiclesGarage)
            {
                licenseNumber = vehiclesGarage.GetLicenseNumber();
                if (licenseNumber == i_LicenseNumber)
                {
                    isExists = true;
                    vehiclesGarage.Status = VehicleStatus.InAmendment;
                    break;
                }
            }
            return isExists;
        }
        public List<VehiclesGarage> VehiclesInGarages()
        {
            m_VehiclesGarage.Sort(new CompareLicenseNumber());
            return m_VehiclesGarage;
        }
        public List<VehiclesGarage> VehiclesInGaragesStatus()
        {
            m_VehiclesGarage.Sort(new CompareStatus());
            return m_VehiclesGarage;
        }
        public bool ChangeStatus(string i_LicenseNumber, VehicleStatus i_Status )
        {
            string licenseNumber;
            bool isChange = false;
            foreach (VehiclesGarage vehiclesGarage in m_VehiclesGarage)
            {
                licenseNumber = vehiclesGarage.GetLicenseNumber();
                if (licenseNumber== i_LicenseNumber)
                {
                    vehiclesGarage.Status = i_Status;
                    isChange = true;
                    break;
                }
            }
            return isChange;
        }
        public bool BlowingWheelsToTheMaximum(string i_LicenseNumber)
        {
            string licenseNumber;
            bool isBlowing = false;
            List<Wheels> wheels = null;
            foreach (VehiclesGarage vehiclesGarage in m_VehiclesGarage)
            {
                licenseNumber = vehiclesGarage.GetLicenseNumber();
                if (licenseNumber == i_LicenseNumber)
                {
                    wheels = vehiclesGarage.GetVehiclesWheels();
                    isBlowing = true;
                    break;
                }
            }
            if(wheels != null)
            {
                foreach(Wheels vehicleWeels in wheels)
                {
                    vehicleWeels.MaxAirPressure();

                }
            }
            return isBlowing;
        }
        public void FuelingVehicle(string i_LicenseNumber, FuelTypes i_FuelType, float i_AddFuel)
        {
            string licenseNumber;
            EnrgeyVehicles enrgey;
            foreach (VehiclesGarage vehiclesGarage in m_VehiclesGarage)
            {
                licenseNumber = vehiclesGarage.GetLicenseNumber();
                if (licenseNumber == i_LicenseNumber)
                {
                    enrgey = vehiclesGarage.GetEnrgeyType();
                    ((FuelVehicles)enrgey).Refueling(i_FuelType, i_AddFuel);
                    break;
                }
            }
        }
        public void VehicleLoading(string i_LicenseNumber, float i_AddCharging)
        {
            string licenseNumber;
            EnrgeyVehicles enrgey;
            foreach (VehiclesGarage vehiclesGarage in m_VehiclesGarage)
            {
                licenseNumber = vehiclesGarage.GetLicenseNumber();
                if (licenseNumber == i_LicenseNumber)
                {
                    enrgey = vehiclesGarage.GetEnrgeyType();
                    i_AddCharging = i_AddCharging / 60;
                    ((ElectricVehicles)enrgey).ChargingBattery(i_AddCharging);
                    break;
                }
            }

        }
        public List<string> GetVehicleGarageDetails(string i_LicenseNumber)
        {
            string licenseNumber;
            List<string> details = new List<string>();
            foreach (VehiclesGarage vehiclesGarage in m_VehiclesGarage)
            {
                licenseNumber = vehiclesGarage.GetLicenseNumber();
                if (licenseNumber == i_LicenseNumber)
                {
                    details = vehiclesGarage.GetDetails();
                    break;
                }
            }
            
            return details;
        }
    }
}
