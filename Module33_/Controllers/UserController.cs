using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using AutoMapper;

namespace Module33_.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IMapper _mapper;
        private ILogger _logger;

        public UserController(ILogger logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;

            logger.WriteEvent("Сообщение о событии в программе!");
            logger.WriteError("Сообщение об ошибке в программе!");
        }

        [HttpGet]
        public User GetUser()
        {
            return new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "sd@gmail.com",
                Password = "123",
                Login = "ivan222"
            };
        }

        [HttpGet]
        [Route("viewmodel")]
        public UserViewModel GetUserViewModel()
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "11111122222qq",
                Login = "ivanov"
            };

             
            UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);

            return userViewModel;
        }
    }
}
