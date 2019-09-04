using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modbus.Net;
using Modbus.Net.Siemens;

namespace LaserEngineHmi.S200
{
    public class SiemensS200Smart
    {
        public string IP { get; set; }
        public byte Slave { get; set; }
        public byte Master { get; set; }

        private const int MaxRecon = 3;

        private SiemensMachine _clinet;

        public SiemensS200Smart(string ip, byte slave, byte master)
        {
            IP = ip;
            Slave = slave;
            Master = master;
            _clinet = new SiemensMachine( SiemensType.Tcp,ip,SiemensMachineModel.S7_200_Smart, null, true, slave, master);
        }

        private bool ReadData(string area, int adr, ref int data)
        {
            var addresses = new List<AddressUnit>()
            {
                new AddressUnit
                {
                    Id = area + adr,
                    Area = area,
                    Address = adr,
                    SubAddress = 0,
                    CommunicationTag = area + adr,
                    DataType = typeof(int)
                }
            };

            for (int j = 0; j < MaxRecon; j++)
            {
                _clinet.GetAddresses = addresses;
                var ans = _clinet.GetDatas(MachineGetDataType.CommunicationTag);

                if (ans != null)
                {
                    data = (int)ans[area + adr].PlcValue ;
                    return true;
                }
            }

            return false;


        }
    }
}
