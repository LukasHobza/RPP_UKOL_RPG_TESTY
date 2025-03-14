using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using nemamRadDana;

namespace faktale
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form = new Form1();

        HerniPostava

        [TestMethod]
        public void kontrolaDelkyJmenaPostavycky()
        {
            Assert.IsTrue(form.GetJmeno());
        }

        [TestMethod]
        public void LevelIn()
        {
            int level = form.GetLevel(); 
            Assert.IsTrue(level == 1);
        }

        [TestMethod]
        public void XY()
        {
            int x, y;
            form.GetPosition(out x, out y);
            Assert.IsTrue(x == 0);
            Assert.IsTrue(y == 0);
            
        }
        [TestMethod]
        public void
    }
}
