using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveHub.WebApi.Adaptor.Models
{
    #region Enumeration
    public enum DirectiveStatus { Active, Shelved, Complete }
    #endregion

    #region Model
    public class DirectiveClientModel
    {
        public Guid ID { get; set; }
        public DirectiveStatus Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime Touched { get; set; }
        public string Body { get; set; }
        public DateTime DueTime { get; set; }
        public DateTime CompletedTime { get; set; }
        public int Priority { get; set; }
    }
    #endregion
}
