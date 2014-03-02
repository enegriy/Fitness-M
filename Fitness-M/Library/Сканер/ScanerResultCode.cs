using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
    public static class ScanerResultCode
    {
        //КОНСТАНТЫ КОМАНД СЧИТЫВАТЕЛЯ
        public const short RES_OK = 0;
        public const short RES_NO_CARD_ERROR = 1;
        public const short RES_ERR_INVALID_HANDLE = 2;
        public const short RES_EMPTY = 3;
        public const short RES_WRONG_PARAMS = 4;
        public const short RES_CRC_ERROR = 5;
        public const short RES_INVALID_DATA = 6;
        public const short RES_COMM_TIMEOUT = 7;
        public const short RES_READ_ERROR = 8;
        public const short RES_WRITE_ERROR = 9;
        public const short RES_OVERFLOW_ERROR = 10;
        public const short RES_JUST_OPENED = 11;
        public const short RES_JUST_CLOSED = 12;
        public const short RES_NO_IMPLEMENTED = 13;
    }
}
