using Microsoft.AspNetCore.Mvc;
using PersonalFinanceTracker.Models;
using PersonalFinanceTracker.Repositories;

namespace PersonalFinanceTracker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly BudgetRepository _budgetRepository;
        private readonly ExpenseRepository _expenseRepository;

        public DashboardController(BudgetRepository budgetRepository, ExpenseRepository expenseRepository)
        {
            _budgetRepository = budgetRepository;
            _expenseRepository = expenseRepository;
        }

        public IActionResult Index()
        {
            // Retrieve the user's budget and expenses
            var budget = _budgetRepository.GetCurrentBudget(User.Identity.Name);
            var expenses = _expenseRepository.GetExpensesByUser(User.Identity.Name);

            // Prepare the view model
            var viewModel = new DashboardViewModel
            {
                MonthlyBudget = budget.monthly_budget,
                MonthlyExpenses = expenses.Sum(e => e.amount),
                RemainingBudget = budget.monthly_budget - expenses.Sum(e => e.amount)
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult SetBudget(decimal monthlyBudget)
        {
            // Update the user's budget
            _budgetRepository.UpdateBudget(User.Identity.Name, monthlyBudget);

            // Redirect back to the dashboard
            return RedirectToAction("Index");
        }
    }
}
