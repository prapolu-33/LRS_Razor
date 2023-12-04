using System;
using LRS_Razor.IService;

namespace LRS_Razor.Service
{
	public class UserService : IUserService
	{

        public bool CheckUser(string Username, string password)
        {
            return Username.Equals("prapolu") && password.Equals("password");
        }
    }
}

