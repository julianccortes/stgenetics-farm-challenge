using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STgenetics.Farm.Application.Dtos.Common.Errors
{
    public class ErrorResponse
    {
        public ErrorResponse()
        {
            Message = string.Empty;
            Errors = new Dictionary<string, string[]>();
        }
        public ErrorResponse(string message)
        {
            Message = message;
            Errors = new Dictionary<string, string[]>();
        }
        public ErrorResponse(string message, IDictionary<string, string[]> errors)
        {
            Message = message;
            Errors = errors;
        }

        public string? Message { get; set; }
        public IDictionary<string, string[]>? Errors { get; set; }
    }
}
