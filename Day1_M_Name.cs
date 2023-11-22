review1.cs

//Avoid using bad names
int d; // elapsed time in days

review2.cs
var dataFromDb = db.GetFromService().ToList(); // Get List of employees 
//left side name is not clear what it's fetching
//right side you dont know what you're gretting actually

var ListOfEmployee = _employeeService.GetEmployee().ToList(); 
//Proper naming on the left and proper data fetching on the right

review3.cs
//Avoid hungarian notation
int iCounter;//naming on right side
string strFullName;
DateTime dModifiedDate;

//Use proper naming for better understanding
int iCounter;
string FullName;
DateTime ModifiedDate;

review4.cs
public bool IsShopOpen(string pDay, int pAmount)//Avoid hungarian notation
{
    // some logic
}

review5.cs
//Avoid different formats for naming 
const int DAYS_IN_WEEK = 7;//Upper case style
const int daysInMonth = 30;//Camelcasing style

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

review6.cs
public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}

review7.cs
//Avoid mixing of naming format
var employeephone;

public double CalculateSalary(int workingdays, int workinghours)//lowercase and camelcase format mixing
{
    // some logic
}

