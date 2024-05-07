using CodeBeat.Web.Models;

namespace CodeBeat.Web.Service.IService
{
    public interface IBaseService
    {

        Task<ResponseDto> SendAsync(RequestDto responseDto);
    }
}
