using System;

namespace Dul
{
    /// <summary>
    /// 날짜와 시간 관련 유틸리티 
    /// </summary>
    public class DateTimeUtility
    {
        /// <summary>
        /// 1부터 8760까지의 정수를 입력받아 해당 날짜를 반환해주는 함수 
        /// </summary>
        public static DateTime GetDateTimeFromYearlyHourNumber(int number)
        {
            return (new DateTime(2019, 1, 1, 0, 0, 0)).AddHours(--number);
        }
    }
}
