using System.Collections.Generic;

namespace Dul.Articles
{
    /// <summary>
    /// 필터링 옵션
    /// </summary>
    /// <typeparam name="TParentIdentifier">부모 PK 형식</typeparam>
    public class FilterOptions<TParentIdentifier>
    {
        #region 페이징 관련 속성들
        /// <summary>
        /// 페이지 인덱스: 현재 보여줄 페이지 번호의 인덱스(PageNumber - 1)
        /// </summary>
        public int PageIndex { get; set; } = 0;

        /// <summary>
        /// 페이지 사이즈: 한 페이지에 몇 개의 레코드를 보여줄건지 결정 
        /// </summary>
        public int PageSize { get; set; } = 10; 
        #endregion

        #region 검색 관련 속성들
        /// <summary>
        /// 기본 리스트면 false, 검색 결과에 대한 페이징 리스트면 true
        /// </summary>
        public bool SearchMode { get; set; } = false;

        /// <summary>
        /// 검색할 필드: Name, Title, Content
        /// </summary>
        public string SearchField { get; set; } = "";

        /// <summary>
        /// 검색할 내용
        /// </summary>
        public string SearchQuery { get; set; } = "";
        #endregion

        #region 정렬 관련 속성들
        /// <summary>
        /// 정렬 여부 
        /// </summary>
        public bool SortMode { get; set; } = false;

        /// <summary>
        /// 정렬할 필드들 
        /// </summary>
        public IDictionary<string, string> SortFields { get; set; }
        #endregion

        #region 부모 관련 속성들
        /// <summary>
        /// 특정 부모 키에 해당하는 컬력션인지 여부 
        /// </summary>
        public bool ChildMode { get; set; } = false;

        /// <summary>
        /// 특정 부모 키의 종류(int, long, string): ChildMode가 true라면 사용
        /// </summary>
        public TParentIdentifier ParentIdentifier { get; set; } 
        #endregion
    }
}
