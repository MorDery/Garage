using System;
using System.Collections.Generic;
using Ex03.GarageLogic;
using System.Reflection;


namespace Ex03.ConsoleUI
{
    class GarageUI
    {
        public static string MenuGarage()
        {
            string numOfOption;
            Console.WriteLine("Hello, please press number from the options and after press enter.");
            Console.WriteLine("(1) Enter vehicles.");
            Console.WriteLine("(2) Show a list of vehicle license numbers in the garage.");
            Console.WriteLine("(3) Changing the condition of a car in the garage.");
            Console.WriteLine("(4) Blowing wheels to the maximum.");
            Console.WriteLine("(5) Fueling vehicles.");
            Console.WriteLine("(6) Vehicles loading.");
            Console.WriteLine("(7) Viewing data of a vehicle");
            Console.WriteLine("(8) exit");
            numOfOption = Console.ReadLine();
            return numOfOption;
        }
        public static void PrintVehicles(List<VehiclesGarage> i_Vehicles)
        {
            foreach(VehiclesGarage vehiclesGarage in i_Vehicles)
            {
                Console.WriteLine(string.Format("License number: {0}  status: {1}",vehiclesGarage.GetLicenseNumber(),vehiclesGarage.Status));

            }
        }
        public static string OptionPrint()
        {
            string getOption;
            Console.WriteLine("If you want to see the vehicles according to their working mode press 1 and the press enter.");
            getOption = Console.ReadLine();
            return getOption;
        }
        public static string GetLicenseNumber()
        {
            string licenseNumber;
            Console.WriteLine("Please enter your license number and the press enter.");
            licenseNumber = Console.ReadLine();
            return licenseNumber;
        }
        public static Utils.VehicleStatus GetStatus()
        {
            string status;
            int numOption = 0;
            const bool v_ValidInput = true;
            Utils.VehicleStatus vehicleStatus;
            int length = Enum.GetNames(typeof(Utils.VehicleStatus)).Length;
            Console.WriteLine("Please enter your new vchicle status and the press enter.");
            foreach (string enumName in Enum.GetNames(typeof(Utils.VehicleStatus)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, numOption));
                numOption++;
            }
            while (v_ValidInput)
            {
                try
                {
                    status = Console.ReadLine();
                    vehicleStatus = (Utils.VehicleStatus)Enum.Parse(typeof(Utils.VehicleStatus), status);
                    if((int)vehicleStatus > length - 1 || (int)vehicleStatus < 0)
                    {
                        Console.WriteLine("Invalid data, try again");
                    }
                    else
                    {
                        return vehicleStatus;
                    }
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
                
            }
        }
        public static Utils.ColorCars GetColor()
        {
            string color;
            int numOption = 0;
            Utils.ColorCars vehicleColor;
            const bool v_ValidInput = true;
            int length = Enum.GetNames(typeof(Utils.ColorCars)).Length;
            Console.WriteLine("Please enter your new vchicle status and the press enter.");
            foreach (string enumName in Enum.GetNames(typeof(Utils.ColorCars)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, numOption));
                numOption++;
            }
            while (v_ValidInput)
            {
                try
                {
                    color = Console.ReadLine();
                    vehicleColor = (Utils.ColorCars)Enum.Parse(typeof(Utils.ColorCars), color);
                    if ((int)vehicleColor > length - 1 || (int)vehicleColor < 0)
                    {
                        Console.WriteLine("Invalid data, try again");
                    }
                    else
                    {
                        return vehicleColor;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid data, try again");
                }

            }
        }
        public static Utils.DoorNumbers GetDoor()
        {
            string door;
            int numOption = 0;
            const bool v_ValidInput = true;
            Utils.DoorNumbers vehicleDoor;
            int length = Enum.GetNames(typeof(Utils.DoorNumbers)).Length;
            Console.WriteLine("Please enter your new vchicle status and the press enter.");
            foreach (string enumName in Enum.GetNames(typeof(Utils.DoorNumbers)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, numOption));
                numOption++;
            }
            while (v_ValidInput)
            {
                try
                {
                    door = Console.ReadLine();
                    vehicleDoor = (Utils.DoorNumbers)Enum.Parse(typeof(Utils.DoorNumbers), door);
                    if ((int)vehicleDoor > length - 1 || (int)vehicleDoor < 0)
                    {
                        Console.WriteLine("Invalid data, try again");
                    }
                    else
                    {
                        return vehicleDoor;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid data, try again");
                }

            }
        }
        public static void SetColor(Vehicles io_Vehicle)
        {
            Utils.ColorCars color;
            System.Type vehicleType = io_Vehicle.GetType();
            PropertyInfo colorPropertyInfo = vehicleType.GetProperty("ColorCar");
            if (colorPropertyInfo != null)
            {
                color = GarageUI.GetColor();
                colorPropertyInfo.SetValue(io_Vehicle, color, null);
            }
        }
        public static void SetDoor(Vehicles io_Vehicle)
        {
            Utils.DoorNumbers door;
            System.Type vehicleType = io_Vehicle.GetType();
            PropertyInfo doorPropertyInfo = vehicleType.GetProperty("DoorNumber");
            if (doorPropertyInfo != null)
            {
                door = GarageUI.GetDoor();
                doorPropertyInfo.SetValue(io_Vehicle, door, null);
            }
        }
        public static void SetHaveHazardousMaterials(Vehicles io_Vehicle)
        {
            bool haveHazardousMaterials;
            System.Type vehicleType = io_Vehicle.GetType();
            PropertyInfo propertyInfo = vehicleType.GetProperty("HaveHazardousMaterials");
            if (propertyInfo != null)
            {
                haveHazardousMaterials = GarageUI.GetHaveHazardousMaterials();
                propertyInfo.SetValue(io_Vehicle, haveHazardousMaterials, null);
            }
        }
        public static void SetVolumeOfCargo(Vehicles io_Vehicle)
        {
            float volumeOfCargo;
            System.Type vehicleType = io_Vehicle.GetType();
            PropertyInfo propertyInfo = vehicleType.GetProperty("VolumeOfCargo");
            if (propertyInfo != null)
            {
                volumeOfCargo = GarageUI.GetVolumeOfCargo();
                propertyInfo.SetValue(io_Vehicle, volumeOfCargo, null);
            }
        }
        public static void SetLicenseType(Vehicles io_Vehicle)
        {
            Utils.LicenseTypes LicenseType;
            System.Type vehicleType = io_Vehicle.GetType();
            PropertyInfo propertyInfo = vehicleType.GetProperty("LicenseType");
            if (propertyInfo != null)
            {
                LicenseType = GarageUI.GetLicenseType();
                propertyInfo.SetValue(io_Vehicle, LicenseType, null);
            }
        }
        public static void SetEngineCapacity(Vehicles io_Vehicle)
        {
            int engineCapacity;
            System.Type vehicleType = io_Vehicle.GetType();
            PropertyInfo propertyInfo = vehicleType.GetProperty("EngineCapacity");
            if (propertyInfo != null)
            {
                engineCapacity = GarageUI.GetEngineCapacity();
                propertyInfo.SetValue(io_Vehicle, engineCapacity, null);
            }
        }
        public static int GetEngineCapacity()
        {
            string engineCapacity;
            const bool v_ValidInput = true;
            Console.WriteLine("Please enter the engine Capacity and the press enter.");
            while (v_ValidInput)
            {
                try
                {
                    engineCapacity = Console.ReadLine();
                    return int.Parse(engineCapacity);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid data, try again");
                }

            }
        }
        public static Utils.LicenseTypes GetLicenseType()
        {
            string licenseType;
            int numOption = 0;
            Utils.LicenseTypes type;
            const bool v_ValidInput = true;
            int length = Enum.GetNames(typeof(Utils.LicenseTypes)).Length;
            Console.WriteLine("Please enter your new vchicle status and the press enter.");
            foreach (string enumName in Enum.GetNames(typeof(Utils.LicenseTypes)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, numOption));
                numOption++;
            }
            while (v_ValidInput)
            {
                try
                {
                    licenseType = Console.ReadLine();
                    type = (Utils.LicenseTypes)Enum.Parse(typeof(Utils.LicenseTypes), licenseType);
                    if ((int)type > length - 1 || (int)type < 0)
                    {
                        Console.WriteLine("Invalid data, try again");
                    }
                    else
                    {
                        return type;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid data, try again");
                }

            }
        }
        public static float GetVolumeOfCargo()
        {
            string volumeOfCargo;
            const bool v_ValidInput = true;
            Console.WriteLine("Please enter the Volume Of Cargo and the press enter.");
            while (v_ValidInput)
            {
                try
                {
                    volumeOfCargo = Console.ReadLine();
                    return float.Parse(volumeOfCargo);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid data, try again");
                }

            }
        }
        public static bool GetHaveHazardousMaterials()
        {
            const bool v_ValidInput = true;
            string haveHazardousMaterials;
            Console.WriteLine("Please enter true or false if Have Hazardous Materials and the press enter.");
            while (v_ValidInput)
            {
                try
                {
                    haveHazardousMaterials = Console.ReadLine();
                    return bool.Parse(haveHazardousMaterials);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
                
            }
        }
        public static void NotHaveVehicleInGarage()
        {
            Console.WriteLine("The vehicle is not in the garage");

        }
        public static Utils.FuelTypes GetTypeFuel()
        {
            int numOption = 0;
            string fuelType;
            Utils.FuelTypes fuelTypeVehicle;
            const bool v_ValidInput = true;
            int length = Enum.GetNames(typeof(Utils.FuelTypes)).Length;
            Console.WriteLine("Please enter your new vchicle status and the press enter.");
            foreach (string enumName in Enum.GetNames(typeof(Utils.FuelTypes)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, numOption));
                numOption++;
            }
            while (v_ValidInput)
            {
                try
                {
                    fuelType = Console.ReadLine();
                    fuelTypeVehicle = (Utils.FuelTypes)Enum.Parse(typeof(Utils.FuelTypes), fuelType);
                    if ((int)fuelTypeVehicle > length - 1 || (int)fuelTypeVehicle < 0)
                    {
                        Console.WriteLine("Invalid data, try again");
                    }
                    else
                    {
                        return fuelTypeVehicle;
                    }
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
            }

        }
        public static float GetAmountFuel()
        {
            string amount;
            const bool v_ValidInput = true;
            Console.WriteLine("Please enter the amount of fuel to fill and the press enter.");
            while (v_ValidInput)
            {
                try
                {
                    amount = Console.ReadLine();
                    return float.Parse(amount);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
                catch(ValueOutOfRangeException)
                {
                    MesegeError();
                }
            }
        }
        public static float GetAmountElectric()
        {
            string amount;
            const bool v_ValidInput = true;
            Console.WriteLine("Please enter the amount to charging and the press enter.");
            while (v_ValidInput)
            {
                try
                {
                    amount = Console.ReadLine();
                    return float.Parse(amount);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
                catch(ValueOutOfRangeException)
                {
                    MesegeError();
                }
            }
        }
        public static void MesegeChangeStatus()
        {
            Console.WriteLine("The vehicle is in the garge already, is status change.");
        }
        public static Ex03.GarageLogic.Builder.VehicleTypes GetVehicleType()
        {
            string type;
            int numOption = 0;
            const bool v_ValidInput = true;
            Ex03.GarageLogic.Builder.VehicleTypes vehicleType;
            int length = Enum.GetNames(typeof(Ex03.GarageLogic.Builder.VehicleTypes)).Length;
            Console.WriteLine("Please enter your vchicle type and the press enter.");
            foreach (string enumName in Enum.GetNames(typeof(Ex03.GarageLogic.Builder.VehicleTypes)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, numOption));
                numOption++;
            }
            while (v_ValidInput)
            {
                
                try
                {
                    type = Console.ReadLine();
                    vehicleType = (Ex03.GarageLogic.Builder.VehicleTypes)Enum.Parse(typeof(Ex03.GarageLogic.Builder.VehicleTypes), type);
                    if ((int)vehicleType > length - 1 || (int)vehicleType < 0)
                    {
                        Console.WriteLine("Invalid data, try again");
                    }
                    else
                    {
                        return vehicleType;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
            }
        }
        public static string GetModelName()
        {
            string modelName;
            Console.WriteLine("Please enter  the vchicle model name and the press enter.");
            modelName = Console.ReadLine();
            return modelName;
        }
        public static float GetReamainingEnergy()
        {
            string reamainingEnergy;
            const bool v_ValidInput = true;
            Console.WriteLine("Please enter the vchicle lreamaining Energy and the press enter.");
            
            while (v_ValidInput)
            {
                try
                {
                    reamainingEnergy = Console.ReadLine();
                    return float.Parse(reamainingEnergy);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
                catch(ValueOutOfRangeException)
                {
                    MesegeError();
                }
            }
           
        }
        public static string GetName()
        {
            string name;
            Console.WriteLine("Please enter  your name and the press enter.");
            name = Console.ReadLine();
            return name;
        }
        public static string GetPhoneNumber()
        {
            string phoneNumber;
            Console.WriteLine("Please enter  your phone number and the press enter.");
            phoneNumber = Console.ReadLine();
            return phoneNumber;
        }
        public static void MesegeSucceeded()
        {
            Console.WriteLine("the transaction completed successfully.");
        }
        public static string MesegeToContinue()
        {
            Console.WriteLine("Please press enter to continue.");
            return Console.ReadLine();
        }
        public static void PrintVehicleDetails(List<string> i_Details)
        {
            Console.WriteLine("The vehicle details:");
            foreach (string detail in i_Details)
            {
                Console.WriteLine(detail);
            }
        }
        public static float GetCurrentAirPressure()
        {
            string currentAirPressure;
            const bool v_ValidInput = true;
            Console.WriteLine("Please enter the current Air Pressure and the press enter.");
            while (v_ValidInput)
            {
                try
                {
                    currentAirPressure = Console.ReadLine();
                    return float.Parse(currentAirPressure);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid data, try again");
                }
                catch(ValueOutOfRangeException)
                {
                    MesegeError();
                }
            }
        }
        public static string GetManufacturerName()
        {
            string manufacturerName;
            Console.WriteLine("Please enter the manufacturer Name and the press enter.");
            manufacturerName = Console.ReadLine();
            return manufacturerName;
        }
        public static void MesegeError()
        {
            Console.WriteLine("Invalid value.");
        }
        public static void Clear()
        {
            Console.Clear();
        }

    }
}
