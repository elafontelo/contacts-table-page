using ContactsTable.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using ContactsTable.DataAccess;

namespace ContactsTable.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var data = SQLDataAccess.GetContacts();
            List<Contacts> contacts = new List<Contacts>();

            foreach (var item in data)
            {
                contacts.Add(new Contacts
                {
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Address = item.Address,
                    State = item.State,
                    Country = item.Country,
                    ZipCode = item.ZipCode,
                    PhoneNumber = item.PhoneNumber,
                    Notes = item.Notes
                });

            }
            var test = contacts;

            return View(contacts);
        }
    }
}