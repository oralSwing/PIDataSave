using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PIDataSave.Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace PIDataSave
{
    class Program
    {
        public  static PIServer.WebService1SoapClient WebService = new PIServer.WebService1SoapClient();
        static void Main(string[] args)
        {

            PIPoint pIPoint = new PIPoint();
            PropertyInfo[] propertys = pIPoint.GetType().GetProperties();
           string jsonFile = "D:/vs2019proj/PIData/PIDataSave/PIDataSave/tagName.json";
           using (System.IO.StreamReader file = System.IO.File.OpenText(jsonFile))
           {
               using (JsonTextReader reader = new JsonTextReader(file))
               {
                   JArray jArray = (JArray)JToken.ReadFrom(reader);

                   foreach (JObject o in jArray)
                   {
                       IEnumerable<JProperty> properties = o.Properties();
                       foreach (JProperty item in properties)
                       {
                           string key = item.Name;
                            JToken val = item.Value;
                            JObject obj=JObject.Parse(val.ToString());
                            foreach (PropertyInfo property in propertys)
                            {
                                if (property.Name != "id" && property.Name != "time"&&obj.ContainsKey(property.Name) )
                                {
                                    string a= obj[property.Name].ToString();
                                    string value = WebService.PIRead(
                                            $"select value from piarchive..piavg where tag = '{a}'  and  time BETWEEN '*-1h' AND '*'",
                                            key);
                                        JArray arr = (JArray) JsonConvert.DeserializeObject(value);

                                        foreach (JObject jo in arr)
                                        {
                                            string joValue = jo.Value<string>("value");
                                            property.SetValue(pIPoint, double.Parse(joValue), null);

                                        } 


                                    
                                }


                            }
                            

                        }

                 

                   }

          
               
               
           
               }
           }
           pIPoint.time= DateTime.Now.ToLocalTime().ToString();
           
            //Program.WebService.PIRead("", "");


            string dbPath = "Data Source =" + Environment.CurrentDirectory + "/test.db";

            //conn.Close();
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.SQLite);
            using (IDbConnection db = new SQLiteConnection(dbPath))
            {
                db.Open();
                IDbTransaction tran = db.BeginTransaction();
         
                db.Insert(pIPoint, transaction: tran);
                tran.Commit();

                 
            }

            
        }
    }
}
