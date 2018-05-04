using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Models;
using System;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {
//Homepage
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

//List of Stylist home page
        [HttpGet("/stylist/new")]
        public ActionResult StylistList()
        {
            List <Stylist> allStylists = Stylist.GetAll();
            return View();
        }

//boostrap form to input stylist info
        [HttpGet("/stylist/add")]
        public ActionResult NewStylist()
        {
            return View();
        }

//gathers stylist input from boostrap form
        [HttpPost("/stylist/add")]
        public ActionResult CreateStylist()
        {
            Stylist newStylist = new Stylist(Request.Form["stylist-full-name"]);

            newStylist.Save();
            List <Stylist> allStylists = Stylist.GetAll();

            return View("StylistList", allStylists);
        }

//client list for specific stylist
        [HttpGet("/stylist/client")]
        public ActionResult ClientList()
        {
            List <Client> allClients = Client.GetAll();
            return View();
        }

//boostrap form to input client info to specific stylist
        [HttpGet("/stylist/client/new")]
        public ActionResult NewClient()
        {
            return View();
        }
//gather input to add to specific stylist list

//Errors with this route
        [HttpPost("/stylist/client/new")]
        public ActionResult AddClient()
        {
          Client newClientID = new List <Client>this.GetClientId();
          int newStylistSelection = int.Parse(Request.Form["stylist-list"]);
          string newClientName = Request.Form["client-full-list"];
          Client newClient = new Client(newClientId, newStylistSelection, newClientName);

          newClient.Save();
          return View("StylistList");
        }
    }
}
