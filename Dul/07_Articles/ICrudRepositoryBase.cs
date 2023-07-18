using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dul.Articles
{
    /// <summary>
    /// CRUD 제네릭 인터페이스
    /// </summary>
    /// <typeparam name="T">모델 클래스 형식</typeparam>
    /// <typeparam name="TIdentifier">부모 식별자 형식</typeparam>
    public interface ICrudRepositoryBase<T, TIdentifier> where T : class
    {
        /// <summary>
        /// 입력
        /// </summary>
        Task<T> AddAsync(T model);

        /// <summary>
        /// 출력
        /// </summary>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// 상세
        /// </summary>
        Task<T> GetByIdAsync(TIdentifier id);

        /// <summary>
        /// 수정
        /// </summary>
        Task<bool> UpdateAsync(T model);

        /// <summary>
        /// 삭제
        /// </summary>
        Task<bool> DeleteAsync(TIdentifier id);

        /// <summary>
        /// 필터링
        /// </summary>
        Task<ArticleSet<T, int>> GetArticlesAsync<TParentIdentifier>(int pageIndex, int pageSize, string searchField, string searchQuery, string sortOrder, TParentIdentifier parentIdentifier);

        /// <summary>
        /// 필터링 관련 메서드 이름 추가: GetArticlesAsync 메서드와 동일 구조 
        /// </summary>
        Task<ArticleSet<T, int>> GetAllAsync<TParentIdentifier>(int pageIndex, int pageSize, string searchField, string searchQuery, string sortOrder, TParentIdentifier parentIdentifier);
    }

    /// <summary>
    /// CRUD 제네릭 인터페이스
    /// </summary>
    /// <typeparam name="T">모델 클래스 형식</typeparam>
    /// <typeparam name="V">Id 형식: int or long</typeparam>
    /// <typeparam name="TIdentifier">식별자 형식</typeparam>
    public interface ICrudRepositoryBase<T, V, TIdentifier> where T : class
    {
        /// <summary>
        /// 입력
        /// </summary>
        Task<T> AddAsync(T model);

        /// <summary>
        /// 출력
        /// </summary>
        Task<List<T>> GetAllAsync();

        /// <summary>
        /// 상세
        /// </summary>
        Task<T> GetByIdAsync(TIdentifier id);

        /// <summary>
        /// 수정
        /// </summary>
        Task<bool> UpdateAsync(T model);

        /// <summary>
        /// 삭제
        /// </summary>
        Task<bool> DeleteAsync(TIdentifier id);

        /// <summary>
        /// 필터링
        /// </summary>
        Task<ArticleSet<T, V>> GetArticlesAsync<TParentIdentifier>(int pageIndex, int pageSize, string searchField, string searchQuery, string sortOrder, TParentIdentifier parentIdentifier);

        /// <summary>
        /// 필터링 관련 메서드 이름 추가: GetArticlesAsync 메서드와 동일 구조 
        /// </summary>
        Task<ArticleSet<T, V>> GetAllAsync<TParentIdentifier>(int pageIndex, int pageSize, string searchField, string searchQuery, string sortOrder, TParentIdentifier parentIdentifier);
    }
}
