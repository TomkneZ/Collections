using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Collections.Domain.Entities;

namespace Collections.Domain.Repositories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields();
        TextField GetTextFieldById(Guid id);
        TextField GetTextFieldByCodeWord(string codeWord);
        void SaveTextField(TextField entity);
        void DeleteTextField(Guid id);
    }
}
