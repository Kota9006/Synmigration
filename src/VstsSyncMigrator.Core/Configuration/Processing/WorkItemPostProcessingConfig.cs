using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsSyncMigrator.Engine.Configuration.Processing
{
    public class WorkItemPostProcessingConfig : ITfsProcessingConfig
    {
        public bool Enabled { get; set; }
        public string QueryBit { get; set; }
        public IList<int> WorkItemIDs { get; set; }
        public Type Processor
        {
            get
            {
                return typeof(WorkItemPostProcessingContext);
            }
        }

    }
    }