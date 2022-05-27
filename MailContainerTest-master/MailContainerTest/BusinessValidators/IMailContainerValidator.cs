using MailContainerTest.Types;
namespace MailContainerTest.BusinessValidators
{
    public interface IMailContainerValidator
    {
        bool IsValidMailData(MailContainer mailContainer, int numberOfMailItems);
    }       
}