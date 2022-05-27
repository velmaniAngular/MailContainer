using MailContainerTest.Types;
namespace MailContainerTest.BusinessValidators
{
    public class StandardLetterValidator : IMailContainerValidator
    {
       public bool IsValidMailData(MailContainer mailContainer, int numberOfMailItems)
       {
           if (mailContainer == null)
                {
                    return false;
                }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.StandardLetter))
                {
                        return false;
                }
                else
                {
                    return true;
                }
       }

    }
}
