using System.Collections.Generic;
using Utils;

namespace Ex03.GarageLogic
{
    class Car : Vehicles
    {
        ColorCars m_colorCar;
        DoorNumbers m_DoorNumber;

        public Car(string i_ModelName, string i_LicenseNumber, EnrgeyVehicles i_EnrgeyType, float i_RemainingEnergy, string i_ManufacturerName, float i_CurrentAirPressure, ColorCars i_colorCar, DoorNumbers i_DoorNumber)
           : base(i_ModelName, i_LicenseNumber, i_RemainingEnergy)
        {
            m_EnrgeyType = i_EnrgeyType;
            m_colorCar = i_colorCar;
            m_DoorNumber = i_DoorNumber;
            CreatWheels(4, i_ManufacturerName, i_CurrentAirPressure, 31);
            if (i_EnrgeyType is ElectricVehicles)
            {
                m_EnrgeyType.CreatEnrgey(i_RemainingEnergy, 1.8f);
            }
            else
            {
                m_EnrgeyType.CreatEnrgey(i_RemainingEnergy, 55f);
                ((FuelVehicles)m_EnrgeyType).FuelType = FuelTypes.Octan96;
            }
        }
        public override List<string> GetDetails(List<string> io_Details)
        {
            io_Details.Add("Color Car:" + m_colorCar.ToString());
            io_Details.Add("Door Number:" + m_DoorNumber.ToString());
            return io_Details;
        }
        public ColorCars ColorCar
        {
            set
            {
                m_colorCar = value;
            }
            get
            {
                return m_colorCar;
            }
        }
        public DoorNumbers DoorNumber
        {
            get
            {
                return m_DoorNumber;
            }
            set
            {
                m_DoorNumber = value;
            }
        }
           


    }
}
