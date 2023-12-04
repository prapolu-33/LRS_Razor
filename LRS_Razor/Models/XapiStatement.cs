using System;
using LRS_Razor.Models;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LRS_Razor.Models
{
    public class XApiStatement
    {

        [Key]
        public Guid Uuid { get; set; }

        [Required]
        [JsonPropertyName("actor")]
        public XApiActor Actor { get; set; }
        
        [Required]
        [JsonPropertyName("verb")]
        public XApiVerb Verb { get; set; } 
        
        [Required]
        [JsonPropertyName("object")]
        public XApiObject Object { get; set; }

        [JsonPropertyName("result")]
        public XApiResult? Result { get; set; }

        [JsonPropertyName("context")]
        public XApiContext? Context { get; set; }
        
        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
        
        public XApiStatement()
        {
            DateTime currentTime = DateTime.Now;
            string timestamp = currentTime.ToString("yyyy-MM-ddTHH:mm:ss.fffffff");
            Timestamp = timestamp;
        }
        
        /*
        public XApiStatement()
        {
            Uuid = Guid.NewGuid();
        }
        */
    }
}


