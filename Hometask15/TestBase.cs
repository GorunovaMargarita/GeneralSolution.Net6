﻿using BusinessObject.SalesForce;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask15
{
    public class TestBaseSalesForce : TestBase
    {
        protected ApplicationHelper appHelper = new ApplicationHelper(Browser.Instance.Driver);
    }
}
