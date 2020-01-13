

namespace Ex03.GarageLogic
{
    public class Builder
    {
        public enum VehicleTypes
        {
            CarElectric,
            CarFuel,
            MotorcycleElectric,
            MotorcycleFuel,
            Truck,
        }

         public Vehicles CreatVehicle(string i_ModelName, string i_LicenseNumber, VehicleTypes i_VehicleTypes, float i_RemainingEnergy, string i_ManufacturerName, float i_CurrentAirPressure)
        {
            Vehicles newVehicle = null;
            switch (i_VehicleTypes)
            {
                case VehicleTypes.CarElectric:
                    ElectricVehicles electricCar = new ElectricVehicles();
                    newVehicle = new Car(i_ModelName, i_LicenseNumber, electricCar, i_RemainingEnergy, i_ManufacturerName, i_CurrentAirPressure, 0, 0);
                    break;
                case  VehicleTypes.CarFuel:
                    FuelVehicles fuelCar = new FuelVehicles();
                    newVehicle = new Car(i_ModelName, i_LicenseNumber, fuelCar, i_RemainingEnergy, i_ManufacturerName, i_CurrentAirPressure, 0, 0);
                    break;
                case  VehicleTypes.MotorcycleElectric:
                    ElectricVehicles electricMotorcycle =  new ElectricVehicles();
                    newVehicle = new Motorcycle(i_ModelName,  i_LicenseNumber, electricMotorcycle, i_RemainingEnergy, 0, 0, i_ManufacturerName, i_CurrentAirPressure);
                    break;
                case VehicleTypes.MotorcycleFuel:
                    FuelVehicles fuelMotorcycle = new FuelVehicles();
                    newVehicle = new Motorcycle(i_ModelName, i_LicenseNumber, fuelMotorcycle, i_RemainingEnergy, 0, 0, i_ManufacturerName, i_CurrentAirPressure);
                    break;
                case VehicleTypes.Truck:
                    FuelVehicles fuelTruk = new FuelVehicles();
                    newVehicle = new Truck(i_ModelName, i_LicenseNumber, fuelTruk, i_RemainingEnergy , i_ManufacturerName, i_CurrentAirPressure, false, 0);
                    break;

            }
            return newVehicle;
        }
    }
}
