using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeExamples.Application
{
    public class CalculationService
    {
        private UserService _userService;
        public CalculationService()
        {
            _userService = new UserService();
        }

        public string GetInvoice()
        {
            if (_userService.CheckRequest(GetCurrentContext()))
            {
                return "Invoice List";
            }
            else
            {
                return string.Empty;
            }
        }

        private string GetCurrentContext()
        {
            return "{\"operation\":\"Sum\"}";
        }
    }
}
