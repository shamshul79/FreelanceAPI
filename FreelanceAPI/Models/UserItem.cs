using System.Numerics;

namespace FreelanceAPI.Models
{
    public class UserItem
    {
        public long Id { get; set; }

        public string? UserName { get; set; }

        public string? eMail { get; set; }

        public string? Phone {  get; set; }

        public string? skillSets { get; set; }

        public string? Hobby { get; set; }
    }
}
