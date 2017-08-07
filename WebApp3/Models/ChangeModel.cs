using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Web;

namespace WebApp3.Models
{
    public class ChangeModel
    {
        [Required(ErrorMessage = "You must give your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "You must give your sort")]
        public string Resort { get; set; }
        public int Comments { get; set; }
        public string Rating
        {
            get; set;
        }

        public bool result {
            get;
            set;
        }


        public void Submit()
        {
            //MailMessage mm = new MailMessage(
            //                        Name + "@HolidayGuruClients.com",
            //                       "management@HolidayGuruClients.com",
            //                        string.Format("{0} rating for {1}", Rating, Resort),
            //                        Comments);

            //new SmtpClient().Send(mm);
            var client = new HttpClient();
            //基本的API URL
            client.BaseAddress = new Uri("http://localhost:14129/");
            //默认希望响应使用Json序列化(内容协商机制，我接受json格式的数据)
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //运行client接收程序
            client.PostAsJsonAsync("api/addCustomers", new Customer() { FirstName = Name, LastName = Resort, AmountOwed = Comments, DateOfBirth = Rating })
                                //返回请求是否执行成功，即HTTP Code是否为2XX
                                .ContinueWith(x => x.Result.IsSuccessStatusCode);

        }

    }
}