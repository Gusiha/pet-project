using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using api.DTOs.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this CommentModel comment)
        {
            return new CommentDto()
            {
                Id = comment.Id,
                Title = comment.Title,
                Content = comment.Content,
                CreatedOn = comment.CreatedOn,
                StockId = comment.StockId
            };
        }

        public static CommentModel ToCommentFromCreate(this CreateCommentRequestDto comment, int stockId)
        {
            return new CommentModel()
            {
                Title = comment.Title,
                Content = comment.Content,
                StockId = stockId
            };
        }

        public static CommentModel ToCommentFromUpdate(this UpdateCommentRequestDto comment)
        {
            return new CommentModel()
            {
                Title = comment.Title,
                Content = comment.Content
            };
        }


    }
}