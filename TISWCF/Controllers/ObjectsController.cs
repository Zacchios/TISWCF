using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using RESTHosting.Models;

namespace RESTHosting.Controllers
{
    [RoutePrefix("api/Objects")]
    public class ObjectsController : ApiController
    {
        private LiegeContext db = new LiegeContext();

        // GET: api/Objects
        public IQueryable<Objects> GetObjects()
        {
            return db.Objects.Include(b => b.Classification);
        }

        // GET: api/Objects/5
        [ResponseType(typeof(Objects))]
        public async Task<IHttpActionResult> GetObjects(int id)
        {
            Objects objects = await db.Objects.Include(b => b.Classification).SingleOrDefaultAsync(b => b.ObjectID == id);
            if (objects == null)
            {
                return NotFound();
            }
            Objects obj = new Objects(objects.ObjectID, objects.ObjectNumber);
            return Ok(obj);
        }

        

        // GET: api/Objects/5
        [ResponseType(typeof(Objects))]
        public async Task<IHttpActionResult> GetObjects(string objnumber)
        {
            Objects objects = await db.Objects.Include(b => b.Classification).SingleOrDefaultAsync(b => b.SearchObjectNumber == objnumber);
            if (objects == null)
            {
                return NotFound();
            }

            return Ok(objects);
        }

        // GET: api/Objects/5
        [Route("searchobjectnumber")]
        [HttpGet]
        [ResponseType(typeof(List<Objects>))]
        public async Task<IHttpActionResult> GetListObjects(string objnumber)
        {
            Objects objects = await db.Objects.Include(b => b.Classification).SingleOrDefaultAsync(b => b.SearchObjectNumber == objnumber);
            List<Object> obj = new List<Object>();
            while (objects != null)
            {

                obj.Add(obj);

            }
            if (objects == null)
            {
                return NotFound();
            }

            return Ok(objects);
        }

        // PUT: api/Objects/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutObjects(int id, Objects objects)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != objects.ObjectID)
            {
                return BadRequest();
            }

            db.Entry(objects).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjectsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Objects
        [ResponseType(typeof(Objects))]
        public async Task<IHttpActionResult> PostObjects(Objects objects)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Objects.Add(objects);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = objects.ObjectID }, objects);
        }

        // DELETE: api/Objects/5
        [ResponseType(typeof(Objects))]
        public async Task<IHttpActionResult> DeleteObjects(int id)
        {
            Objects objects = await db.Objects.FindAsync(id);
            if (objects == null)
            {
                return NotFound();
            }

            db.Objects.Remove(objects);
            await db.SaveChangesAsync();

            return Ok(objects);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ObjectsExists(int id)
        {
            return db.Objects.Count(e => e.ObjectID == id) > 0;
        }
    }
}