using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyDiary.Contacts.Application.Feature.Create;
using MyDiary.Contacts.Application.Feature.Get;

namespace MyDiary.Contacts.Api.Controllers
{
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(CreateContactResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateContactRequest request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(Get), new { response.ContactId }, response);
        }

        [HttpGet("{ContactId}")]
        [ProducesResponseType(typeof(GetContactResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get([FromRoute] GetContactRequest request)
        {
            var model = await _mediator.Send(request);
            if (model == null) return NotFound();

            return Ok(model);
        }
    }
}
