using System;
namespace LRS_Razor.IService
{
	public interface IUserService
	{
		bool CheckUser(string Username, string password);
	}
}

