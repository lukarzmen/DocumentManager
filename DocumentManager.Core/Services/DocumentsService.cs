using AutoMapper;
using DocumentManager.Core.DTOs;
using DocumentManager.Infrastructure.Entities;
using DocumentManager.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentManager.Core.Services
{
    public class DocumentsService
    {
        private readonly IDocumentsRepository documentsRepository;
        private readonly IMapper mapper;

        public DocumentsService(IDocumentsRepository documentsRepository, IMapper mapper)
        {
            this.documentsRepository = documentsRepository;
            this.mapper = mapper;
        }
        public async Task<DocumentDTO> GetDocument()
        {
            var documentSet = await documentsRepository.GetDocuments();
            var rootDocument = documentSet.Where(document => document.ParentID == null);
            // todo: przeksztalcenie  listy w drzewo
            throw new NotImplementedException();
        }

        public async Task AddDocument(DocumentDTO documentDTO)
        {
            var documentToAdd = new Document()
            {
                ID = documentDTO.ID,
                ParentID = documentDTO.Parent?.ID,
                Text = documentDTO.Text,
                Title = documentDTO.Title
            };
            await documentsRepository.AddDocument(documentToAdd);
        }
        public async Task DeleteDocument(int documentIDToDelete)
        {
            await documentsRepository.Delete(documentIDToDelete);
        }

        public async Task<bool> EditText(int documentID, string text)
        {
            return await documentsRepository.EditText(documentID, text);
        }

        public async Task<bool> EditTitle(int documentID, string titleText)
        {
            return await documentsRepository.EditTitle(documentID, titleText);
        }
    }
}
