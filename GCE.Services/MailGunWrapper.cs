using System;
using RestSharp;
using RestSharp.Authenticators;

namespace GCE.Services
{
    public class MailGunWrapper
    {
        public static IRestResponse GetLogs()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://api.mailgun.net/v3");
            client.Authenticator =
                new HttpBasicAuthenticator("api",
                    "key-55e024ce7b6f0e8c21fd4bee60fe0671");
            RestRequest request = new RestRequest();
            request.AddParameter("domain", "sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org", ParameterType.UrlSegment);
            request.Resource = "{domain}/events";
            request.AddParameter("limit", 25);
            request.AddParameter("event", "stored");
            return client.Execute(request);
        }

        public static IRestResponse GetMessage(string uri)
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri(uri);
            client.Authenticator =
                new HttpBasicAuthenticator("api",
                    "key-55e024ce7b6f0e8c21fd4bee60fe0671");
            RestRequest request = new RestRequest();
            return client.Execute(request);

        }

    }
}


//{
//  "items": [
//    {
//      "tags": [], 
//      "timestamp": 1454514033.189952, 
//      "storage": {
//        "url": "https://api.mailgun.net/v2/domains/sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org/messages/WyJlZDcyOTM2OTFjIiwgWyI1ZjExZWFjYi05NjEyLTQ2MTMtYTUwOC0yNjYyNDA3ZTk4OGYiXSwgIm1haWxndW4iLCAib2RpbiJd", 
//        "key": "WyJlZDcyOTM2OTFjIiwgWyI1ZjExZWFjYi05NjEyLTQ2MTMtYTUwOC0yNjYyNDA3ZTk4OGYiXSwgIm1haWxndW4iLCAib2RpbiJd"
//      }, 
//      "log-level": "info", 
//      "id": "z6voRxJ_QEO850HJeI3KcA", 
//      "campaigns": [], 
//      "user-variables": {}, 
//      "flags": {
//        "is-test-mode": false
//      }, 
//      "message": {
//        "headers": {
//          "to": "tickets@sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org", 
//          "message-id": "CAMb8S-qwqv4Jj2yHxtiJndpV0W+kEbMff_eAVk2OkhDfqxVv3Q@mail.gmail.com", 
//          "from": "\"Web Teks, Inc. Team\" <forwarding-noreply@google.com>", 
//          "subject": "(#608188029) Web Teks, Inc. Forwarding Confirmation - Receive Mail from aleksey.mykhaylichenko@webteks.com"
//        }, 
//        "attachments": [], 
//        "recipients": [
//          "tickets@sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org"
//        ], 
//        "size": 4336
//      }, 
//      "event": "stored"
//    }
//  ], 
//  "paging": {
//    "next": "https://api.mailgun.net/v3/sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org/events/W3siYiI6ICIyMDE2LTAyLTAzVDE1OjQxOjEyLjI5NyswMDowMCIsICJlIjogIjIwMTYtMDItMDFUMTU6NDE6MTIuMjk4KzAwOjAwIn0sIHsiYiI6ICIyMDE2LTAyLTAzVDE1OjQwOjMzLjE4OSswMDowMCIsICJlIjogIjIwMTYtMDItMDFUMTU6NDE6MTIuMjk4KzAwOjAwIn0sIFsiZiJdLCBudWxsLCBbWyJhY2NvdW50LmlkIiwgIjU2YjFjYTc2NzhmYTE2Njc0ZDE3OTg5MyJdLCBbImRvbWFpbi5uYW1lIiwgInNhbmRib3hkNThmMTE0MWNkZjE0ZjllYmVmZjAzMDBhZGFmMmJjOC5tYWlsZ3VuLm9yZyJdLCBbImV2ZW50IiwgInN0b3JlZCJdXSwgMjUsICJtZXNzYWdlI3o2dm9SeEpfUUVPODUwSEplSTNLY0EiXQ==", 
//    "last": "https://api.mailgun.net/v3/sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org/events/W3siYiI6ICIyMDE2LTAyLTAzVDE1OjQxOjEyLjI5NyswMDowMCIsICJlIjogIjIwMTYtMDItMDFUMTU6NDE6MTIuMjk4KzAwOjAwIn0sIHsiYiI6ICIyMDE2LTAyLTAxVDE1OjQxOjEyLjI5OCswMDowMCIsICJlIjogIjIwMTYtMDItMDNUMTU6NDE6MTIuMjk3KzAwOjAwIn0sIFsicCIsICJmIl0sIG51bGwsIFtbImFjY291bnQuaWQiLCAiNTZiMWNhNzY3OGZhMTY2NzRkMTc5ODkzIl0sIFsiZG9tYWluLm5hbWUiLCAic2FuZGJveGQ1OGYxMTQxY2RmMTRmOWViZWZmMDMwMGFkYWYyYmM4Lm1haWxndW4ub3JnIl0sIFsiZXZlbnQiLCAic3RvcmVkIl1dLCAyNSwgbnVsbF0=", 
//    "first": "https://api.mailgun.net/v3/sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org/events/W3siYiI6ICIyMDE2LTAyLTAzVDE1OjQxOjEyLjI5NyswMDowMCIsICJlIjogIjIwMTYtMDItMDFUMTU6NDE6MTIuMjk4KzAwOjAwIn0sIHsiYiI6ICIyMDE2LTAyLTAzVDE1OjQxOjEyLjI5NyswMDowMCIsICJlIjogIjIwMTYtMDItMDFUMTU6NDE6MTIuMjk4KzAwOjAwIn0sIFsiZiJdLCBudWxsLCBbWyJhY2NvdW50LmlkIiwgIjU2YjFjYTc2NzhmYTE2Njc0ZDE3OTg5MyJdLCBbImRvbWFpbi5uYW1lIiwgInNhbmRib3hkNThmMTE0MWNkZjE0ZjllYmVmZjAzMDBhZGFmMmJjOC5tYWlsZ3VuLm9yZyJdLCBbImV2ZW50IiwgInN0b3JlZCJdXSwgMjUsIG51bGxd", 
//    "previous": "https://api.mailgun.net/v3/sandboxd58f1141cdf14f9ebeff0300adaf2bc8.mailgun.org/events/W3siYiI6ICIyMDE2LTAyLTAzVDE1OjQxOjEyLjI5NyswMDowMCIsICJlIjogIjIwMTYtMDItMDFUMTU6NDE6MTIuMjk4KzAwOjAwIn0sIHsiYiI6ICIyMDE2LTAyLTAzVDE1OjQwOjMzLjE4OSswMDowMCIsICJlIjogIjIwMTYtMDItMDNUMTU6NDE6MTIuMjk4KzAwOjAwIn0sIFsicCIsICJmIl0sIG51bGwsIFtbImFjY291bnQuaWQiLCAiNTZiMWNhNzY3OGZhMTY2NzRkMTc5ODkzIl0sIFsiZG9tYWluLm5hbWUiLCAic2FuZGJveGQ1OGYxMTQxY2RmMTRmOWViZWZmMDMwMGFkYWYyYmM4Lm1haWxndW4ub3JnIl0sIFsiZXZlbnQiLCAic3RvcmVkIl1dLCAyNSwgIm1lc3NhZ2UjejZ2b1J4Sl9RRU84NTBISmVJM0tjQSJd"
//  }
//}
