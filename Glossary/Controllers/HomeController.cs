using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.IO; //path object

namespace Glossary.Controllers
{
    [ApiController] //HTTP 400 responses when the model is in error
                    //automatic binding of URL parameters to method parameters, and similar

    [Route("api/[controller]")] //map a URL pattern to the controller
        public class GlossaryController : Controller
        {
            private static List<GlossaryItem> Glossary = new List<GlossaryItem> {
            new GlossaryItem
            {
                Term= "Access Token",
                Definition = "A credential that can be used by an application to access an API. It informs the API that the bearer of the token has been authorized to access the API and perform specific actions specified by the scope that has been granted."
            },
            new GlossaryItem
            {
                Term= "JWT",
                Definition = "An open, industry standard RFC 7519 method for representing claims securely between two parties. "
            },
            new GlossaryItem
            {
                Term= "OpenID",
                Definition = "An open standard for authentication that allows applications to verify users are who they say they are without needing to collect, store, and therefore become liable for a user’s login information."
            }
            };
            [HttpGet]
            public ActionResult<List<GlossaryItem>> Get()
            {
                return Ok(Glossary);
            }

            [HttpGet] //retrieve single glossary item
            [Route("{term}")] //appends new variable to URL since we overloaded the Get method
            public ActionResult<GlossaryItem> Get(string term)
            {
                var glossaryItem = Glossary.Find(item =>
                        item.Term.Equals(term, StringComparison.InvariantCultureIgnoreCase));

                if (glossaryItem == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(glossaryItem);
                }
            }

            [HttpPost]
            public ActionResult Post(GlossaryItem glossaryItem)
            {
            var existingGlossaryItem = Glossary.Find(item =>
                    item.Term.Equals(glossaryItem.Term, StringComparison.InvariantCultureIgnoreCase));

            if (existingGlossaryItem != null)
            {
                return Conflict("Cannot create the term because it already exists.");
            }
            else
            {
                Glossary.Add(glossaryItem);
                var resourceUrl = Path.Combine(Request.Path.ToString(), Uri.EscapeUriString(glossaryItem.Term));
                return Created(resourceUrl, glossaryItem);
            }
            }
        [HttpPut]
        public ActionResult Put(GlossaryItem glossaryItem)
        {
            var existingGlossaryItem = Glossary.Find(item =>
            item.Term.Equals(glossaryItem.Term, StringComparison.InvariantCultureIgnoreCase));

            if (existingGlossaryItem == null)
            {
                return NotFound("Cannot update a nont existing term.");
            }
            else
            {
                existingGlossaryItem.Definition = glossaryItem.Definition;
                return Ok();
            }
        }

        [HttpDelete]
        [Route("{term}")]
        public ActionResult Delete(string term)
        {
            var glossaryItem = Glossary.Find(item =>
                   item.Term.Equals(term, StringComparison.InvariantCultureIgnoreCase));

            if (glossaryItem == null)
            {
                return NotFound();
            }
            else
            {
                Glossary.Remove(glossaryItem);
                return NoContent();
            }
        }

    }
    
}
   