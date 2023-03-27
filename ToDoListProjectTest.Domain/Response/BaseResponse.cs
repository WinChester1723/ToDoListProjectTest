using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListProjectTest.Domain.Enum;

namespace ToDoListProjectTest.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public StatusCode StatusCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public T Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }

    public interface IBaseResponse<T>
    {
        string Description { get; set; }

        StatusCode StatusCode { get; set; }

        T Data { get; set; }
    }
}
