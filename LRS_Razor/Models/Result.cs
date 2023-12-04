using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LRS_Razor.Models
{
    public class XApiResult
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("score")]
        public XApiScore? Score { get; set; }

        [JsonPropertyName("success")]
        public bool? Success { get; set; }

        [JsonPropertyName("completion")]
        public bool? Completion { get; set; }

        [JsonPropertyName("response")]
        public string? Response { get; set; }

        [JsonPropertyName("duration")]
        public string? Duration { get; set; }


        public Guid? Uuid { get; set; }
        [ForeignKey("Uuid")]
        public XApiStatement? XApiStatement { get; set; }
    }
    public class XApiScore
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("scaled")]
        public double? Scaled { get; set; }

        [JsonPropertyName("raw")]
        public double? raw { get; set; }

        [JsonPropertyName("min")]
        public double? min { get; set; }

        [JsonPropertyName("max")]
        public double? max { get; set; }

        public int? ResultId { get; set; }
        [ForeignKey("ResultId")]
        public XApiResult? XApiResult { get; set; }
    }
}

