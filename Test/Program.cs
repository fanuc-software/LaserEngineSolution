using Modbus.Net;
using Modbus.Net.Modbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            ModbusMachine _modbusTcpMachine = new ModbusMachine(ModbusType.Tcp, "192.168.2.2", null, true, 2, 0);

            var addresses = new List<AddressUnit>
            {
                new AddressUnit
                {
                    Id = "0",
                    Area = "3X",
                    Address = 1,
                    SubAddress = 0,
                    CommunicationTag = "A1",
                    DataType = typeof(int)
                }
            };

            _modbusTcpMachine.GetAddresses = addresses;
            var ans = _modbusTcpMachine.GetDatasAsync(MachineGetDataType.Address).Result;
            var data = ans["3X 1.0"].PlcValue;

            Console.WriteLine(data);

            Console.ReadKey();
        }
    }
}
