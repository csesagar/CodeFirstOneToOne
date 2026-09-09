using MVCWithEFCF6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithEFCF6.Controllers
{
    public class FamilyController : Controller
    {
        FamilyDbContext dc = new FamilyDbContext();
        public ActionResult Index()
        {
            Player p1 = new Player { PlayerId = 101, Name = "Sachin Ramesh Tendulkar", Profession = "Cricketer" };
            Player p2 = new Player { PlayerId = 102, Name = "Rishab Pant", Profession = "Cricketer" };
            Player p3 = new Player { PlayerId = 103, Name = "Mahindra Singh Dhoni", Profession = "Cricketer" };
            Spouse s1 = new Spouse { PlayerId = 101, SpouseName = "Anjali", SpouseProfession = "Doctor" };
            Spouse s2 = new Spouse { PlayerId = 103, SpouseName = "Sakshi", SpouseProfession = "Home Maker" };
            dc.Players.Add(p1); dc.Players.Add(p2); dc.Players.Add(p3);
            dc.Spouses.Add(s1); dc.Spouses.Add(s2);
            dc.SaveChanges();
            return View(dc.Players);
        }
    }
}