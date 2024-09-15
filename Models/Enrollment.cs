using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrainStormEra.Models
{
    public class Enrollment
    {
        [Key]
        public string enrollment_id { get; set; }
        [ForeignKey("UserAccount")]
        public string user_id { get; set; }
        [ForeignKey("Course")]
        public string course_id { get; set; }
        public DateTime enrollment_date { get; set; }

        public int enrollment_status { get; set; }
        public Enrollment() { }
        public Enrollment(string enrollment_id, string user_id, string course_id, DateTime enrollment_date, int enrollment_status)
        {
            this.enrollment_id = enrollment_id;
            this.user_id = user_id;
            this.course_id = course_id;
            this.enrollment_date = enrollment_date;
            this.enrollment_status = enrollment_status;
        }
    }
}
