using GVRP.Module.Logging;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;

namespace GVRP.Handler
{
    public class DiscordHandler
    {
        private string m_LiveWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        //private string m_TestWebhookURL = "https://discord.com/api/webhooks/931420765436379136/LtcXikkfvd47P67KitNMp0couPEDPkvNfXnWsQ9Fjc0VceqpLaEnZtGlywmf3QS8EfhM";
        private string m_BanWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_ExceptionLoggerURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_KillWebhookURL = " https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_SupportWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_ReviveWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_KickWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_FeatureWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_AutoshopWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_BankingWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_AdminWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_CoordWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_FIBWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_WorkstationWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";
        private string m_AnticheatWebhookURL = "https://discord.com/api/webhooks/925440466378448916/cvPmTRQjf22r8uYRGHnI3xx3RHhuRxmHy14U_JyeC3n-IqI3W2hHqOj0Nfkwqjn5bwwi";

        public DiscordHandler()
        {
        }

        public enum Channels
        {
            FEATURE,
            REVIVE,
            KICK,
            BAN,
            SUPPORT,
            WORKSTATION,
            KILL,
            WEAPONLAB,
            METHLAB,
            AUTOSHOP,
            ANTICHEAT,
            SHOP,
            DUPING,
            FORUM,
            SERVERSTART,
            ADMIN,
            BANKING,
            BLITZER,
            FUELSTATION,
            AKTEN,
            BUSINESS,
            FRAKTION,
            COMPUTER,
            DEALER,
            EINREISE,
            FIB,
            FARMING,
            GANGWAR,
            INJURY,
            JAIL,
            LSC,
            MENU,
            NEWS,
            BLACKMONEY,
            SERVICE,
            PHONE,
            COORDS,
            EXCEPTION,
            DEFAULT


        }

        public void SendMessage(string p_Message, string p_Description = "", Channels channel = Channels.DEFAULT)
        {

            try
            {

                DiscordMessage l_Message = new DiscordMessage($"{p_Message}", p_Description);

                using (WebClient l_WC = new WebClient())
                {
                    l_WC.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                    l_WC.Encoding = Encoding.UTF8;

                    string l_Upload = JsonConvert.SerializeObject(l_Message);

                    switch (channel)
                    {
                        case Channels.KILL:
                            l_WC.UploadString(m_KillWebhookURL, l_Upload);
                            break;
                        case Channels.BAN:
                            l_WC.UploadString(m_BanWebhookURL, l_Upload);
                            break;

                        case Channels.COORDS:
                            l_WC.UploadString(m_CoordWebhookURL, l_Upload);
                            break;

                        case Channels.ADMIN:
                            l_WC.UploadString(m_AdminWebhookURL, l_Upload);
                            break;

                        case Channels.BANKING:
                            l_WC.UploadString(m_BankingWebhookURL, l_Upload);
                            break;

                        case Channels.AUTOSHOP:
                            l_WC.UploadString(m_AutoshopWebhookURL, l_Upload);
                            break;

                        case Channels.FEATURE:
                            l_WC.UploadString(m_FeatureWebhookURL, l_Upload);
                            break;

                        case Channels.REVIVE:
                            l_WC.UploadString(m_ReviveWebhookURL, l_Upload);
                            break;

                        case Channels.KICK:
                            l_WC.UploadString(m_KickWebhookURL, l_Upload);
                            break;

                        case Channels.SUPPORT:
                            l_WC.UploadString(m_SupportWebhookURL, l_Upload);
                            break;

                        case Channels.ANTICHEAT:
                            l_WC.UploadString(m_AnticheatWebhookURL, l_Upload);
                            break;

                        case Channels.EXCEPTION:
                            l_WC.UploadString(m_ExceptionLoggerURL, l_Upload);
                            break;
                        case Channels.FIB:
                            l_WC.UploadString(m_FIBWebhookURL, l_Upload);
                            break;
                        case Channels.WORKSTATION:
                            l_WC.UploadString(m_WorkstationWebhookURL, l_Upload);
                            break;

                        case Channels.DEFAULT:
                            l_WC.UploadString(m_LiveWebhookURL, l_Upload);
                            break;
                        default:
                            l_WC.UploadString(m_LiveWebhookURL, l_Upload);
                            break;

                    }

                    /*if (Configuration.Instance.DevMode)
                        l_WC.UploadString(m_TestWebhookURL, l_Upload);
                    else
                        l_WC.UploadString(m_LiveWebhookURL, l_Upload);*/
                }
            }
            catch (Exception e)
            {
                Logger.Crash(e);
                // muss funken lol
                // grüße von monkaMC
            }
        }
    }

    public class DiscordMessage
    {
        public string content { get; private set; }
        public bool tts { get; private set; }
        public EmbedObject[] embeds { get; private set; }

        public DiscordMessage(string p_Message, string p_EmbedContent)
        {
            content = p_Message;
            tts = false;

            EmbedObject l_Embed = new EmbedObject(p_EmbedContent);
            embeds = new EmbedObject[] { l_Embed };
        }
    }

    public class EmbedObject
    {
        public string title { get; private set; }
        public string description { get; private set; }

        public EmbedObject(string p_Desc)
        {
            title = DateTime.Now.ToString();
            description = p_Desc;
        }
    }
}
