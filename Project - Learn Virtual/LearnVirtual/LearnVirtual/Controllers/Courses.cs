using LearnVirtual.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace LearnVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Courses : ControllerBase
    {
        private object _context;
        private DataContex dataContex;

        public Students(DataContex datacontext) => dataContex = datacontext;
        

        public int CourseId { get; private set; }
        public object CourseName { get; private set; }

        // GET: api/<Courses>
        [HttpGet]
        public List<Courses> Get() => _context.coursesList;

        // GET api/<Courses>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            Courses course = _context.coursesList.Find(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        // POST api/<Courses>
        [HttpPost]
        public void Post([FromBody] Courses course)
        {
            _context.coursesList.Add(course);
        }

        // PUT api/<Courses>/5
        [HttpPut("{id}")]
        public ActionResult<Courses> Put(int id, [FromBody] Courses updateCourse)
        {
            Courses course = _context.coursesList.Find(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }
            course.CourseName = updateCourse.CourseName;
            return Ok(course);

        }

        // DELETE api/<Courses>/5
        [HttpDelete("{id}")]
        public ActionResult<Courses> Delete(int id)
        {
            Courses course = _context.coursesList.Find(c => c.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }
            _context.coursesList.Remove(course);

            return NoContent();
        }
    }
}
