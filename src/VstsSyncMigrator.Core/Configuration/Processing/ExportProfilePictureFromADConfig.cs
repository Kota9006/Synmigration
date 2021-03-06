using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VstsSyncMigrator.Engine.Configuration.Processing
{
    public class ExportProfilePictureFromADConfig : ITfsProcessingConfig
    {
        public bool Enabled { get; set; }

        public string Domain { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PictureEmpIDFormat { get; set; }

        public Type Processor
        {
            get
            {
                return typeof(ExportProfilePictureFromADContext);
            }
        }

    }
    }

