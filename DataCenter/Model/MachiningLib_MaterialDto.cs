using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;


namespace DataCenter.Model
{
    public class MachiningLib_MaterialDto : ViewModelBase
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

        private double thickness;
        public double Thickness
        {
            get { return thickness; }
            set
            {
                if (thickness != value)
                {
                    thickness = value;
                    RaisePropertyChanged(() => Thickness);
                }
            }
        }

    }
}
