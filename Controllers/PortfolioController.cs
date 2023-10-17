// This brings all the MVC features we need to this file
using Microsoft.AspNetCore.Mvc;
// Be sure to use your own project's namespace here! 
namespace Portfolio1.Controllers;   
public class PortfolioController : Controller   // Remember inheritance?    
{      
   

    [HttpGet] // We will go over this in more detail on the next page    
    [Route("")] // We will go over this in more detail on the next page
    public ViewResult Index()        
    {            
    	return View("Index");        
    } 
    
    [HttpGet]
    [Route("/proyectos")]

    public ViewResult Proyectos(){
        return View("Proyectos");
    }


    [HttpGet]
    [Route("/contacto")]

    public ViewResult Contacto(){
       return View("Contacto");
    }
}

