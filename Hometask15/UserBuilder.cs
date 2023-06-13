﻿using Bogus;
using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hometask15
{
    public class UserBuilder
    {

        public static User GetSalesForceUser() => new User(Browser.GetRunSetting("UserName"), Browser.GetRunSetting("UserPass"));

        public static User GetRandomUser() => new User(Faker.InternetFaker.Email(), Faker.StringFaker.Alpha(10));
    }
}
