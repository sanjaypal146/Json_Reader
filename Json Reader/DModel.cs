using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Json_Reader
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class FileDetails
    {
        public string FileName { get; set; }
        public string filePath { get; set; }
        public string fileNamePath { get; set; }
        public string filestream { get; set; }
    }
    public class Result
    {
        public List<string> ApiProvider { get; set; }
        public List<string> BookingReference { get; set; }
        public List<string> ClassName { get; set; }
        public List<string> ErrorCode { get; set; }
        public string Hosts_Region { get; set; }
        public string Index_Description { get; set; }

        [JsonProperty("LogData{}")]
        public List<string> LogData { get; set; }
        public List<string> LogDescription { get; set; }
        public List<string> LogType { get; set; }
        public List<string> MethodName { get; set; }
        public List<string> ModuleName { get; set; }
        public string Team_Dataowner { get; set; }
        public List<string> Timestamp { get; set; }
        public List<string> TraceID { get; set; }
        public List<string> Username { get; set; }
        public string _raw { get; set; }
        public DateTime? _time { get; set; }
        public string date_hour { get; set; }
        public string date_mday { get; set; }
        public string date_minute { get; set; }
        public string date_month { get; set; }
        public string date_second { get; set; }
        public string date_wday { get; set; }
        public string date_year { get; set; }
        public string date_zone { get; set; }
        public string host { get; set; }
        public string index { get; set; }
        public string linecount { get; set; }
        public string source { get; set; }
        public string sourcetype { get; set; }
        public string splunk_server { get; set; }
        public string timeendpos { get; set; }
        public string timestartpos { get; set; }
    }

    public class Root
    {
        public bool? preview { get; set; }
        public Result result { get; set; }
    }
    //public class RootList
    //{
    //    public List<Root> rootList { get; set; }
    //}


}
