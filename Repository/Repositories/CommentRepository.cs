using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class CommentRepository:IRepository<Comment>
    {
        private readonly IContext context;
        public CommentRepository(IContext _context)
        {
            this.context = _context;
        }
        public async Task Add(Comment commen)
        {
           await context.Comments.AddAsync(commen);
           await this.context.Save();
        }

        public async Task<List<Comment>> GetAll()
        {
            return await context.Comments.ToListAsync();
        }

        public async Task Update(int id, Comment _commen)
        {
            var comment = this.context.Comments.FirstOrDefault(x => x.Id == id);
            comment.ClientId = _commen.ClientId;
            comment.TrayId= _commen.TrayId;
            //comment.Image = _commen.Image;
            comment.Response = _commen.Response;
            comment.Rating = _commen.Rating;
            await this.context.Save();
        }

        public async Task<Comment> GetById(int id)
        {
            return await context.Comments.FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task Remove(int id)
        {
            context.Comments.Remove(await GetById(id));
            await this.context.Save();
        }
    }
}
