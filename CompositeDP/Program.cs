using CompositeDP.Component;
using CompositeDP.Composite;
using CompositeDP.Leaf;

Console.WriteLine("Testing Composite design pattern.\n");

// Step 1:
// Creating individual employees
IEmployee employee1 = new IndividualEmployee("Nika", 29, "Backend developer");
IEmployee employee2 = new IndividualEmployee("Beka", 25, "Senior everything developer");

// Step 2:
// Creating a department (development) and
// adding individual employees to it
Department developmentDepartment = new Department("Development team department");

developmentDepartment.AddEmployee(employee1);
developmentDepartment.AddEmployee(employee2);


// Same steps (1 and 2):
// adding sub-department into development department

IEmployee employee3 = new IndividualEmployee("Vano", 29, "Project manager");
IEmployee employee4 = new IndividualEmployee("Acho", 25, "AI developer");

var ProjectManagementDepartment = new Department("PM team department");
ProjectManagementDepartment.AddEmployee(employee3);

var subDepartment = new Department("Sub-Department");
subDepartment.AddEmployee(employee4);

// Adding the sub-department to the development department
developmentDepartment.AddEmployee(subDepartment);


// Final step: Creating COmpany!
// Creating a company department
// and adding the development
// and PM departments into it
var company = new Department("Company");
company.AddEmployee(developmentDepartment);
company.AddEmployee(ProjectManagementDepartment);

// Displaying details of the company department,
// which recursively displays details
// of all employees and sub-departments
company.DisplayDetails();



Console.WriteLine("_________                                    .__  __          \r\n\\_   ___ \\  ____   _____ ______   ____  _____|__|/  |_  ____  \r\n/    \\  \\/ /  _ \\ /     \\\\____ \\ /  _ \\/  ___/  \\   __\\/ __ \\ \r\n\\     \\___(  <_> )  Y Y  \\  |_> >  <_> )___ \\|  ||  | \\  ___/ \r\n \\______  /\\____/|__|_|  /   __/ \\____/____  >__||__|  \\___  >\r\n        \\/             \\/|__|              \\/              \\/");