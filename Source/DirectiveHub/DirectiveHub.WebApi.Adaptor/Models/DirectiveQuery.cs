using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectiveHub.WebApi.Adaptor.Models
{
    public class DirectiveQuery
    {
        #region Factors
        public Guid ID { get; set; }
        public List<DirectiveStatus> Statuses { get; set; }
        public DateTime? FromCreated { get; set; }
        public DateTime? ToCreated { get; set; }
        public DateTime? FromTouched { get; set; }
        public DateTime? ToTouched { get; set; }
        public string BodySearchString { get; set; }
        public DateTime? FromDueTime { get; set; }
        public DateTime? ToDueTime { get; set; }
        public DateTime? FromCompletedTime { get; set; }
        public DateTime? ToCompletedTime { get; set; }
        public List<int> Priorities { get; set; }
        #endregion
    }
}
