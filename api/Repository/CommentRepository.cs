using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.DTOs.Comment;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment?> GetByIdAsync(int id)
        {
            return await _context.Comments.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Comment> CreateAsync(Comment comment)
        {
            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment;
        }

        public async Task<Comment?> DeleteAsync(int id)
        {
            var commentToDelete = await GetByIdAsync(id);

            if (commentToDelete == null)
            {
                return null;
            }

            _context.Comments.Remove(commentToDelete);
            await _context.SaveChangesAsync();
            return commentToDelete;
        }

        public async Task<Comment?> UpdateAsync(int id, Comment updateDto)
        {
            var existingComment = await _context.Comments.FindAsync(id);

            if(existingComment == null)
            {
                return null;
            }

            existingComment.Title = updateDto.Title;
            existingComment.Content = updateDto.Content;

            await _context.SaveChangesAsync();
            return existingComment;
        }
    }


}