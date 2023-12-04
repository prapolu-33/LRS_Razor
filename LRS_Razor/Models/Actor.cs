using System;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LRS_Razor.Models
{
    public class XApiActor
    {
        [Key]
        public int ActorId { get; set; }

        [JsonPropertyName("objectType")]
        public string? ObjectType { get; set; }  // e.g., "Agent" or "Group"
        [JsonPropertyName("name")]
        public string? Name { get; set; }         // The name or identifier of the actor

        // If ObjectType is "Agent"
        [JsonPropertyName("mbox")]
        public string? Mbox { get; set; }     // Email address // IFI

        [JsonPropertyName("openid")]
        public string? openid { get; set; }       // An openID that uniquely identifies the Agent.  // IFI

        [JsonPropertyName("account")]
        public account? account { get; set; }     //  A user account on an existing system e.g.an LMS or intranet.  // IFI


        [JsonPropertyName("mbox_sha1sum")]
        public string? MboxSha1Sum { get; set; }  // SHA-1 hash of the email address  // IFI
        [JsonPropertyName("AccountName")]
        public string? AccountName { get; set; }  // An account name or username
        [JsonPropertyName("homePage")]
        public string? AccountHomePage { get; set; }  // The homepage or platform of the account

        // If ObjectType is "Group"
        [JsonPropertyName("member")]
        public string? Member { get; set; }

        //public int StatementId { get; set; }
        public Guid? Uuid { get; set; }
        [ForeignKey("Uuid")]
        public XApiStatement? xApiStatement { get; set; } 

        public XApiActor()
        {
            if (Member != null) { ObjectType = "Group"; }
            else { ObjectType = "Agent"; }

            

            if (Mbox != null) {
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] hashBytes = sha1.ComputeHash(Encoding.UTF8.GetBytes(Mbox));
                    string hash = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                    MboxSha1Sum = hash;
                }

            }

        }
    }

    public class account {

        [Key]
        public int Id { get; set; }

        [JsonPropertyName("homePage")]
        public string homePage { get; set; }   //The canonical home page for the system the account is on. 

        [JsonPropertyName("name")]
        public string name { get; set; }       //The unique id or name used to log in to this account.

        public int? ActorId { get; set; }
        [ForeignKey("ActorId")]
        public XApiActor? xApiActor { get; set; }    // The foreign key of parent class 'XApiActor'


    }
}
