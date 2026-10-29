using Application.DTO.Room;
using Application.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace raven.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class RoomController :ControllerBase
    {
        private readonly IRoomService _roomService;
        public  RoomController(IRoomService roomService) {
            _roomService=roomService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomController(Guid id) { 
        var Roomdto =  await _roomService.GetRoomByid(id);
            return Ok(Roomdto);
        
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRoomsController() {
       var AllRoomsdto = await _roomService.GetALLRooms();
            return Ok(AllRoomsdto);
        }

        [HttpPost]

        public async Task<IActionResult> AddRoomController([FromBody] CreateRoomDto createroomdto) { 
            
          var RoomResponseDto= await  _roomService.AddRoom(createroomdto);

            return CreatedAtAction(nameof(GetRoomController), new { id = RoomResponseDto.Id }, RoomResponseDto);

        }






    }
}
