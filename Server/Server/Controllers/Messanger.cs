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
    static List<Message>  ListOfMessages = new List<Message>();
    // GET api/<Messanger>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      string output = "Not found";
      if ((id < ListOfMessages.Count) && (id >= 0))
      {
        output = JsonConvert.SerializeObject(ListOfMessages[id]);
      }
      return output;
    }
    // POST api/<Messanger>
    [HttpPost]
    public void Area(Message value)
    {
      ListOfMessages.Add(value);
      Console.WriteLine(ListOfMessages.Count);
    }
  }
}
