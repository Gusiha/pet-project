using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Comment;
using api.Models;

namespace api.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<CommentModel>> GetAllAsync();
        Task<CommentModel?> GetByIdAsync(int id);
        Task<CommentModel> CreateAsync(CommentModel comment);
        Task<CommentModel?> DeleteAsync(int id);
        Task<CommentModel?> UpdateAsync(int id, CommentModel updateDto);
    }
}