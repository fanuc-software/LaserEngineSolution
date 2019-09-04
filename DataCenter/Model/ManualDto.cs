using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace DataCenter.Model
{
    public class ManualDto : ViewModelBase
    {
        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged(() => Id);
                }
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged(() => Name);
                }
            }
        }

        private string specification;
        public string Specification
        {
            get { return specification; }
            set
            {
                if (specification != value)
                {
                    specification = value;
                    RaisePropertyChanged(() => Specification);
                }
            }
        }

        private string version;
        public string Version
        {
            get { return version; }
            set
            {
                if (version != value)
                {
                    version = value;
                    RaisePropertyChanged(() => Version);
                }
            }
        }

        private string path;
        public string Path
        {
            get { return path; }
            set
            {
                if (path != value)
                {
                    path = value;
                    RaisePropertyChanged(() => Path);
                }
            }
        }

    }
}
