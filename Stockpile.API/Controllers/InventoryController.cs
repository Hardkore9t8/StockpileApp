using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stockpile.API.Data;
using Stockpile.API.Dtos;

namespace Stockpile.API.Controllers
{
    [Authorize]
    [Route("api/users/{userId}/inventory")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IStockpileRepository _repo;
        private readonly IMapper _mapper;
        public InventoryController(IStockpileRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
            var items = await _repo.GetItems();
            var itemsToReturn = _mapper.Map<IEnumerable<InventoryListDto>>(items);
            return Ok(itemsToReturn);
        }

        [HttpGet("{id}", Name="GetInventory")]
        public async Task<IActionResult> GetItem(int id)
        {
            var item = await _repo.GetItem(id);
            var itemToReturn = _mapper.Map<InventoryListDto>(item);
            return Ok(itemToReturn);
        }
    }
}