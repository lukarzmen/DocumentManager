using DocumentManager.Infrastructure.Data;
using DocumentManager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Infrastructure.Repository
{
    public class DocumentsRepository : IDocumentsRepository
    {
        private readonly ILogger logger;
        private readonly DocumentManagerContext documentManagerContext;

        public DocumentsRepository(DocumentManagerContext documentManagerContext, ILogger logger)
        {
            this.logger = logger;
            this.documentManagerContext = documentManagerContext ?? throw new ArgumentNullException(nameof(documentManagerContext));
        }

        public async Task<IEnumerable<Document>> GetDocuments()
        {
            return await documentManagerContext.Documents.ToListAsync();
        }

        public async Task AddDocument(Document document)
        {
            await documentManagerContext.Documents.AddAsync(document);
            await documentManagerContext.SaveChangesAsync();
        }
        public async Task<bool> EditTitle(int id, string titleText)
        {
            var documentToEdit = await documentManagerContext.Documents.FindAsync(id);
            if(documentToEdit == null)
            {
                return false;
            }
            documentToEdit.Title = titleText;
            await documentManagerContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> EditText(int id, string text)
        {
            var documentToEdit = await documentManagerContext.Documents.FindAsync(id);
            if(documentToEdit == null)
            {
                return false;
            }
            documentToEdit.Text = text;
            await documentManagerContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> Delete(int documentToDeleteId)
        {
            return false;
            //todo: usuniecie elementu z drzewa wraz ze wszsytkimi potomkami
            //Document rootDocumentToDelete = await documentManagerContext.Documents.FindAsync(documentToDeleteId);

            //var documentManagerContext.


            //bool noChildDocuments = rootDocumentToDelete != null;
            //while (noChildDocuments)
            //await documentManagerContext.SaveChangesAsync();
        }
    }
}
