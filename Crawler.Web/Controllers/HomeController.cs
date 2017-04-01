using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crawler.Domain;
using Crawler.Tool.AutoMapper;

namespace Crawler.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            CompanyJson json = new CompanyJson()
            {
                com_id = 1,
                c_id = 2
            };

            CompanyDTO dto = EntityMapper.EntityMapperMethod<CompanyDTO, CompanyJson>(json);
            var a = dto;
            
           
            return View();
        }

    }
}
