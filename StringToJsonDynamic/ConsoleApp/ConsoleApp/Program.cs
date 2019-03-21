using Newtonsoft.Json.Linq;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var jsonStringTest = "{\"Nonce\": \"HspZE5PuzDtr1s93\",\"Sign\": \"CCC812D82CD08F11A649427FC6EDCE64\",\"BankType\": \"RakutenPay\",\"Result\": \"SUCCESS\", \"ResultDesc\": \"支払が完了しました。レシート発行する場合は、印刷ボタンを押してください。\",\"TradeState\": \"SUCCESS\"}";
            var jsonTestObj = JObject.Parse(jsonStringTest);
            if (jsonTestObj["Result"] != null)
            {
                Console.WriteLine(jsonTestObj["Result"].ToString());
            }
            Console.ReadLine();
        }
    }
}
