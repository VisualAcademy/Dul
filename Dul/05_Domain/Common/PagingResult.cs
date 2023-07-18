using System.Collections.Generic;

namespace Dul.Domain.Common
{
    /// <summary>
    /// Paging 처리된 레코드셋과 전체 레코드 카운트를 반환하는 PagingResult 클래스
    /// </summary>
    /// <typeparam name="T">모델 클래스 형식</typeparam>
    public struct PagingResult<T>
    {
        /// <summary>
        /// 페이징 처리된 레코드셋
        /// </summary>
        public IEnumerable<T> Records { get; set; }

        /// <summary>
        /// 전체 레코드의 개수
        /// </summary>
        public int TotalRecords { get; set; }

        /// <summary>
        /// 페이징 처리된 레코드셋과 전체 레코드의 개수를 인자로 받아 초기화하는 생성자
        /// </summary>
        /// <param name="items">페이징 처리된 레코드셋</param>
        /// <param name="totalRecords">전체 레코드의 개수</param>
        public PagingResult(IEnumerable<T> items, int totalRecords)
        {
            Records = items;
            TotalRecords = totalRecords;
        }
    }
}
