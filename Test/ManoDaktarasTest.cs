using NUnit.Framework;


namespace BaigiamasisDarbasInesa.Test
{
  public class ManoDaktarasTest : BaseTest
    {
        [TestCase("165", "65", "23.88", TestName = "Ugis165,svoris65")]
       // [TestCase("170", "70", "24.22", TestName = "Ugis170,svoris70")]
        //[TestCase("180", "80", "24.69", TestName = "Ugis180,svoris80")]

        [Test]
        public static void TestKmiSkaiciuokle(string asmensUgis, string asmensSvoris, string asmensKmi)
        {
            kmiSkaiciuoklePage.NavigateToPage();
            kmiSkaiciuoklePage.closeSutikimaClick();
            kmiSkaiciuoklePage.InputToFieldUgis(asmensUgis);
            kmiSkaiciuoklePage.InputToFieldSvoris(asmensSvoris);
            kmiSkaiciuoklePage.ClickKmiButton();
            kmiSkaiciuoklePage.VerifyResultKmi(asmensKmi);

        }
  }
}
