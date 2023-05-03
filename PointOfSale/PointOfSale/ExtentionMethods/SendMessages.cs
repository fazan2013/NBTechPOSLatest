using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.MSIdentity.Shared;
using PointOfSale.Models;
using System.Drawing;

namespace PointOfSale.ExtentionMethods
{
    public static class SendMessages
    {
        public async static Task<bool> SendSms() {

            var msg = false;
            
            using (var client = new HttpClient())
            {
                VMSms sms = new VMSms();
                client.BaseAddress = new Uri("https://app.notify.lk/api/v1/");
                //HTTP GET
                //
                sms.user_id = 24867;
                sms.api_key = "JIaOy9vIb2zROi2tuyKC";
                sms.sender_id = "NotifyDEMO";
                sms.to = 94770892438;
                sms.message = "initial message from fzn notify";
                var  responseTask = await client.PostAsJsonAsync("send", sms);
                if (responseTask.StatusCode.ToString() == "OK")
                {
                    msg = true;
                }
                else {
                    msg = false;
                }
                return msg;
            }
            //return responseTask;
        }
    }
}
