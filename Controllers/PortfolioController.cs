// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Portfolio1.Controllers;   
public class PortfolioController : Controller   // Remember inheritance?    
{      
    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public string Index()        
    {            
    	return "This is my Index!";        
    }    


    [HttpGet]
    [Route("/projects")]

    public string Projects(){
        return "These are my projects";
    }


    [HttpGet]
    [Route("/contact")]

    public string Contact(){
        return "This is my contact!";
    }
}

