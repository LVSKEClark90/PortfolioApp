using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Experience
    {
        private string companyName;
        private DateTime startDate, endDate;
        private float payRate;

        public Experience()
        {
            companyName = "unknown";
            startDate = DateTime.Parse("0-0-0000");
            endDate = DateTime.Parse("0-0-0000");
            payRate = 0.00F;
        }

        public Experience(string companyName, string startDate, string endDate, float payRate)
        {
            this.companyName = companyName;
            this.startDate = DateTime.Parse(startDate);
            this.endDate = DateTime.Parse(endDate);
            this.payRate = payRate;
        }

        string getName()
        {
            return this.companyName;
        }
        void setName(string companyName)
        {
            this.companyName = companyName;
        }

        DateTime getStartDate()
        {
            return startDate;
        }
        void setStartDate(String startDate)
        {
            this.startDate = DateTime.Parse(startDate);
        }

        DateTime getEndDate()
        {
            return endDate;
        }
        void setEndDate(String endDate)
        {
            this.endDate = DateTime.Parse(endDate);
        }

        float getPayRate()
        {
            return payRate;
        }
        void setPayRate(float payRate)
        {
            this.payRate = payRate;
        }

        void printExperience()
        {
            Console.WriteLine("Company Name: " + companyName + "\r\n"
                            + "Start Date: " + startDate + "\r\n"
                            + "End Date: " + endDate + "\r\n"
                            + "Pay Rate: " + payRate + "\r\n");
        }
    }
}
