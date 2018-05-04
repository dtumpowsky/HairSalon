using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HairSalon;
using System;
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Models
{
    public class Stylist
    {
        private string _stylistName;
        private int _id;

        public Stylist(string stylistName, int id = 0)
        {
            _stylistName = stylistName;
            _id = id;
        }

        public int GetId()
        {
            return _id;
        }

        public string GetStylistName()
        {
            return _stylistName;
        }
        public void SetStylistName(string StylistName)
        {
            _stylistName = StylistName;
        }
    }
}
