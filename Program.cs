// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Budget Tracker App!");
// user name
string userName = "Alice";
// overall budget
double overallBudget = 1800;
// specific budgets in a list, food, transport and entertainment
List<double> budgets = new List<double> { 200, 300, 100 };
// expenses in a list, food transport and entertainment
List<double> expenses = new List<double> { 250.75, 100.50, 150.00 };

// function to calculate total expenses
double CalculateTotalExpenses(List<double> expenses)
{
    // for loop to calculate total expenses
    // first initialise the varaible that will be the result of the for loop
    double totalExpenses = 0;
    for (int i = 0; i < expenses.Count; i++)
    {
        totalExpenses = totalExpenses + expenses[i];
    }
}


// while loop to ensure Alice doesn't go over the spending limit
double spendingLimit = 900;
double totalSpending = 0;
int i = 0;
while (totalSpending < spendingLimit)
{
    totalSpending = totalSpending + expenses[i];
}

// opt-in for notifications
bool notificationsOptIn = true;
// Display user information
Console.WriteLine($"Hello, {userName}, your overall budget is ${overallBudget}. After expenses, you have ${overallBudget - totalExpenses} left.");
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