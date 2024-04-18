using System;
namespace PersonalFinanceTracker.Models
{
    public class Budget
    {

        public int budget_id { get; set; }
        public int user_id { get; set; }
        public decimal monthly_budget { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class DashboardViewModel
    {
        public decimal MonthlyBudget { get; set; }
        public decimal MonthlyExpenses { get; set; }
        public decimal RemainingBudget { get; set; }
    }

    public class Expense
    {
        public int expense_id { get; set; }
        public int user_id { get; set; }
        public int budget_id { get; set; }
        public string expense_type { get; set; }
        public decimal amount { get; set; }
        public DateTime expense_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }

    public class ExpenseForecast
    {
        public int forecast_id { get; set; }
        public int user_id { get; set; }
        public int budget_id { get; set; }
        public string expense_type { get; set; }
        public decimal predicted_amount { get; set; }
        public DateTime forecast_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
    public class User
    {
        public int user_id { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
    public class TeamMember
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImageUrl { get; set; }
        public string Bio { get; set; }
    }
}

