using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Fitness_M
{
    public delegate void CallbackActionWithCode(uint Code);

    public static class Scaner
    {
        #region Prop
        /// <summary>
        /// Количество сканеров в системе
        /// </summary>
        public static short CountScanners { get; set; }
        /// <summary>
        /// Описание сканера
        /// </summary>
        public static char[] ScannerDescr {get;set;}
        /// <summary>
        /// Максимальная длина описателя считывателя
        /// </summary>
        public static short MAX_DESC_LEN = 80;
        /// <summary>
        /// Сканер открыт
        /// </summary>
        public static bool IsScanerOpened{get;set;}
        /// <summary>
        /// Действие при чтении кода
        /// </summary>
        public static CallbackActionWithCode ActionWithCode=null;
        #endregion

        #region Public Methods
        /// <summary>
        /// Получить сканер
        /// </summary>
        /// <returns></returns>
        public static bool GetScaner()
        {
            bool rslt = true;

            try
            {
                //Результат
                int resCode = ScanerResultCode.RES_OK;

                CountScanners = Enumerate();

                if (CountScanners <= 0)
                {
                    rslt = false;
                }
                else
                {
                    ScannerDescr = new char[MAX_DESC_LEN];
                    resCode = GetFirstReader(ScannerDescr, MAX_DESC_LEN);
                    if (resCode != ScanerResultCode.RES_OK)
                    {
                        rslt = false;
                    }
                    else
                    {
                        IsScanerOpened = true;
                        Application.DoEvents();
                    }
                }
            }
            catch (Exception ex)
            {
                rslt = false;
            }
            return rslt;
        }

        /// <summary>
        /// Получить текст ошибки
        /// </summary>
        /// <param name="err_code"></param>
        /// <returns></returns>
        public static string ErrMsgText(int err_code)
        {
            switch (err_code)
            {
                case ScanerResultCode.RES_OK: return "OK !";
                case ScanerResultCode.RES_NO_CARD_ERROR: return "Нет карты";
                case ScanerResultCode.RES_ERR_INVALID_HANDLE: return "Невалидный handle";
                case ScanerResultCode.RES_EMPTY: return "Результат пуст";
                case ScanerResultCode.RES_WRONG_PARAMS: return "Неправильные параметры";
                case ScanerResultCode.RES_CRC_ERROR: return "Ошибка контрольной суммы";
                case ScanerResultCode.RES_INVALID_DATA: return "Некорректные данные";
                case ScanerResultCode.RES_COMM_TIMEOUT: return "Таймаут обмена";
                case ScanerResultCode.RES_WRITE_ERROR: return "Ошибка записи";
                case ScanerResultCode.RES_OVERFLOW_ERROR: return "Переполнение данных";
                case ScanerResultCode.RES_JUST_OPENED: return "Уже открыт";
                case ScanerResultCode.RES_JUST_CLOSED: return "Уже закрыт";
                case ScanerResultCode.RES_NO_IMPLEMENTED: return "Функция не реализована";
                default: return "Ошибка не имеет описания";
            }
        }

        /// <summary>
        /// Открыть сканер
        /// </summary>
        public static void OpenScaner()
        {
            var isGetScanner = Scaner.GetScaner();

            if (isGetScanner)
            {
                int res = Scaner.OpenReader(0);
                res = Scaner.SetBeepBlinkMode(0, 1, 1);
                Application.Idle += ApplicationIdleEvents;
                ActionWithCode += ClientController.ActionCodeWasScaned;
            }
        }

        /// <summary>
        /// Закрыть сканер
        /// </summary>
        public static void CloseScanner()
        {
            if (Scaner.IsScanerOpened)
            {
                Scaner.CloseReader(0);
                Application.Idle -= ApplicationIdleEvents;
                ActionWithCode -= ClientController.ActionCodeWasScaned;
            }
        }

        /// <summary>
        /// Обработка номеров карты
        /// </summary>
        public static void ApplicationIdleEvents(object sender, EventArgs e)
        {
            if (Scaner.IsScanerOpened)
            {
                uint code = 0;
                var res = Scaner.ReadCardNumber(0, ref code);
                if (res == ScanerResultCode.RES_OK)
                {
                    if (ActionWithCode != null)
                        ActionWithCode.Invoke(code);
                }
            }
        }
        #endregion

        #region Extenr Methods
        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short Enumerate();

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short GetFirstReader([In, Out] char[] descr, [In, Out] short max_len);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short GetNextReader([In, Out] char[] descr, [In, Out] short max_len);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short OpenReader(short number);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short CloseReader(short number);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short SetBeepBlinkMode(short number, short useblink, short usebeep);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short BeepBlink(short number);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short SetWiegand26(short on);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short ReadCardNumber(short number, [In, Out] ref UInt32 code);

        [DllImport("prx08.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern short ReadCardNumberRaw(short num, [In, Out] ref short ctype, [In, Out] char[] cserial, [In, Out] ref short clen);
        #endregion

    }
}
