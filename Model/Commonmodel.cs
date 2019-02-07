using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace poc.Model
{
    public class inputtoJiRA
    {
        public string applicationName { get; set; }
        public string jirakey { get; set; }
        public string Projassignee { get; set; }

    }

    public class outputfromJIRA
    {
        public string message { get; set; }
    }


    public class RequestModel
    {

        public outputfromJIRA ApiCall(inputtoJiRA input)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {

                    string url = "http://10.26.34.104:8000/jira/project";
                    // URL like http://IP-Address/jira/project

                    HttpResponseMessage objresponse = client.PostAsJsonAsync<inputtoJiRA>(url, input).Result;
                    outputfromJIRA Output = new outputfromJIRA();
                    HttpContent content = objresponse.Content;
                    string message1 = string.Empty;
                    Task<string> responseJIRA = content.ReadAsStringAsync();
                    if (objresponse.IsSuccessStatusCode)
                    {
                        if (((int)objresponse.StatusCode) < 202)
                        {
                            Output.message = Convert.ToString("Success from api with Status Code " + (int)objresponse.StatusCode);
                        }
                    }
                    else
                    {
                        Output.message = Convert.ToString("Error from jira with Status Code " + (int)objresponse.StatusCode);
                    }
                    return Output;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

