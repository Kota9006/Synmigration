using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsSyncMigrator.Engine.Configuration.Processing
{
    public class TeamMigrationConfig : ITfsProcessingConfig
    {
        public bool Enabled { get; set; }
        public Type Processor
        {
            get
            {
                return typeof(TeamMigrationContext);
            }
        }

    }
    }

