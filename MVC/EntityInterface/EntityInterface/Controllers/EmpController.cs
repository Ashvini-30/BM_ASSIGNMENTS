using EntityInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityInterface.Controllers
{
    public class EmpController : Controller
    {
        EmployeeDBEntities em = new EmployeeDBEntities();

        public object[] Empno { get; private set; }


        // GET: Emp
        public ActionResult Index()
        {


            return View(em.Employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            // return View(em.Employees.Find(Empno));
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            em.Employees.Add(e);
            em.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(em.Employees.Find(id));
        }
        [HttpPost]

         public ActionResult Edit(Employee e1, FormCollection collection)
          {
              Employee e = em.Employees.Find(e1.Empno);
              e.Empno = Convert.ToInt32(collection["Empno"].ToString());
              e.Ename = collection["Ename"].ToString();
              e.Designation = collection["Designation"].ToString();
              e.salary = Convert.ToDecimal(collection["salary"].ToString());
              e.Deptno = Convert.ToInt32(collection["Deptno"].ToString());

              em.SaveChanges();
              return RedirectToAction("Index");

          }

        [HttpGet]
          public ActionResult Delete(int id)
          {
              return View(em.Employees.Find(id));
          }

          [HttpPost]
           public ActionResult Delete(FormCollection collection)
           {
            Employee e = em.Employees.Find(Convert.ToInt32(collection["hdnempno"].ToString()));
            em.Employees.Remove(e);
            em.SaveChanges();
            return RedirectToAction("Index");

        }

      /* [HttpGet]
           public ActionResult Details(int Empno)
           {
               return View(em.Employees.Where(x => x.Empno == Empno).FirstOrDefault());
           }*/



    }
}