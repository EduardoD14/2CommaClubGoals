using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwoCommaClubGoals.Entities;
using TwoCommaClubGoals.Abstract;
using TwoCommaClubGoals.Models;


public class CartController : Controller
{
    private ILessonRepository repository;
    private IOrderProcessor orderProcessor;
    public CartController(ILessonRepository repo, IOrderProcessor proc)
    {
        repository = repo;
        orderProcessor = proc;
    }
    public CartController(ILessonRepository repo)
    {
        repository = repo;
    }
    public ViewResult Index(Cart cart, string returnUrl)
    {
        return View(new CartIndexViewModel
        {
            ReturnUrl = returnUrl,
            Cart = cart
        }
        );
    }
    public RedirectToRouteResult AddToCart(Cart cart, int LessonID, string returnUrl)
    {
        Lesson Lesson = repository.Lessons.FirstOrDefault(p => p.LessonID == LessonID);
        if (Lesson != null)
        {
            cart.AddItem(Lesson, 1);
        }
        return RedirectToAction("Index", new
        {
            returnUrl
        }
        );
    }
    public RedirectToRouteResult RemoveFromCart(Cart cart, int LessonID, string returnUrl)
    {
        Lesson Lesson = repository.Lessons.FirstOrDefault(p => p.LessonID == LessonID);
        if (Lesson != null)
        {
            cart.RemoveLine(Lesson);
        }
        return RedirectToAction("Index", new
        {
            returnUrl
        }
        );
    }
    public PartialViewResult Summary(Cart cart)
    {
        return PartialView(cart);
    }
    public ViewResult Checkout()
    {
        return View();
    }
    [HttpPost]
    public ViewResult Checkout(Cart cart)
    {
        if (cart.Lines.Count() == 0)
        {
            ModelState.AddModelError("", "Sorry, your cart is empty!");
        }
        if (ModelState.IsValid)
        {
            orderProcessor.ProcessOrder(cart);
            cart.Clear();
            return View("Completed");
        }
        else
        {
            return View();
        }
    }
}