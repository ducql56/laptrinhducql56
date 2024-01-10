using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearSwithCase
{
    public class sevice
    {
        public string GetMessage(int statusCode)
        {
            string message = string.Empty;
            switch (statusCode)
            {
                case 200:
                    message = "Ok";
                    break;
                case 404:
                    message = "Notfound";
                    break;
                case 400:
                    message = "Badrequest";
                    break;
                case 500:
                    message = "Server error";
                    break;
                default:
                    message = "Status Code is not in system";
                    break;
            }
            return message;


        }
        public string GetMessage2(int Month)
        {
            string message1 = string.Empty;
            switch (Month)
            {
                case 2:
                    message1 = " 28 day";
                    break;
                case 1:
                    message1 = "31 day";
                    break;
                case 3:
                    message1 = "31 day";
                    break;
                case 5:
                    message1 = "31 day";
                    break;
                case 7:
                    message1 = "31 day";
                    break;
                case 8:
                    message1 = "31 day";
                    break;
                case 10:
                    message1 = "31 day";
                    break;
                case 12:
                    message1 = "31 day";
                    break;
                case 4:
                    message1 = "30 day";
                    break;
                case 6:
                    message1 = "30 day";
                    break;
                case 9:
                    message1 = "30 day";
                    break;
                case 11:
                    message1 = "30 day";
                    break;
                default:
                    message1 = "Status Code is not in system";
                    break;
            }
            return message1;

        }
        public int GetDaysOfMonth(int month)
        {
            int days = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 2:
                    days = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                default:
                    days = 0;
                    break;
            }
            return days;
        }


        public int GetDaysOfMonth4(Moths month, int year)
        {
            int days = 0;
            switch (month)
            {
                case Moths.January:
                case Moths.March:
                case Moths.May:
                case Moths.July:
                case Moths.August:
                case Moths.October:
                case Moths.December:
                    days = 31;
                    break;
                case Moths.February:
                    if (CheckLunarYear3(year))
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                case Moths.April:
                case Moths.June:
                case Moths.September:
                case Moths.November:
                    days = 30;
                    break;
                default:
                    days = 0;
                    break;
            }
            return days;

        }
        public bool CheckLunarYear3(int year)
        {
            if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
