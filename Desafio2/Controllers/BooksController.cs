using Desafio2.Communication.Requests;
using Desafio2.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Desafio2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(Book), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetById([FromRoute] int id)
    {
        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponsesRegisteredUserJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponsesRegisteredUserJson
        {
            Id = 1,
            Title = request.Title
        };

        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult Update(
        [FromRoute] int id,
        [FromBody] RequestUpdateBookJson request)
    {
        return Ok();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete()
    {
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(List <Book>), StatusCodes.Status200OK)]

    public IActionResult GetAll()
    {
        var response = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "Book 1",
                Author = "Author 1",
                bookGenres = "Genre 1",
                Price = 10.0f,
                Quantity = 5
            },
            new Book
            {
                Id = 2,
                Title = "Book 2",
                Author = "Author 2",
                bookGenres = "Genre 2",
                Price = 20.0f,
                Quantity = 10
            }
        };


        return Ok(response);
    }
}
