using Microsoft.AspNetCore.Mvc;
using PhoneBook.Data.Dtos;
using PhoneBook.Models.ViewModel;
using PhoneBook.Repositories;

namespace PhoneBook.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PhoneBookController : ControllerBase
    {
        private readonly IPhoneBookRepository _repository;

        public PhoneBookController(IPhoneBookRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] PhoneListViewModel resquest)
        {
            var dto = new PhoneBookDto
            {
                Name = resquest.Name,
                Phone = resquest.Phone,
                State = resquest.State,
            };
            var result = await _repository.Add(dto);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ICollection<PhoneBookDto>> Get()
        {
            return await _repository.GetAll();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _repository.Delete(id);
            if(!result) return NotFound();

            return Ok(result);
        }
    }
}
