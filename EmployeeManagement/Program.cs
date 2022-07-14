﻿const int IS_PART_TIME = 1;
const int IS_FULL_TIME = 2;
static int computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
{
    int empHrs = 0;
    int totalEmpHrs = 0;
    int totalWorkingDays = 0;
    while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
    {
        totalWorkingDays++;
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        switch (empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
            case IS_FULL_TIME:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;
        }
        totalEmpHrs += empHrs;
        Console.WriteLine("Day#: " + totalWorkingDays + " Emp Hrs: " + empHrs);
    }
    int totalEmpWage = totalEmpHrs * empRatePerHour;
    Console.WriteLine("Total Emp Wage for company: " + company + " is :" + totalEmpWage);
    return totalEmpWage;
}
computeEmpWage("Dmart", 20, 2, 10);
computeEmpWage("Reliance", 10, 4, 20);