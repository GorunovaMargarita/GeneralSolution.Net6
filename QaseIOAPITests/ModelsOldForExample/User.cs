using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaseIOAPITests.Models
{
    public class User
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Id { get; set; }
        public string? Email { get; set; }

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }
        public string? Avatar { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Email == user.Email &&
                   FirstName == user.FirstName &&
                   LastName == user.LastName &&
                   Avatar == user.Avatar;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Email, FirstName, LastName, Avatar);
        }

        public override string ToString()
        {
            return $"{FirstName}, {LastName}, {Email}, {Avatar}";
        }
    }
}
