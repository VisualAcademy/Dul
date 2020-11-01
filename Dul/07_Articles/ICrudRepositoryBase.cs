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
        Task<T> AddAsync(T model); // 입력
        Task<List<T>> GetAllAsync(); // 출력
        Task<T> GetByIdAsync(TIdentifier id); // 상세
        Task<bool> UpdateAsync(T model); // 수정
        Task<bool> DeleteAsync(TIdentifier id); // 삭제
        // 필터링 
        Task<ArticleSet<T, int>> GetArticlesAsync<TParentIdentifier>(
            int pageIndex,
            int pageSize,
            string searchField,
            string searchQuery,
            string sortOrder,
            TParentIdentifier parentIdentifier);
    }

    /// <summary>
    /// CRUD 제네릭 인터페이스
    /// </summary>
    /// <typeparam name="T">모델 클래스 형식</typeparam>
    /// <typeparam name="V">Id 형식: int or long</typeparam>
    /// <typeparam name="TIdentifier">식별자 형식</typeparam>
    public interface ICrudRepositoryBase<T, V, TIdentifier> where T : class
    {
        Task<T> AddAsync(T model); // 입력
        Task<List<T>> GetAllAsync(); // 출력
        Task<T> GetByIdAsync(TIdentifier id); // 상세
        Task<bool> UpdateAsync(T model); // 수정
        Task<bool> DeleteAsync(TIdentifier id); // 삭제
        // 필터링 
        Task<ArticleSet<T, V>> GetArticlesAsync<TParentIdentifier>(
            int pageIndex,
            int pageSize,
            string searchField,
            string searchQuery,
            string sortOrder,
            TParentIdentifier parentIdentifier);
    }
}
