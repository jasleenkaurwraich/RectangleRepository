using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle1;
using NUnit.Framework;


namespace Rectangle1nunittests
{
    [TestFixture]
     class RectTeatCases
    {
        [Test]
        //Test for GetLength
        public void GetLength_input8_expectedLengthEquals8()
        {

            int l = 8;
            int w = 4;
            Rectangle testRec = new Rectangle(l,w);
            int Length = testRec.GetLength();
            Assert.AreEqual(l, Length);




        }

        [Test]
        //Test for SetLength
        public void SetLength_input4_expectedLengthEquals4()
        {

            int l = 4;
            int w = 2;
            Rectangle testRec = new Rectangle(l, w);
            int Length = testRec.SetLength(l);
            Assert.AreEqual(l, Length);




        }

        [Test]
        //Test for GetWidth
        public void GetWidth_input2_expectedWidthEquals2()
        {

            int l = 2;
            int w = 6;
            Rectangle testRec = new Rectangle(l, w);
            int Width = testRec.GetWidth();
            Assert.AreEqual(w, Width);




        }

        [Test]
        //Test for SetWidth
        public void SetWidth_input9_expectedWidthEquals9()
        {

            int l = 4;
            int w = 2;
            Rectangle testRec = new Rectangle(l, w);
            int Width = testRec.SetWidth(w);
            Assert.AreEqual(w, Width);




        }


        [Test]
        public void Area_inputLength2Width4_expectedAreaEquals8()
        {

            int l = 7;
            int w = 8;
            int expectedResult = l * w;
            Rectangle testRec = new Rectangle(l, w);
            int actualResult = testRec.GetArea();
            Assert.AreEqual(expectedResult, actualResult);




        }

        [Test]
        public void Perimeter_inputLength8Width3_expectedPerimeterEquals8()
        {

            int l = 8;
            int w = 3;
            int expectedResult = (l*2)+(w*2);
            Rectangle testRec = new Rectangle(l, w);
            int actualResult = testRec.GetPerimeter();
            Assert.AreEqual(expectedResult, actualResult);

        }





    }


}
