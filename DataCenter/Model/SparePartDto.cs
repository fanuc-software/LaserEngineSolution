using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace DataCenter.Model
{
    public class SparePartDto : ViewModelBase
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

        private string position;
        public string Position
        {
            get { return position; }
            set
            {
                if (position != value)
                {
                    position = value;
                    RaisePropertyChanged(() => Position);
                }
            }
        }

        private string remark;
        public string Remark
        {
            get { return remark; }
            set
            {
                if (remark != value)
                {
                    remark = value;
                    RaisePropertyChanged(() => Remark);
                }
            }
        }
    }
}
