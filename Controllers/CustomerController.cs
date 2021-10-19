using System.Collections.Generic;
using System.Linq;
using prn211_demo.DB;
using prn211_demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace prn211_demo.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDBContext _db;
        public CustomerController(ApplicationDBContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            //hung' doi tuong, lay doi tuong
            IEnumerable<Customer> customerList = this._db.Customers;
            //truyen customerList vao trong View, View co du lieu
            return View(customerList);
        }

        //Action Create nay dung de hien giao dien
        public IActionResult Create()
        {
            //your code here
            return View();
        }

        //Action Create nay de dien thong tin nguoi dung dien vao
        [HttpPost]
        //dung de chong tan cong mang >.<
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer obj)
        {
            //your code here
            if (ModelState.IsValid)
            {
                this._db.Customers.Add(obj);
                this._db.SaveChanges();
                return RedirectToAction("Index");
            }
            //neu loi~, du lieu se dc truyen nguoc lai view => dung' tai do
            return View(obj);
        }

        public IActionResult Delete(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            var item = this._db.Customers.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //kiem tra xem khi bam Confirm trong trang Delete thi doi tuong da dc xoa chua
        //neu chua thi remove
        public IActionResult DeleteCustomer(string cus_id)
        {
            var item = this._db.Customers.Find(cus_id);
            if (item == null)
            {
                return NotFound();
            }
            this._db.Customers.Remove(item);
            this._db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Update(string id)
        {
            if (id == null || id == "")
            {
                return NotFound();
            }
            var item = this._db.Customers.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateCustomer(Customer obj)
        {
            try
            {
                var customer = _db.Customers.Select(c => c).Where(c => c.cus_id == obj.cus_id).FirstOrDefault();
                customer.cus_name = obj.cus_name;
                customer.cus_gender = obj.cus_gender;
                customer.cus_birthday = obj.cus_birthday;
                customer.cus_address = obj.cus_address;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}