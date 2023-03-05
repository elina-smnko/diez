using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1wpf
{
    public class Person
    {
        public DateTime birth;
        public String westernSign;
        public String chineseSign;

        public Person(DateTime birth)
        {
            AddBirth(birth);
            calculateWesternSign();
            calculateChineseSign();
        }

        private void AddBirth(DateTime birth)
        {
            if (birth>DateTime.Today || birth.Year < 1888) Console.WriteLine("Wrong date of birth");
            else this.birth = birth;

        }

        public int CalculateYears()
        {
            
            if(this.birth.Year!=DateTime.Today.Year && this.birth.Month>DateTime.Today.Month) return DateTime.Today.Year - this.birth.Year-1;
            else if (this.birth.Year != DateTime.Today.Year && this.birth.Month == DateTime.Today.Month
                && this.birth.Day > DateTime.Today.Day) return DateTime.Today.Year - this.birth.Year - 1;
            else return DateTime.Today.Year - this.birth.Year;
        }

        public String calculateWesternSign()
        {
            if (this.birth.Day >= 21 && this.birth.Month == 3 || this.birth.Day <= 19 && this.birth.Month == 4) this.westernSign = "Aries";
            if (this.birth.Day >= 20 && this.birth.Month == 4 || this.birth.Day <= 20 && this.birth.Month == 5) this.westernSign = "Taurus";
            if (this.birth.Day >= 21 && this.birth.Month == 5 || this.birth.Day <= 20 && this.birth.Month == 6) this.westernSign = "Gemini";
            if (this.birth.Day >= 21 && this.birth.Month == 6 || this.birth.Day <= 22 && this.birth.Month == 7) this.westernSign = "Cancer";
            if (this.birth.Day >= 23 && this.birth.Month == 7 || this.birth.Day <= 22 && this.birth.Month == 8) this.westernSign = "Leo";
            if (this.birth.Day >= 23 && this.birth.Month == 8 || this.birth.Day <= 22 && this.birth.Month == 9) this.westernSign = "Virgo";
            if (this.birth.Day >= 23 && this.birth.Month == 9 || this.birth.Day <= 22 && this.birth.Month == 10) this.westernSign = "Libra";
            if (this.birth.Day >= 23 && this.birth.Month == 10 || this.birth.Day <= 21 && this.birth.Month == 11) this.westernSign = "Scorpio";
            if (this.birth.Day >= 22 && this.birth.Month == 11 || this.birth.Day <= 21 && this.birth.Month == 12) this.westernSign = "Saggitarius";
            if (this.birth.Day >= 22 && this.birth.Month == 12 || this.birth.Day <= 19 && this.birth.Month == 1) this.westernSign = "Capricorn";
            if (this.birth.Day >= 20 && this.birth.Month == 1 || this.birth.Day <= 18 && this.birth.Month == 2) this.westernSign = "Aquaris";
            if (this.birth.Day >= 19 && this.birth.Month == 2 || this.birth.Day <= 20 && this.birth.Month == 3) this.westernSign = "Pisces";

            return null;
        }
            
        public void calculateChineseSign()
        {
            for (int i=0;i<15; i++)
            {
                if (this.birth.Year == 1900 + 12 * i) this.chineseSign = "Mouse";
                if (this.birth.Year == 1901 + 12 * i) this.chineseSign = "Bull";
                if (this.birth.Year == 1902 + 12 * i) this.chineseSign = "Tiger";
                if (this.birth.Year == 1903 + 12 * i) this.chineseSign = "Rabbit";
                if (this.birth.Year == 1904 + 12 * i) this.chineseSign = "Dragon";
                if (this.birth.Year == 1905 + 12 * i) this.chineseSign = "Snake";
                if (this.birth.Year == 1906 + 12 * i) this.chineseSign = "Horse";
                if (this.birth.Year == 1907 + 12 * i) this.chineseSign = "Sheep";
                if (this.birth.Year == 1908 + 12 * i) this.chineseSign = "Monkey";
                if (this.birth.Year == 1909 + 12 * i) this.chineseSign = "Rooster";
                if (this.birth.Year == 1910 + 12 * i) this.chineseSign = "Dog";
                if (this.birth.Year == 1911 + 12 * i) this.chineseSign = "Boar";
            }
            
        }

    }
}
