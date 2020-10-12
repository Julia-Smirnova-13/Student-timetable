﻿using LibOfTimetableOfClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestOfTimetableOfClasses
{
    [TestClass]
    public class UT_DCTitle
    {
        RefData refData = new RefData();
        [TestMethod]
        public void DCTitle_1()
        {
            MTitle T_Title = new MTitle("Проф.", "Профессор");
            bool ex = true;
            //act
            refData.CTitle.Insert(T_Title);
            bool act = refData.CTitle.Delete(T_Title);
            //assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void DCTitle_2()
        {
            //act
            MTitle T_Title = new MTitle("Проф.", "Профессор");
            bool ex = false;
            bool act = refData.CTitle.Delete(T_Title);
            //assert
            Assert.AreEqual(ex, act);
        }
    }
}
