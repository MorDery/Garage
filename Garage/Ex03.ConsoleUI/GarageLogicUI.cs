using System.Collections.Generic;
using System;
using System.Reflection;
using Ex03.GarageLogic;


namespace Ex03.ConsoleUI
{
    class GarageLogicUI
    {
        Ex03.GarageLogic.Garage garage = new Ex03.GarageLogic.Garage();
        Ex03.GarageLogic.Builder builder = new Ex03.GarageLogic.Builder();

        public void StartMenuGarage()
        {
            string numOfOption;
            bool exit = false;
            
            while (!exit)
            {
                numOfOption = GarageUI.MenuGarage();
                switch (numOfOption)
                {
                    case "1":
                        GarageUI.Clear();
                        EnterNewVehicle();
                        break;
                    case "2":
                        GarageUI.Clear();
                        ShowListVehicles();
                        break;
                    case "3":
                        GarageUI.Clear();
                        ChangeStatus();
                        break;
                    case "4":
                        GarageUI.Clear();
                        BlowingWheelsToTheMaximum();
                        break;
                    case "5":
                        GarageUI.Clear();
                        FuelingVehicle();
                        break;
                    case "6":
                        GarageUI.Clear();
                        VehicleLoading();
                        break;
                    case "7":
                        GarageUI.Clear();
                        ShowVehicleGarageDetails();
                        break;
                    case "8":
                        exit = true;
                        break;


                }
                GarageUI.Clear();
            }
        }
        public void EnterNewVehicle()
        {
            bool isExists = false;
            string licenseNumber = GarageUI.GetLicenseNumber();
            isExists = garage.HaveVehicleInGarage(licenseNumber);
            if(!isExists)
            {
                AddNewVehicle(licenseNumber);
            }
            else
            {
                GarageUI.MesegeChangeStatus();
            }
        }
        public void AddNewVehicle(string i_LicenseNumber)
        {
            Ex03.GarageLogic.Builder.VehicleTypes type = GarageUI.GetVehicleType();
            string modelName = GarageUI.GetModelName();
            float reamainingEnergy = GarageUI.GetReamainingEnergy();
            string manufacturerName = GarageUI.GetManufacturerName();
            float currentAirPressure = GarageUI.GetCurrentAirPressure();
            Vehicles newVehicle;
            newVehicle = builder.CreatVehicle(modelName, i_LicenseNumber, type, reamainingEnergy, manufacturerName, currentAirPressure);
            GarageUI.SetColor(newVehicle);
            GarageUI.SetDoor(newVehicle);
            GarageUI.SetHaveHazardousMaterials(newVehicle);
            GarageUI.SetVolumeOfCargo(newVehicle);
            GarageUI.SetLicenseType(newVehicle);
            GarageUI.SetEngineCapacity(newVehicle);
            AddNewVehicleGarage(newVehicle);
        }
        public void AddNewVehicleGarage(Vehicles i_Vehicle)
        {
            string name = GarageUI.GetName();
            string phoneNumber = GarageUI.GetPhoneNumber();
            VehiclesGarage newVehicleGarage = new VehiclesGarage(name, phoneNumber, i_Vehicle);
            garage.m_VehiclesGarage.Add(newVehicleGarage);
        }
        public void ShowListVehicles()
        {
            string getOption;
            garage.m_VehiclesGarage = garage.VehiclesInGarages();
            GarageUI.PrintVehicles(garage.m_VehiclesGarage);
            getOption = GarageUI.OptionPrint();
            if(getOption == "1")
            {
                garage.m_VehiclesGarage = garage.VehiclesInGaragesStatus();
                GarageUI.PrintVehicles(garage.m_VehiclesGarage);
            }
            string toContinue = GarageUI.MesegeToContinue();
        }
        public void ChangeStatus()
        {
           string licenseNumber = GarageUI.GetLicenseNumber();
            if (licenseNumber != null)
            {
                Utils.VehicleStatus status = GarageUI.GetStatus();
                garage.ChangeStatus(licenseNumber, status);
                GarageUI.MesegeSucceeded();
            }
            else
            {
                GarageUI.NotHaveVehicleInGarage();
            }
            GarageUI.MesegeToContinue();
        }
        public void BlowingWheelsToTheMaximum()
        {
            string licenseNumber = GarageUI.GetLicenseNumber();
            bool isSucceed = garage.BlowingWheelsToTheMaximum(licenseNumber);
            if(!isSucceed)
            {
                GarageUI.NotHaveVehicleInGarage();
            }
            else
            {
                GarageUI.MesegeSucceeded();
            }
            GarageUI.MesegeToContinue();
        }
        public void FuelingVehicle()
        {
            string licenseNumber = GarageUI.GetLicenseNumber();
            if (licenseNumber != null)
            {
                Utils.FuelTypes typeFuel = GarageUI.GetTypeFuel();
                float addFuel = GarageUI.GetAmountFuel();
                try
                {
                    garage.FuelingVehicle(licenseNumber, typeFuel, addFuel);
                    GarageUI.MesegeSucceeded();
                }
                catch(ValueOutOfRangeException)
                {
                    GarageUI.MesegeError();
                }
                
            }
            else
            {
                GarageUI.NotHaveVehicleInGarage();
            }
            GarageUI.MesegeToContinue();
        }
        public void VehicleLoading()
        {
            string licenseNumber = GarageUI.GetLicenseNumber();
            if (licenseNumber != null)
            {
                float addCharging = GarageUI.GetAmountElectric();
                
                try 
                {
                    garage.VehicleLoading(licenseNumber, addCharging);
                    GarageUI.MesegeSucceeded();
                }
                catch(ValueOutOfRangeException)
                {
                    GarageUI.MesegeError();
                }
            }
            else
            {
                GarageUI.NotHaveVehicleInGarage();
            }
            GarageUI.MesegeToContinue();
        }
        public void ShowVehicleGarageDetails()
        {
            string licenseNumber;
            List<string> vehicle = new List<string>(); ;
            licenseNumber = GarageUI.GetLicenseNumber();
            vehicle = garage.GetVehicleGarageDetails(licenseNumber);
            if(vehicle != null)
            {
                GarageUI.PrintVehicleDetails(vehicle);
            }
            else
            {
                GarageUI.NotHaveVehicleInGarage();
            }
            GarageUI.MesegeToContinue();
        }
        
    }
}
