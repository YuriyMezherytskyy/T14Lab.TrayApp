using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Tornado14.Task
{
    [Serializable]
    public class Project 
    {
        public Guid pId { get; set; }
        public string Id { get; set; }


        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string FilesFolder { get; set; }

        public string SVNRepository { get; set; }

        public string VisualStudioSolution { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}",Id, ShortDescription);
        }

        public ProjectType Type { get; set; }
        public List<ProjectFeature> FeatureList { get; set; }
    }
}
