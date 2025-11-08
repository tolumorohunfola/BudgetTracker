// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Budget Tracker App!");
// user name
string userName = "Alice";
// overall budget
int overallBudget = 1800;
// specific budgets
int foodBudget = 200;
int transportBudget = 300;
int entertainmentBudget = 100;
// expenses
double foodExpense = 250.75;
double transportExpense = 100.50;
double entertainmentExpense = 150.00;
// opt-in for notifications
bool notificationsOptIn = true;
// Display user information
Console.WriteLine($"Hello, {userName}, your overall budget is ${overallBudget}. After expenses, you have ${overallBudget - (foodExpense + transportExpense + entertainmentExpense)} left.");
if (notificationsOptIn)
{
    Console.WriteLine("You have opted in for notifications.");
}
else
{
    Console.WriteLine("You have opted out of notifications.");
}
// Display specific budget statuses
if (foodExpense > foodBudget)
{
    Console.WriteLine($"Alert: You have exceeded your food budget by ${foodExpense - foodBudget}.");
}
else
{
    Console.WriteLine($"You have ${foodBudget - foodExpense} left within your food budget");
}
// check if within budget for transport and entertainment
if (transportExpense <= transportBudget && entertainmentExpense <= entertainmentBudget)
{
    Console.WriteLine("You are within your transport and entertainment budgets.");
}
else if (transportExpense > transportBudget)
{
    Console.WriteLine($"Alert: You have exceeded your transport budget by ${transportExpense - transportBudget}.");
}
else if (entertainmentExpense > entertainmentBudget)
{
    Console.WriteLine($"Alert: You have exceeded your entertainment budget by ${entertainmentExpense - entertainmentBudget}.");
}
else
{
    Console.WriteLine("You are within your transport and entertainment budgets.");
}