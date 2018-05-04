using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HairSalon;
using System;
using Microsoft.AspNetCore.Mvc;

namespace HairSalon.Models
{
    public class Client
    {
        private string _clientName;
        private int _stylistId;
        private int _id;

        public Client(string clientName, int stylistId, int id=0)
        {
            _clientName = clientName;
            _stylistId = stylistId;
            _id = id;
        }

        public string GetClientName()
        {
            return _clientName;
        }
        public void SetName(string ClientName)
        {
            _clientName = ClientName;
        }

        public int GetStylistId()
        {
          return _stylistId;
        }

        public int GetClientId()
        {
            return _id;
        }
