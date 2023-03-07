using Microsoft.Extensions.Options;
using Module.Account.BL.Security;
using System.Net;

namespace Module.Account.Helper
{
    internal interface ISMS
    {
        public string SendSMS(string MobileNum, string Message);
    }

    internal class SMS : ISMS
    {
        private readonly VariableConfig _tokenManagement;

        public SMS(IOptions<VariableConfig> tokenManagement)
        {
            _tokenManagement = tokenManagement.Value;
        }

        public string SendSMS(string MobileNum, string Message)
        {
            try
            {
                WebClient client1 = new WebClient();
                string baseurl1 = "http://mshastra.com/sendurlcomma.aspx?user=" + _tokenManagement.ProfileId + "&pwd=" + _tokenManagement.Password + "&senderid=" + _tokenManagement.SenderId + "&CountryCode=ALL&mobileno=" + MobileNum + "&msgtext=" + Message;
                Stream data1 = client1.OpenRead(baseurl1);
                StreamReader reader1 = new StreamReader(data1);
                string s1 = reader1.ReadToEnd();
                data1.Close();
                reader1.Close();
                return s1.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }

            // return "";
        }
    }
}