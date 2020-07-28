using ManMonth_IServices.IServices;
using ManMonth_Model;
using ManMonth_Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManMonth.Controllers
{
    public class ManController : Controller
    {
        private readonly INewServices _newServices;
        public ManController(INewServices newServices)
        {
            _newServices = newServices;
        }
        public ActionResult Admin()
        {
            return View();
        }      
        public ActionResult InsertMan()
        {           
                var user = _newServices.Set();
                return View(user);
        }
        [HttpGet]
        public ActionResult AddMan()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMan([Bind(Include = "Id, NewTitle, NewContent, NewLevel, NewWriter")] NewMan Man)
        {
            NewMan newMan = this._newServices.Insert(Man);
            AjaxResult ajaxResult = new AjaxResult()
            {
                Result = DoResult.Success,
                PromptMsg = "插入成功"
            };
            return Json(ajaxResult);
        }
        [HttpGet]
        public ActionResult EditMan(int? id)
        {
            if (id == null)
            {
                throw new Exception("need commodity id");
            }
            NewMan newMan = _newServices.Find(id ?? -1);
            if (newMan == null)
            {
                throw new Exception("Not Found");
            }
            //ViewBag.categoryList = BuildCategoryList();
            return View(newMan);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMan([Bind(Include = "Id, NewTitle, NewContent, NewLevel, NewWriter")] NewMan Man)
        {
            if (ModelState.IsValid)
            {
                NewMan newMan = _newServices.Find(Man.Id);
                newMan.NewTitle = Man.NewTitle;
                newMan.NewContent = Man.NewContent;
                newMan.NewLevel = Man.NewLevel;
                newMan.NewWriter = Man.NewWriter;
                _newServices.Update(newMan);
                //return RedirectToAction("Admin");
                return View();
            }
            else
                throw new Exception("ModelState未通过检测");
        }
        [HttpPost]
        public ActionResult DeleteMan(int id)
        {
             _newServices.Delete(id);
             AjaxResult ajaxResult = new AjaxResult()
             {
                 Result = DoResult.Success,
                 PromptMsg = "删除成功"
             };
             return Json(ajaxResult);            
        }
    }
}