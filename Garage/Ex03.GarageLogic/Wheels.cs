using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class Wheels
    {
        string m_ManufacturerName;
        float m_CurrentAirPressure;
        float m_MaxAirPressure;

        void Inflating(float i_AddAirPressure)
        {
            float newAirPressure = m_CurrentAirPressure + i_AddAirPressure;
            if (newAirPressure <= m_MaxAirPressure)
            {
                m_CurrentAirPressure = newAirPressure;
            }
            else
            {
                ValueOutOfRangeException value = new ValueOutOfRangeException(0, m_MaxAirPressure);
                throw value;
            }
        }
        public Wheels(string i_ManufacturerName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            m_ManufacturerName = i_ManufacturerName;
            if (m_CurrentAirPressure < 0 || m_CurrentAirPressure > m_MaxAirPressure)
            {
                ValueOutOfRangeException value = new ValueOutOfRangeException(0, m_MaxAirPressure);
                throw value;
            }
            else
            {
                m_CurrentAirPressure = i_CurrentAirPressure;
            }
            m_MaxAirPressure = i_MaxAirPressure;
        }
        public void  MaxAirPressure()
        {
            m_CurrentAirPressure = m_MaxAirPressure;
        }
        public List<string> GetDetails(List<string> io_Details)
        {

            io_Details.Add("Manufacturer Name:" + m_ManufacturerName);
            io_Details.Add("Current Air Pressure:" + m_CurrentAirPressure);
            io_Details.Add("Max Air Pressure:" + m_MaxAirPressure);
            return io_Details;
        }
    }
}
