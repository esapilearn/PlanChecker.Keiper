using Microsoft.VisualStudio.TestTools.UnitTesting;
using ESAPX_StarterUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESAPIX.Constraints;

namespace ESAPX_StarterUI.ViewModels.Tests
{
    [TestClass()]
    public class CTDateConstraintTests
    {
        [TestMethod()]
        public void ConstrainTestFail()
        {
            //arrange
            var creationDate = DateTime.Now.AddDays(-61);

            //act
            var actual = new CTDateConstraint().Constrain(creationDate).ResultType;


            //assert
            var expected = ResultType.ACTION_LEVEL_3;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void ConstrainTestPass()
        {
            //arrange
            var creationDate = DateTime.Now.AddDays(-59);

            //act
            var actual = new CTDateConstraint().Constrain(creationDate).ResultType;


            //assert
            var expected = ResultType.PASSED;
            Assert.AreEqual(expected, actual);
        }
    }
}