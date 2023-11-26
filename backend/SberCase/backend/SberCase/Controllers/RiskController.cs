using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SberCase.Contracts;
using SberCase.Models;
using System.Net.Http;
using System.Text;

namespace SberCase.Controllers
{
    public class RiskController : BaseController<RiskController>
    {
        [HttpGet("/risk/{applicationId}")]
        public async Task<ActionResult<Risk>> GetRisk([FromRoute] int applicationId)
        {
            var risk = new Risk
            {
                HasCreditHistory = true,
                Grade = "хорошая",
                OftenMicroloans = true,
                OftenTakeCreditForCredit = true,
                AllowsDelays = true,
                HasDelay = true,
                RiskOfNonPayments = true,
                RiskOfMissingPayments = true,
                RiskOfNonPaymentsLossIncome = true,
                IncreasingTheDebtBurden = true,
                RiskLossIncome = true,
            };
            return risk;
        }

        [HttpGet("/pdn/{applicationId}")]
        public async Task<ActionResult<object>> GetPDN([FromRoute] int applicationId)
        {
            var req = new Dictionary<string, object>();
            req.Add("profile", new List<object>{
                    "Иванов Иван Иванович",
                    "05.06.1983",
                    "1234 567890",
                    "г. Москва",
                    "г. Москва",
                    "Женат",
                    "Да",
                    "ОOО «Ромашка»",
                    "10 лет и 2 мес.",
                    "Генеральный директор",
                    175615.27,
                    "2-НДФЛ",
                    150000,
                    "Нет",
                    "Доходы от оказания консалтинговых услуг",
                    "Да"
                });
            req.Add("creditHistory", "Хорошая");
            req.Add("dli", 0.87);


            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            var client = new HttpClient(httpClientHandler);
            var uri = "http://sber-alhorithm:5001";
            var resp = await client.PostAsync(uri, new StringContent(JsonConvert.SerializeObject(req), Encoding.UTF8, "application/json"));
            return new ContentResult()
            {
                Content = await resp.Content.ReadAsStringAsync(),
                ContentType = "application/json"
            };
        }
    }
}
