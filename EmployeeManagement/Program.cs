using EmployeeManagement;

//EmpWageBuilderObject dMart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
//EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
//dMart.computeEmpWage();
//Console.WriteLine(dMart.toString());
//reliance.computeEmpWage();
//Console.WriteLine(reliance.toString());

EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
empWageBuilder.addCompanyWage("Dmart", 20, 2, 10);
empWageBuilder.addCompanyWage("Reliance", 10, 4, 20);
empWageBuilder.computeEmpWage();