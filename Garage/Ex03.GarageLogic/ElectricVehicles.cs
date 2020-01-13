using System.Collections.Generic;

namespace Ex03.GarageLogic
{
    class ElectricVehicles : EnrgeyVehicles
    {
        float m_TimeRemainingBattery;
        float m_MaximumBatteryTime;

        public void ChargingBattery(float i_AddCharging)
        {
            float newTimeBattery = m_TimeRemainingBattery + i_AddCharging;
            if(newTimeBattery <= m_MaximumBatteryTime)
            {
                m_TimeRemainingBattery = newTimeBattery;
            }
            else
            {
                ValueOutOfRangeException value = new ValueOutOfRangeException(0, m_MaximumBatteryTime);
                throw value;
            }
            
        }
        public override void CreatEnrgey(float i_RemainingEnergy, float i_MaxEnergy)
        {
            if (i_RemainingEnergy < 0 || i_RemainingEnergy > m_MaximumBatteryTime)
            {
                m_TimeRemainingBattery = i_RemainingEnergy;
            }
            else
            {
                ValueOutOfRangeException value = new ValueOutOfRangeException(0, m_MaximumBatteryTime);
                throw value;
            }
            m_MaximumBatteryTime = i_MaxEnergy;
        }
        public override List<string> GetDetails(List<string> io_Details)
        {
            io_Details.Add("Time Remaining Battery:" + m_TimeRemainingBattery);
            io_Details.Add("Maximum Battery Time:" + m_MaximumBatteryTime);
            return io_Details;
        }
    }
}
