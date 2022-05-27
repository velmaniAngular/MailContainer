using MailContainerTest.Types;

namespace MailContainerTest.Data
{
    public class  IMailContainerDataStore
    {
        MailContainer GetMailContainer(string mailContainerNumber);
        void UpdateMailContainer(MailContainer mailContainer);
    }
}