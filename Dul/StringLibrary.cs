﻿namespace Dul
{
    public static class StringLibrary
    {
        /// <summary>
        /// 주어진 문자열을 주어진 길이만큼만 잘라서 반환. 나머지 부분은 '...'을 붙임.
        /// </summary>
        /// <param name="strCut">원본 문자열</param>
        /// <param name="intChar">잘라낼 길이</param>
        /// <returns>안녕하세요. => 안녕...</returns>
        public static string CutString(this string strCut, int intChar)
        {
            if (strCut.Length > (intChar - 3))
            {
                return strCut.Substring(0, intChar - 3) + "...";
            }
            return strCut;
        }

        /// <summary>
        /// 유니코드 이모티콘을 포함한 문자열 자르기
        /// </summary>
        /// <param name="str">한글, 영문, 유니코드 문자열</param>
        /// <param name="length">자를 문자열의 길이</param>
        /// <returns>잘라진 문자열</returns>
        public static string CutStringUnicode(this string str, int length)
        {
            string result = str;

            var si = new System.Globalization.StringInfo(str);
            var l = si.LengthInTextElements;

            if (l > (length - 3))
            {
                result = si.SubstringByTextElements(0, length - 3) + "...";
            }

            return result;
        }
    }
}
