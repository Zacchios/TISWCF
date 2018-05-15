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
    public class ClassificationsController : ApiController
    {
        private LiegeContext db = new LiegeContext();

        // GET: api/Classifications
        public IQueryable<Classification> GetClassifications()
        {
            return db.Classifications;
        }

        // GET: api/Classifications/5
        [ResponseType(typeof(Classification))]
        public async Task<IHttpActionResult> GetClassification(int id)
        {
            Classification classification = await db.Classifications.FindAsync(id);
            if (classification == null)
            {
                return NotFound();
            }

            return Ok(classification);
        }

        // PUT: api/Classifications/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutClassification(int id, Classification classification)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != classification.ClassificationID)
            {
                return BadRequest();
            }

            db.Entry(classification).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClassificationExists(id))
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

        // POST: api/Classifications
        [ResponseType(typeof(Classification))]
        public async Task<IHttpActionResult> PostClassification(Classification classification)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Classifications.Add(classification);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = classification.ClassificationID }, classification);
        }

        // DELETE: api/Classifications/5
        [ResponseType(typeof(Classification))]
        public async Task<IHttpActionResult> DeleteClassification(int id)
        {
            Classification classification = await db.Classifications.FindAsync(id);
            if (classification == null)
            {
                return NotFound();
            }

            db.Classifications.Remove(classification);
            await db.SaveChangesAsync();

            return Ok(classification);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClassificationExists(int id)
        {
            return db.Classifications.Count(e => e.ClassificationID == id) > 0;
        }
    }
}