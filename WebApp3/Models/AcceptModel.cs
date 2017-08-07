using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace WebApp3.Models
{
    public class AcceptModel
    {

        public  Customer[] result {
            get;
            set;
        }

        public Customer[] getResult() {
            var client = new HttpClient();
            //基本的API URL
            client.BaseAddress = new Uri("http://localhost:14129/");
            //默认希望响应使用Json序列化(内容协商机制，我接受json格式的数据)
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var data = client.GetAsync("api/Customers")
                                    //获取返回Body，并根据返回的Content-Type自动匹配格式化器反序列化Body内容为对象
                                    .Result.Content.ReadAsStringAsync().Result;
            Console.WriteLine(data.ToString());
            Customer[] model = JsonConvert.DeserializeObject<Customer[]>(data.ToString());
            result = model;
            return model;
        }
    }

    }
