using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LRS_Razor.Models;
using System.Text.Json.Serialization;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using LRS_Razor.Data;
using LRS_Razor.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace LRS_Razor.Controllers
{
    [Authorize]
    [ApiVersion("1.0")]
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class xapiController : ControllerBase
    {

        XApiStatement _statement = new XApiStatement();

        public static ApplicationDbContext getContext()
        {
            string connectionString = ConfigurationHelper.DefaultConnection;
            var options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer(connectionString);
            ApplicationDbContext context = new ApplicationDbContext(options.Options);
            return context;
        }





        [HttpPost("statements")]
        public IActionResult ReceiveXAPIStatement([FromBody] XApiStatement statement)
        {
            try
            {
                // Process and store the XAPI statement in your LRS
                // Replace this with your LRS code
                //string Jsonstring = JsonSerializer.Serialize(statement);
                var uuidProperty = statement.GetType().GetProperty("Uuid");
                if (uuidProperty != null)
                {
                    // Property "Uuid" exists
                    Guid? uuidValue = (Guid?)uuidProperty.GetValue(statement);
                    if (uuidValue == null)
                    {
                        statement.Uuid = Guid.NewGuid();
                    }
                    }
                    using (var _db = getContext())
                    {

                        _db.Add(statement);
                        _db.SaveChanges();

                    };



                // Respond with a success message
                //XApiStatement? statement1 = JsonSerializer.Deserialize<XApiStatement>(Jsonstring);
                Console.WriteLine( statement.Actor.Mbox);
                //Console.WriteLine(statement.Verb);
                //Console.WriteLine(statement.Object);
                Console.WriteLine(statement);
                return Ok("Successful");
                //return Ok(new { success = true, message = "XAPI statement received and processed successfully" });
            }
            catch (Exception ex)
            {
                // Handle any errors or exceptions
                return BadRequest(new { success = false, message = "Error processing XAPI statement", error = ex.Message });
            }
        }

        [HttpGet()]
        public IActionResult get() {

            return Ok(_statement);
        }
    }
}
 