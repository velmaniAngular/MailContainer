using System.Reflection;
using MailContainerTest.Types;
namespace MailContainerTest.BusinessValidators.Tests
{
    [TestClass()]
    public class LargeLetterValidatorTests
    {
        [TestMethod()]
       public void LargeLetter_ShouldReturnFalse_WhenContainerIsNull()
       {
             var mailContainer = new MainContainer();
             var validator = new LargeLetterValidator();
             var result= validator.IsValidMailData(mailContainer,0);
             Assert.AreEqual(false, result);

       }

    }
}
