using System.ComponentModel.DataAnnotations.Schema;

namespace BrainStormEra.Models
{
    public class CourseCategoryMapping
    {
        [ForeignKey("Course")]
        public string course_id { get; set; }
        [ForeignKey("CourseCategory")]
        public string course_category_id { get; set; }
        public CourseCategoryMapping() { }
        public CourseCategoryMapping(string course_id, string course_category_id)
        {
            this.course_id = course_id;
            this.course_category_id = course_category_id;
        }
    }
}
