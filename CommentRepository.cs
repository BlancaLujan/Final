using System;
using System.Collections.Generic;
using System.Linq;
using Program.File.MyClasses;
using Program.File.Repositories.Implementation;

namespace Program.File.Repositories
{
    public class CommentRepository : MainRepository<Comment>, ICommentRepository
    {
        public CommentRepository()
        {
            List<Comment> resultList =
              currentDataBase.Where(comment => comment.Comments == "").ToList();
            if (resultList.Count > 0)
            {
                foreach (var user in resultList)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    

                }

            }
            else
            {
                Console.WriteLine("No comment found");
            }
        }

        public void GetAllComments(string name)
        {
            throw new NotImplementedException();
        }
    }
}
