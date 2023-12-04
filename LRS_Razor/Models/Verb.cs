using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LRS_Razor.Models
{

    public class XApiVerb
    {
        [Key]
        public int VerbId { get; set; }

        [JsonPropertyName("id")]
        public string VerbIRI { get; set; }

        [JsonPropertyName("display")]
        public XApiVerbDisplay? Display { get; set; }

        public Guid? Uuid { get; set; }
        [ForeignKey("Uuid")]
        public XApiStatement? XApiStatement { get; set; }

    }

    
    public class XApiVerbDisplay
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("en-US")]
        public string? inEnglish { get; set; }

        [JsonPropertyName("es")]
        public string? inSpanish { get; set; }

        public int? VerbId { get; set; }
        [ForeignKey("VerbId")]
        public XApiVerb? XApiVerb { get; set; }
    }
    
}

