

using SearchProgamModul3.Shared.Models;

namespace SearchProgamModul3.Client.Services
{
    public interface IDatabaseInsertService
    {
        void InsertDocument(BEDocument doc);

        // Insert a word in the database with id = [id] and value = [value]
        void InsertWord(int id, string value);

        void InsertAllWords(Dictionary<string, int> words);

        void InsertAllOcc(int docId, ISet<int> wordIds);

        void InsertAllWords(List<Word> word);
    }
}
