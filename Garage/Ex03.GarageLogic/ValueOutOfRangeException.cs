using System;
using System.Collections.Generic;
using System.Text;

namespace Ex03.GarageLogic
{
    public class ValueOutOfRangeException : Exception
    {
        float m_MaxValue;
        float m_MinValue;

        public ValueOutOfRangeException(float i_MaxValue , float i_MinValue)
        {
            m_MaxValue = i_MaxValue;
            m_MinValue = i_MinValue;
        }
    }
}
