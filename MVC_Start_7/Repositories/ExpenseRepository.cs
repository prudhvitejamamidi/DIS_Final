using PersonalFinanceTracker.Models;

namespace PersonalFinanceTracker.Repositories
{
    public class ExpenseRepository
    {
        private readonly List<Expense> _expenses;

        public ExpenseRepository()
        {
            // Initialize the expense data
            _expenses = new List<Expense>
            {
                new Expense
                {
                    expense_id = 1,
                    user_id = 1,
                    budget_id = 1,
                    expense_type = "Groceries",
                    amount = 500,
                    expense_date = new DateTime(2023, 4, 1),
                    created_at = new DateTime(2023, 4, 1),
                    updated_at = new DateTime(2023, 4, 1)
                },
                new Expense
                {
                    expense_id = 2,
                    user_id = 1,
                    budget_id = 1,
                    expense_type = "Rent",
                    amount = 800,
                    expense_date = new DateTime(2023, 4, 1),
                    created_at = new DateTime(2023, 4, 1),
                    updated_at = new DateTime(2023, 4, 1)
                }
            };
        }

        public List<Expense> GetExpensesByUser(string username)
        {
            // Retrieve the expenses for the user
            return _expenses.Where(e => e.user_id == 1).ToList();
        }

        public void AddExpense(Expense expense)
        {
            // Add the new expense to the list
            expense.expense_id = _expenses.Count + 1;
            expense.user_id = 1;
            expense.budget_id = 1;
            expense.created_at = DateTime.Now;
            expense.updated_at = DateTime.Now;
            _expenses.Add(expense);
        }
    }
}