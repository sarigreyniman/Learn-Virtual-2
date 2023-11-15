using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LearnVirtual.Controllers;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearnVirtual.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningMatirials : ControllerBase
    {
        private object _context;

        public int LearningMatirialsForCourseId { get; private set; }
        public object LearningMatirialsDescription { get; private set; }


        



        // GET: api/<LearningMatirials>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<LearningMatirials>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            LearningMatirials learningMatirials = _context.learningMatirialsList.Find(lm => lm.LearningMatirialsForCourseId == id);
            if (learningMatirials == null)
            {
                return NotFound();
            }
            return Ok(learningMatirials);
        }

        // POST api/<LearningMatirials>
        [HttpPost]
        public void Post([FromBody] LearningMatirials learningMatirials)
        {
            _context.learningMatirialsList.Add(learningMatirials);
        }

        // PUT api/<LearningMatirials>/5
        [HttpPut("{id}")]
        public ActionResult<LearningMatirials> Put(int id, [FromBody] LearningMatirials learningMatirialsUpdate)
        {
            LearningMatirials learningMatirials = _context.learningMatirialsList.Find(lm => lm.LearningMatirialsForCourseId == id);
            if (learningMatirials == null)
            {
                return NotFound();
            }
            learningMatirials.LearningMatirialsDescription = learningMatirialsUpdate.LearningMatirialsDescription;
            return Ok(learningMatirials);
        }

        // DELETE api/<LearningMatirials>/5
        [HttpDelete("{id}")]
        public ActionResult<LearningMatirials> Delete(int id)
        {
            LearningMatirials learningMatirials = _context.learningMatirialsList.Find(lm => lm.LearningMatirialsForCourseId == id);
            if (learningMatirials == null)
            {
                return NotFound();
            }
            _context.learningMatirialsList.Remove(learningMatirials);
            return NoContent();
        }
    }
}
