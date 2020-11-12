using System.Collections.Generic;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        private readonly IMakesRepository _repo;
        private readonly IMapper _mapper;

        public MakesController(IMakesRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<MakeDto>> GetMakes()
        {
            var makes = await _repo.GetMakesAsync();
            return _mapper.Map<IReadOnlyList<Make>, IReadOnlyList<MakeDto>>(makes);
        }
    }
}