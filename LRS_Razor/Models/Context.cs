using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace LRS_Razor.Models
{
    public class XApiContext
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("contextActivities")]
        public XApiContextActivities? ContextActivities { get; set; }

        [JsonPropertyName("revision")]
        public string? Revision { get; set; }

        [JsonPropertyName("platform")]
        public string? Platform { get; set; }

        [JsonPropertyName("language")]
        public string? Language { get; set; }

        public Guid? Uuid { get; set; }
        [ForeignKey("Uuid")]
        public XApiStatement? XApiStatement { get; set; }
    }

    public class XApiContextActivities
    {
        [Key]
        public int Id { get; set; }

        [JsonProperty("category")]
        public List<XApiObject>? Category { get; set; }

        public int ContextId { get; set; }
        [ForeignKey("ContextId")]
        public XApiContext? xApiContext { get; set; } 
    }
}


