using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAdressbokTests
{[TestFixture]
    public class UsersModificationTests : TestBase
    {
        [Test]
        public void UsersModificationTest()
        {

            DataUsers newData = new DataUsers("vasya", "adreev");
            newData.Lastname = "niloka";
            //перейти на бейзюрл
            //авторизоваться
            app.User.Modify(2, newData);
            //Перейти на домашнию страницу
            //выбрать юзера
            //нажать редактировать
            //изменить данные
            //подтвердить 
        }

    }
}
