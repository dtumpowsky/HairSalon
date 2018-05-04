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
        public ActionResult AddStylist()
        {
            return View();
        }

//gathers stylist input from boostrap form
        [HttpPost("/stylist/add")]
        public ActionResult AddStylist()
        {
            Stylist newStylist = new Stylist(Request.Form["stylist-full-name"]);

            List <Stylist> allStyists = Stylist.GetAll();
            return View("StylistList", allStylists);
        }

//client list for specific stylist
        [HttpGet("/stylist/client")]
        public ActionResult ClientList()
        {
            List <Client> allClients = ClientList.GetStylistId().GetAll();
            return View();
        }

//boostrap form to input client info to specific stylist
        [HttpGet("/stylist/client/new")]
        public ActionResult AddClient()
        {
            return View();
        }
//gather input to add to specific stylist list

        [HttpPost("/stylist/client/new")]
        public ActionResult AddClient()
        {
            Client newClient = new Client(Request.Form["client-full-name"]);

            List <Client> allClients = Client.GetAll();
            return View("StylistLists");
        }
