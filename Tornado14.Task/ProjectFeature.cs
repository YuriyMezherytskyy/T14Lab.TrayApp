using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tornado14.Task
{
    public class ProjectFeature
    {
        public Guid pId { get; set; }
        public string Id { get; set; }

        public string ShortDescription { get; set; }
        public string Description { get; set; }

        public string FilesFolder { get; set; }
    }
}
