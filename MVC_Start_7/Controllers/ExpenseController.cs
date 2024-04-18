using Microsoft.AspNetCore.Mvc;
using PersonalFinanceTracker.Models;
using PersonalFinanceTracker.Repositories;

namespace PersonalFinanceTracker.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ExpenseRepository _expenseRepository;
        private readonly BudgetRepository _budgetRepository;

        public ExpenseController(ExpenseRepository expenseRepository, BudgetRepository budgetRepository)
        {
            _expenseRepository = expenseRepository;
            _budgetRepository = budgetRepository;
        }

        public IActionResult Index()
        {
            // Retrieve the user's expenses
            var expenses = _expenseRepository.GetExpensesByUser(User.Identity.Name);
            return View(expenses);
        }

        [HttpGet]
        public IActionResult AddExpense()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddExpense(Expense expense)
        {
            // Add the new expense to the repository
            _expenseRepository.AddExpense(expense);

            // Redirect to the expense list
            return RedirectToAction("Index");
        }
    }
}