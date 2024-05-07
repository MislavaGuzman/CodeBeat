using static CodeBeat.Web.Utitlity.SD;

namespace CodeBeat.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;

        public string Url { get; set; } 

        public object Data { get; set; }

        public string AccesToken { get; set; }
    }
}
