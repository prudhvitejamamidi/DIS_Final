﻿using Microsoft.AspNetCore.Mvc;
using PersonalFinanceTracker.Models;
using PersonalFinanceTracker.Repositories;

namespace PersonalFinanceTracker.Controllers
{
    public class AboutController : Controller
    {
        private readonly TeamMemberRepository _teamMemberRepository;

        public AboutController(TeamMemberRepository teamMemberRepository)
        {
            _teamMemberRepository = teamMemberRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Team()
        {
            // Retrieve the team members from the repository
            var teamMembers = _teamMemberRepository.GetTeamMembers();
            return View(teamMembers);
        }
    }
}