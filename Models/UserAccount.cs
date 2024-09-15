using System.ComponentModel.DataAnnotations;

namespace BrainStormEra.Models
{
    public class UserAccount
    {
        [Key]
        public string user_id { get; set; }
        public string user_role { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string user_email { get; set; }
        public string full_name { get; set; }
        public DateTime date_of_birth { get; set; }
        public string gender { get; set; }
        public string phone_number { get; set; }
        public string user_address { get; set; }
        public string? user_picture { get; set; }

        public UserAccount() { }

        public UserAccount(string user_id, string user_role, string username, string password, string user_email, string full_name, DateTime date_of_birth, string gender, string phone_number, string user_address, string user_picture)
        {
            this.user_id = user_id;
            this.user_role = user_role;
            this.username = username;
            this.password = password;
            this.user_email = user_email;
            this.full_name = full_name;
            this.date_of_birth = date_of_birth;
            this.gender = gender;
            this.phone_number = phone_number;
            this.user_address = user_address;
            this.user_picture = user_picture;
        }
    }
}
