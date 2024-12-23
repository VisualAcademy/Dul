namespace Dul.Board
{
    /// <summary>
    /// CopyType 열거형에 대한 한글화된 문자열 반환
    /// </summary>
    public static class CopyTypeExtensions
    {
        public static string ToFriendlyString(this CopyType copyType)
        {
            string r = "";

            switch (copyType)
            {
                case CopyType.Copy:
                    r = "복사";
                    break;
                case CopyType.Move:
                    r = "이동";
                    break;
                default:
                    r = "복사";
                    break;
            }

            return r;
        }
    }
}
