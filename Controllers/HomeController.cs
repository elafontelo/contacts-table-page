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
            //Contacts contact = new Contacts();

            //using (MySqlConnection connect = new MySqlConnection("Data Source=localhost; port=3306; Database=testdb; UserId=root; password=123456"))
            //{
            //    connect.Open();
            //    string select = "Select * from contacts";
            //    MySqlCommand selectCmd = new MySqlCommand();
            //    selectCmd.CommandText = select;
            //    selectCmd.Connection = connect;
            //    MySqlDataAdapter adapter = new MySqlDataAdapter();
            //    adapter.SelectCommand = selectCmd;
            //    DataSet set = new DataSet();
            //    var count = set.Tables.Count;
            //    adapter.Fill(set);
            //    var count2 = set.Tables.Count;
            //    foreach (var item in set.Tables)
            //    {
            //        var test = item;
            //    }
            //    //gv_contacts.DataSource = set;
            //    //gv_contacts.DataBind;
            //    connect.Close();
            //}
        }
    }
}