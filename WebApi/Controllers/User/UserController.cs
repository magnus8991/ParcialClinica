﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Base;
using Application.Http.Requests;
using Application.Http.Responses;
using Application.Services;
using Domain.Contract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly UserService _userService;

        public UserController(ILogger<UserController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _userService = new UserService(unitOfWork);
        }

        [HttpPost("Auth")]
        public ActionResult<Response<LoginUserResponse>> Login([FromBody] UserLoginRequest request)
        {
            var response = _userService.LoginUser(request);
            return StatusCode((int)response.Code, response);
        }

        [HttpPost("CreateUser")]
        public ActionResult<Response<LoginUserResponse>> CreateUser([FromBody] UserRequest request)
        {
            var response = _userService.CreateUser(request);
            return StatusCode((int)response.Code, response);
        }
    }
}