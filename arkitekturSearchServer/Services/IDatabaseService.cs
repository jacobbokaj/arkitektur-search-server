using SearchProgamModul3.Shared.Models;

namespace SearchProgamModul3.Client.Services
{
    public interface IDatabaseService
    {
        Task<int[]?> GetWordIds(string[] query, out List<string> outIgnored, bool caseSensitive);
        Task<BEDocument[]?> GetDocDetails(List<int> docIds);
        Task<KeyValuePair<int, int>[]?> GetDocuments(List<int> wordIds);
        Task<int[]?> GetMissing(int docId, List<int> wordIds);
        Task<string[]?> WordsFromIds(List<int> wordIds);
        Task<Word[]?> GetAllWords();

        Task<Word?> GetWord(int id);

        Task<SearchResult?> GetSearchResultWithCondition(string query, bool caseSensitiveFlag);
    }
}
