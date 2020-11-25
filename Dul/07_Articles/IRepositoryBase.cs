using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dul.Articles
{
    /// <summary>
    /// 리포지토리 제네릭 인터페이스 
    /// </summary>
    /// <typeparam name="TModel">모델 클래스 형식</typeparam>
    /// <typeparam name="TTotalCount">총 레코드 수 형식(int 또는 long)</typeparam>
    /// <typeparam name="TIdentifier">식별자 형식</typeparam>
    public interface IRepositoryBase<TModel, TTotalCount, TIdentifier> where TModel : class
    {
        Task<TModel> AddAsync(TModel model); // 입력
        Task<IEnumerable<TModel>> GetAllAsync(); // 출력
        Task<TModel> GetByIdAsync(TIdentifier id); // 상세
        Task<bool> UpdateAsync(TModel model); // 수정
        Task<bool> DeleteAsync(TIdentifier id); // 삭제
        //Task<bool> DeleteAsync(TModel id); // 삭제
        Task<ArticleSet<TModel, TTotalCount>> GetByAsync<TParentIdentifier>(FilterOptions<TParentIdentifier> options); // 필터링
    }
}
