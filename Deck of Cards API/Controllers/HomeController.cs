﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Deck_of_Cards_API.Models;

namespace Deck_of_Cards_API.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Deck()
    {
        return View(DeckDAL.GetDeck("new"));
    }

    [HttpPost]
    public IActionResult Deck(string deckId)
    {
        return View(DeckDAL.GetDeck(deckId));
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

