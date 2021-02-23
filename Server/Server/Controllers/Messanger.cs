using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using ConsoleMessenger;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Server.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class Messanger : ControllerBase
  {
    static List<Message> ListOfMessages = new List<Message>();
    // GET api/<Messanger>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      string OutputString = "Not found";
      if ((id < ListOfMessages.Count) && (id >= 0))
      {
        OutputString = JsonConvert.SerializeObject(ListOfMessages[id]);
      }
      Console.WriteLine(String.Format("Запрошено сообщение № {0} : {1}", id, OutputString));
      return OutputString;
    }
    // POST api/<Messanger>
    [HttpPost]
    public IActionResult SendMessage([FromBody] Message msg)
    {
      if (msg == null)
      {
        return BadRequest();
      }
      ListOfMessages.Add(msg);
      Console.WriteLine(String.Format("Всего сообщений: {0} Посланное сообщение: {1}", ListOfMessages.Count, msg));
      return new NoContentResult();
    }
  }
}
