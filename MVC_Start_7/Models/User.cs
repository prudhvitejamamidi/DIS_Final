using System;
namespace MVC_Start_7.Models
{
    public class GuestContact
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class ChartModel
    {
        public string ChartType { get; set; }
        public string Labels { get; set; }
        public string Data { get; set; }
        public string Title { get; set; }
    }
}