using Microsoft.AspNetCore.Mvc;
using HelloApi.Models;

namespace HelloApi.Controllers;

[Route("/user")]
[ApiController]
public class UserController : Controller
{

    [HttpGet("test")]
    public string testController()
    {
        return "Http is okay";
    }

   
    //TODO: Save User to the the database
    [HttpPost("/save")]
    public void saveUser(User user)
    {
        
    }
    
    
    //TODO: Get User from the Database, Currentlly Using a Dummy value
    [HttpGet("/get")]
    public User getUser(int userId)
    {
        User user = new User();
        return user;
    }
    
    
    //TODO: Update user
    [HttpPost("/update")]
    public void updateUser(User user)
    {
        
    }
}