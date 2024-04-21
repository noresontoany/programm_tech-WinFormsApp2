using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp2.Form1;

namespace WinFormsApp2.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestClass()]
        public class logicTests
        {

            [TestMethod()]
            public void cop1()
            {
                var cop = 1; //cop == 1, склонение 

                var message = logic.answer(cop);

                Assert.AreEqual("только 1 копейка", message);
            }

            [TestMethod()]
            public void cop2()
            {
                var cop = 653; //последняя цифра в числе [2, 4],1 < cop < 1000 , склонение

                var message = logic.answer(cop);

                Assert.AreEqual("6 рублей  53 копейки", message);
            }

            [TestMethod()]
            public void cop3()
            {
                var cop = 205; //последняя цифра или число в числе(cop) [5, 20],1 < cop < 1000 , склонение

                var message = logic.answer(cop);

                Assert.AreEqual("2 рубля  5 копеек", message);
            }


            [TestMethod()]
            public void cop4()
            {
                var cop = 1001; //  9999 > cop > 999, последняя цифра в числе - единица, склонение 

                var message = logic.answer(cop);

                Assert.AreEqual("10 рублей  1 копейка", message);
            }

            [TestMethod()]
            public void cop5()
            {
                var cop = 1004; //последняя цифра в числе [2, 4], 9999 > cop > 999 , склонение

                var message = logic.answer(cop);

                Assert.AreEqual("10 рублей  4 копейки", message);
            }


            [TestMethod()]
            public void cop6()
            {
                var cop = 2017; //последняя цифра или число в числе(cop) [5, 20], 9999 > cop > 999 , склонение

                var message = logic.answer(cop);

                Assert.AreEqual("20 рублей  17 копеек", message);
            }

            [TestMethod()]
            public void rub1()
            {
                var cop = 101; //первая цифра в числе это единица, 99 < cop < 1000 , склонение

                var message = logic.answer(cop);

                Assert.AreEqual("1 рубль  1 копейка", message);
            }

            [TestMethod()]
            public void rub2()
            {
                var cop = 201; //первая цифра в числе [2, 4], 99 < cop < 1000 , склонение

                var message = logic.answer(cop);

                Assert.AreEqual("2 рубля  1 копейка", message);
            }


            [TestMethod()]
            public void rub3()
            {
                var cop = 501; // первая цифра или число в числе(cop) [5, 20], 99 < cop < 1000 , склонение 

                var message = logic.answer(cop);

                Assert.AreEqual("5 рублей  1 копейка", message);
            }


            [TestMethod()]
            public void rub4()
            {
                var cop = 2100; //  вторая цифра в числе это единица, 1 < cop < 1000 , склонение 

                var message = logic.answer(cop);

                Assert.AreEqual("21 рубль", message);
            }

            [TestMethod()]
            public void rub5()
            {
                var cop = 2243; //  вторая цифра в числе [2, 4],1 < cop < 1000 , склонение 

                var message = logic.answer(cop);

                Assert.AreEqual("22 рубля  43 копейки", message);
            }



            [TestMethod()]
            public void rub6()
            {
                var cop = 6001; // вторая цифра или число в числе(cop) [5, 20],1 < cop < 1000 , склонение 

                var message = logic.answer(cop);

                Assert.AreEqual("60 рублей  1 копейка", message);
            }
        }




       


    }

}

    
