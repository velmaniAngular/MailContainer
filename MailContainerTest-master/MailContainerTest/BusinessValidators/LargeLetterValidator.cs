using MailContainerTest.Types;
namespace MailContainerTest.BusinessValidators
{
    public class LargeLetterValidator : IMailContainerValidator
    {
       public bool IsValidMailData(MailContainer mailContainer, int numberOfMailItems)
       {
             if (mailContainer == null)
                {
                    return false;
                }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.LargeLetter))
                {
                   return false;
                }
            else if (mailContainer.Capacity < request.NumberOfMailItems)
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
