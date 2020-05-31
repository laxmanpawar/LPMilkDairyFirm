using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInForm
{
    class MilkCollectionData
    {
        private DateTime m_dDateTime;
        private int m_iCustId;
        private string m_sCustName;
        private int m_iCustMilkType;
        private double m_iWeight;
        private double m_dFat;
        private double m_dSNF;
        private double m_dDegree;
        private double m_dMilkRate;
        private double m_dAmount;



        public MilkCollectionData()
        {

        }

        public int Initialize(int code, string name, DateTime dateTime, int milkType, double weight, double fat, double SNF, double degree, double milkRate, double amount)
        {
            m_dDateTime = dateTime;
            m_iCustId = code;
            m_sCustName = name;
            m_iCustMilkType = milkType;
            m_iWeight = weight;
            m_dFat = fat;
            m_dSNF = SNF;
            m_dDegree = degree;
            m_dMilkRate = milkRate;
            m_dAmount = amount;

            return 0;
        }
    }
}