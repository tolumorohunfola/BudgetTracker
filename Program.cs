// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Budget Tracker App!");

// user name
string userName = "Alice";


// overall budget
int overallBudget = 1000;


// expenses
double foodExpense = 250.75;
double transportExpense = 100.50;
double entertainmentExpense = 150.00;

// opt-in for notifications
bool notificationsOptIn = true;

Console.WriteLine($"Hello, {userName}, your overall budget is ${overallBudget}. After expenses, you have ${overallBudget - (foodExpense + transportExpense + entertainmentExpense)} left.");
if (notificationsOptIn)
{
    Console.WriteLine("You have opted in for notifications.");
}
else
{
    Console.WriteLine("You have opted out of notifications.");
}