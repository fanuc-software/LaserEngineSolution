using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCenter
{
    public class BaseIdGenerator
    {
        private readonly IdGenerator _numberGenerator = new IdGenerator(5);

        /// <summary>
        /// ctor
        /// </summary>
        public BaseIdGenerator()
        {
        }

        /// <summary>
        /// 生成11+seedWidth长度的ID
        /// </summary>
        /// <returns></returns>
        public string GetId()
        {
            return _numberGenerator.GetId(DateTime.Now);
        }

        /// <summary>
        /// Instance
        /// </summary>
        public static readonly BaseIdGenerator Instance = new BaseIdGenerator();
    }

    public class IdGenerator
    {
        private readonly long _max;
        private int _seed;
        private readonly object _locker = new object();

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="seedWith"></param>
        public IdGenerator(int seedWith)
        {
            _max = (long)Math.Pow(10, seedWith) - 1;
        }

        private const string TimeFormat = "yyMMdd";

        /// <summary>
        /// 生成Id
        /// </summary>
        /// <returns></returns>
        public string GetId(DateTime time)
        {
            var prefix = time.ToString(TimeFormat);

            var stamp = (time.Hour * 3600 + time.Minute * 60 + time.Second).ToString().PadLeft(5, '0');

            lock (_locker)
            {
                _seed++;
                var id = string.Format("{0}{1}{2}", prefix, stamp, _seed.ToString().PadLeft(5, '0'));

                if (_seed >= _max)
                {
                    _seed = 0;
                }
                return id;
            }
        }
    }
}
