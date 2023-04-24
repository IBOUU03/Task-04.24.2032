using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeViewModel
    {

        public List<Service> Services { get; set; }

        public List<TeamMember> TeamMembers { get; set; }
    }
}
