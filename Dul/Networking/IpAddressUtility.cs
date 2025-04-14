using System.Net;

namespace Dul.Networking
{
    /// <summary>
    /// Provides utility methods for IP address operations.
    /// </summary>
    public static class IpAddressUtility
    {
        /// <summary>
        /// Determines whether the specified IP address is within the given range.
        /// </summary>
        /// <param name="currentIp">The IP address to check.</param>
        /// <param name="startIp">The start of the IP range.</param>
        /// <param name="endIp">The end of the IP range.</param>
        /// <returns><c>true</c> if the IP address is within range; otherwise, <c>false</c>.</returns>
        public static bool IsIpInRange(string currentIp, string startIp, string endIp)
        {
            var addr = IPAddress.Parse(currentIp);
            var lowerBound = IPAddress.Parse(startIp);
            var upperBound = IPAddress.Parse(endIp);

            byte[] addrBytes = addr.GetAddressBytes();
            byte[] lowerBytes = lowerBound.GetAddressBytes();
            byte[] upperBytes = upperBound.GetAddressBytes();

            for (int i = 0; i < addrBytes.Length; i++)
            {
                if (addrBytes[i] < lowerBytes[i] || addrBytes[i] > upperBytes[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
