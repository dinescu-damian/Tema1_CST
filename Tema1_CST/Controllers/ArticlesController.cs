using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tema1_CST.Core.Services;
using Tema1_CST.DataLayer.Dtos;
using Tema1_CST.DataLayer.Entities;

namespace Tema1_CST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        IArticleCollectionService _articleCollectionService;
        public ArticlesController(IArticleCollectionService articleCollectionService)
        {
            _articleCollectionService = articleCollectionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var articles = await _articleCollectionService.GetAll();
            return Ok(articles);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var article = await _articleCollectionService.Get(id);
            if (article == null)
            {
                return NotFound();
            }
            return Ok(article);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ArticleDto article)
        {
            if (article == null)
            {
                return BadRequest();
            }
            var created = await _articleCollectionService.Create(article);
            if (!created)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] ArticleDto article)
        {
            if (article == null)
            {
                return BadRequest();
            }
            var updated = await _articleCollectionService.Update(id, article);
            if (!updated)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var deleted = await _articleCollectionService.Delete(id);
            if (!deleted)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }
    }
}
