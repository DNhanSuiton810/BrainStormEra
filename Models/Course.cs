using System.Runtime.CompilerServices;

namespace BrainStormEra.Models
{
    public class Course
    {
        public string course_id { get; set; }
        public string course_name { get; set; }
        public string course_description { get; set; }
        public string course_price { get; set; }
        public int course_status { get; set; }
        public string course_picture { get; set; }
        public Course() { }

        public Course(
            string course_id,
            string course_name,
            string course_description,
            string course_price,
            int course_status,
            string course_picture
        )
        {
            this.course_id = course_id;
            this.course_name = course_name;
            this.course_description = course_description;
            this.course_price = course_price;
            this.course_status = course_status;
            this.course_picture = course_picture;
        }
    }
}
