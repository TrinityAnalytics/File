using Microsoft.AspNetCore.Http;
using System;

namespace File.Models
{
    public class ChildViewModel
    {
        public string Description { get; set; }

        public IFormFile File { get; set; }
    }
}