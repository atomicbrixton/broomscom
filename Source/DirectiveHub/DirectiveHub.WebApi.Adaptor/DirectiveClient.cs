using DirectiveHub.WebApi.Adaptor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveHub.WebApi.Adaptor
{
    public class DirectiveClient
    {
        #region Model
        public Guid ID { get; set; }
        public DirectiveStatus Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Touched { get; set; }
        public string Body { get; set; }
        public DateTime Due { get; set; }
        public int Priority { get; set; }
        #endregion
    }
}
