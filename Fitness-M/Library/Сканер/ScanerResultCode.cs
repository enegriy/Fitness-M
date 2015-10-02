using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fitness_M
{
	public static class ScanerResultCode
	{
		//КОНСТАНТЫ КОМАНД СЧИТЫВАТЕЛЯ

		/// <summary>
		/// RES_OK
		/// </summary>
		public const short RES_OK = 0;

		/// <summary>
		/// RES_NO_CARD_ERROR
		/// </summary>
		public const short RES_NO_CARD_ERROR = 1;

		/// <summary>
		/// RES_ERR_INVALID_HANDLE
		/// </summary>
		public const short RES_ERR_INVALID_HANDLE = 2;

		/// <summary>
		/// RES_EMPTY
		/// </summary>
		public const short RES_EMPTY = 3;

		/// <summary>
		/// RES_WRONG_PARAMS
		/// </summary>
		public const short RES_WRONG_PARAMS = 4;

		/// <summary>
		/// RES_CRC_ERROR
		/// </summary>
		public const short RES_CRC_ERROR = 5;

		/// <summary>
		/// RES_INVALID_DATA
		/// </summary>
		public const short RES_INVALID_DATA = 6;

		/// <summary>
		/// RES_COMM_TIMEOUT
		/// </summary>
		public const short RES_COMM_TIMEOUT = 7;

		/// <summary>
		/// RES_READ_ERROR
		/// </summary>
		public const short RES_READ_ERROR = 8;

		/// <summary>
		/// RES_WRITE_ERROR
		/// </summary>
		public const short RES_WRITE_ERROR = 9;

		/// <summary>
		/// RES_OVERFLOW_ERROR
		/// </summary>
		public const short RES_OVERFLOW_ERROR = 10;

		/// <summary>
		/// RES_JUST_OPENED
		/// </summary>
		public const short RES_JUST_OPENED = 11;

		/// <summary>
		/// RES_JUST_CLOSED
		/// </summary>
		public const short RES_JUST_CLOSED = 12;

		/// <summary>
		/// RES_NO_IMPLEMENTED
		/// </summary>
		public const short RES_NO_IMPLEMENTED = 13;
	}
}
