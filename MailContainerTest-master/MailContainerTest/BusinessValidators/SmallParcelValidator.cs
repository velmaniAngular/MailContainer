
using MailContainerTest.Types;
using System.Reflection.Metadata.Ecma335;
namespace MailContainerTest.BusinessValidators
{
    public class SmallParcelValidator : IMailContainerValidator
    {
       public bool IsValidMailData(MailContainer mailContainer, int numberOfMailItems)
       {
            if (mailContainer == null)
                {
                    return false;
                }
            else if (!mailContainer.AllowedMailType.HasFlag(AllowedMailType.SmallParcel))
                {
                    return false;
                }
            else if (mailContainer.Status != MailContainerStatus.Operational)
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
