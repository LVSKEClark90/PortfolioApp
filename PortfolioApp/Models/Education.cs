using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Models
{
    public class Education
    {
        private String collegeName;
        private int graduationYear;
        private String degree;
        private float gpa;

        public Education()
        {
            collegeName = "unknown";
            graduationYear = 0000;
            degree = "unknown";
            gpa = 0.0F;
        }

        public Education(string collegeName, int graduationYear, string degree, float gpa)
        {
            this.collegeName = collegeName;
            this.graduationYear = graduationYear;
            this.degree = degree;
            this.gpa = gpa;
        }

        string getCollegeName()
        {
            return collegeName;
        }
        void setCollegeName(string collegeName)
        {
            this.collegeName = collegeName;
        }

        int getGraduationYear()
        {
            return graduationYear;
        }
        void setGraduationYear(int graduationYear)
        {
            this.graduationYear = graduationYear;
        }

        string getDegree()
        {
            return degree;
        }
        void setDegree(string degree)
        {
            this.degree = degree;
        }

        float getGPA()
        {
            return gpa;
        }
        void setGPA(float gpa)
        {
            this.gpa = gpa;
        }

        void printEducation()
        {
            Console.WriteLine("College: " + collegeName + "\r\n"
                            + "Graduation Year: " + graduationYear + "\r\n"
                            + "Degree: " + degree + "\r\n"
                            + "GPA: " + gpa + "\r\n");
        }
    }
}
