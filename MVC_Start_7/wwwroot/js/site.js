// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Navigation links
const navLinks = document.querySelectorAll('nav ul li a');

// Handle navigation link clicks
navLinks.forEach(link => {
    link.addEventListener('click', (event) => {
        event.preventDefault();
        const targetPage = event.target.getAttribute('href');
        navigateToPage(targetPage);
    });
});

// Function to navigate to a specific page
function navigateToPage(page) {
    switch (page) {
        case '#':
            window.location.href = 'index.html';
            break;
        case '#login':
            window.location.href = 'login.html';
            break;
        case '#dashboard':
            window.location.href = 'dashboard.html';
            break;
        case '#add-expense':
            window.location.href = 'add-expense.html';
            break;
        case '#about':
            window.location.href = 'about.html';
            break;
        default:
            console.error('Invalid page target:', page);
    }
}

// Update the dashboard values (if on the dashboard page)
const monthlyBudget = document.getElementById('monthly-budget');
const monthlyExpenses = document.getElementById('monthly-expenses');
const remainingBudget = document.getElementById('remaining-budget');

// Example data
monthlyBudget.textContent = '$2,500';
monthlyExpenses.textContent = '$1,800';
remainingBudget.textContent = '$700';

// Add event listener to the "Get Started" button (on the index page)
const ctaButton = document.querySelector('.cta-button');
ctaButton.addEventListener('click', () => {
    navigateToPage('#login');
});

// Add event listener to the "Set Budget" button (on the dashboard page)
const setBudgetButton = document.getElementById('set-budget-button');
setBudgetButton.addEventListener('click', () => {
    const monthlyBudgetInput = document.getElementById('monthly-budget-input');
    const newBudget = monthlyBudgetInput.value;
    if (newBudget) {
        monthlyBudget.textContent = `$${newBudget}`;
        monthlyExpenses.textContent = `$${Math.min(1800, newBudget)}`;
        remainingBudget.textContent = `$${Math.max(0, newBudget - 1800)}`;
    }
});




// Update the dashboard values
const monthlyBudget = document.getElementById('monthly-budget');
const monthlyExpenses = document.getElementById('monthly-expenses');
const remainingBudget = document.getElementById('remaining-budget');

// Example data
monthlyBudget.textContent = '$2,500';
monthlyExpenses.textContent = '$1,800';
remainingBudget.textContent = '$700';



