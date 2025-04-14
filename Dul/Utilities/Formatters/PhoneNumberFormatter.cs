using System.Linq;

namespace Dul.Utilities.Formatters
{
    public static class PhoneNumberFormatter
    {
        public static string Format(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return "None";

            var digitsOnly = new string(phoneNumber.Where(char.IsDigit).ToArray());

            // 미국/캐나다 번호 (10자리)
            if (digitsOnly.Length == 10 && digitsOnly.StartsWith("1") == false && digitsOnly.StartsWith("0") == false)
            {
                return $"({digitsOnly.Substring(0, 3)}) {digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6, 4)}";
            }

            // 한국 휴대폰 번호 (11자리, 010으로 시작)
            if (digitsOnly.Length == 11 && digitsOnly.StartsWith("010"))
            {
                return $"{digitsOnly.Substring(0, 3)}-{digitsOnly.Substring(3, 4)}-{digitsOnly.Substring(7, 4)}";
            }

            // 한국 서울 번호 (10자리, 02로 시작)
            if (digitsOnly.Length == 10 && digitsOnly.StartsWith("02"))
            {
                return $"{digitsOnly.Substring(0, 2)}-{digitsOnly.Substring(2, 4)}-{digitsOnly.Substring(6, 4)}";
            }

            // 한국 기타 지역번호 (10자리, 03X, 04X, 05X 등)
            if (digitsOnly.Length == 10 && digitsOnly.StartsWith("0"))
            {
                return $"{digitsOnly.Substring(0, 3)}-{digitsOnly.Substring(3, 3)}-{digitsOnly.Substring(6, 4)}";
            }

            // 그 외: 원본 반환
            return phoneNumber;
        }
    }
}
