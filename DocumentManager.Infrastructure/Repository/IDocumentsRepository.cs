using DocumentManager.Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DocumentManager.Infrastructure.Repository
{
    public interface IDocumentsRepository
    {
        Task AddDocument(Document document);
        Task<bool> Delete(int documentToDeleteId);
        Task<bool> EditText(int id, string text);
        Task<bool> EditTitle(int id, string titleText);
        Task<IEnumerable<Document>> GetDocuments();
    }
}