using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveHub.WebApi.Adaptor.Models
{
    public class DirectiveServiceResponse
    {
        #region Enumeration
        public enum ServiceMessageType { Success, Exception }
        #endregion

        #region Model
        public ServiceMessageType MessageType { get; set; }
        public string Message { get; set; }
        public object Payload { get; set; }
        #endregion
    }
}
