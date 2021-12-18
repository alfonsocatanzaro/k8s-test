using System;
namespace frontend.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
        }

        public string HostIpAddress { get; set; }
        public string HostName { get; set; }
        public string PageCreatedAt { get; set; }
    }
}
