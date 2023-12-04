using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace LRS_Razor.Models
{
    public class XApiObject
    {
        [Key]
        public int ObjectId { get; set; }     

        [JsonPropertyName("id")]
        public string ObjectIRI { get; set; }

        [JsonPropertyName("objectType")]
        public string? ObjectType { get; set; }  //The default value is 'activity' and other allowed values are 'Agent', 'Group', 'SubStatement' or 'StatementRef'.

        [JsonPropertyName("definition")]
        public XAPIDefinition? Definition { get; set; }

        public Guid? Uuid { get; set; }
        [ForeignKey("Uuid")]
        public XApiStatement? XApiStatement { get; set; }


        public XApiObject()
        {
            ObjectType = "Activity";
        }
    }

    public class XAPIDefinition
    {
        [Key]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public Name? name { get; set; }

        [JsonPropertyName("type")]
        public string? type { get; set; }

        [JsonPropertyName("moreInfo")]
        public string? moreInfo { get; set; }

        [JsonPropertyName("description")]
        public Description? Description { get; set; }

        public int? ObjectId { get; set;}
        [ForeignKey("ObjectId")]
        public XApiObject? XApiObject { get; set; }
    }

    public class Name {

        [Key]
        public int Id { get; set; }

        [JsonPropertyName("en-us")]
        public string? inEnglish { get; set; }

        [JsonPropertyName("es")]
        public string? inSpanish { get; set; }

        public int? DefinitionId { get; set; }
        [ForeignKey("DefinitionId")]
        public XAPIDefinition? xAPIDefinition { get; set; }
    }

    public class Description {

        [Key]
        public int Id { get; set; }

        [JsonPropertyName("en-us")]
        public string? inEnglish { get; set; }

        [JsonPropertyName("es")]
        public string? inSpanish { get; set; }

        public int? DefinitionId { get; set; }
        [ForeignKey("DefinitionId")]
        public XAPIDefinition? xAPIDefinition { get; set; }
    }
}

