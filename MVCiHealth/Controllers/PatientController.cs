﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCiHealth.Models;

namespace MVCiHealth.Controllers
{
    public class PatientController : Controller
    {
        // GET: Patient
        public ActionResult Index()
        {
            var p = new PATIENT()
            {
                NAME = "TestUser",
                BIRTH = DateTime.Parse("2014-02-28"),
                GENDER = "男",
                TEL = "021-62233333",
                TEL2 = "13823333333",
                EMAIL = "administrator@cs.ecnu.edu.cn",
                ADDRESS = "上海市普陀区中山北路3663号",
                BLOOD_TYPE = "O",
                ALLERGIC_HISTORY = "无",
                GENETIC_HISTORY = "无",
                CAPITAL_OPERATION = "无",
                EMERGENCY_NAME = "Tony",
                EMERGENCY_TEL = "13852333333",
                COMMENT = "呵呵"
            };
            return View(p);
        }

        public ActionResult EditInfo()
        {
            var p = new PATIENT()
            {
                NAME = "TestUser",
                BIRTH = DateTime.Parse("2014-02-28"),
                GENDER = "男",
                TEL = "021-62233333",
                TEL2 = "13823333333",
                EMAIL = "administrator@cs.ecnu.edu.cn",
                ADDRESS = "上海市普陀区中山北路3663号",
                BLOOD_TYPE = "O",
                ALLERGIC_HISTORY = "无",
                GENETIC_HISTORY = "无",
                CAPITAL_OPERATION = "无",
                EMERGENCY_NAME = "Tony",
                EMERGENCY_TEL = "13852333333",
                COMMENT = "呵呵"
            };
            return View(p);
        }
    }
}