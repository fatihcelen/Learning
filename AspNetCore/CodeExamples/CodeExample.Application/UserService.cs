using CodeExample.Application;
using System;

namespace CodeExamples.Application
{
    public class UserService : IUserService
    {
        public UserService()
        {
        }

        public bool CheckRequest(string v)
        {
            return true;
        }
    }
}