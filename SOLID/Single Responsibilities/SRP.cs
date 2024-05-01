////Problems: this class has four responsibilties so i need to separate them
//public class Employee {  
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//    public string Department { get; set; }
    
//    public decimal CalculateYearlySalary()
//    {
//        return Salary * 12; 
//    }
    
//    public void GenerateReport(string reportType)
//    {
//        //Code to generate report based on reportType 
//    }

//    public void SendNotification(string recipient, string message) 
//    {
//        //Code to send email notification
//    } 
//}


/* Solution */
//Class Employee To represent The Employee Data only
public class Employee 
{  
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Department { get; set; }
}

//Separate Methods in calsses cause every method doing specific task and does not related to each other

//1- class to calculate yearly salary.
public class EmployeeSalaryCalculator
{
    public decimal CalculateYearlySalary(Employee employee)
    {
        return employee.Salary * 12;
    }
}

//2 - class to generate reports.
public class EmployeeReport
{
    public void GenerateReport(string reportType,Employee employee)
    {
        //Code to generate report based on reportType 
    }
}

//3- class to send email notifications.
public class SendNotificationToEmployee
{
    public void SendNotification(string recipient, string message,Employee employee)
    {
        //Code to send email notification
    }
}