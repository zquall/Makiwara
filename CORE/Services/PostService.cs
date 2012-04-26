using Nexus;
using AutoMapper;
using System.Linq;
using System.Collections.Generic;
using ReplicantRepository.Response;
using ReplicantRepository.Request;
using ReplicantRepository.DataTransferObjects;

namespace CORE.Services
{
    public class PostService
    {
        public PostResponse SearchPost(PostRequest request)
        {
            var response = new PostResponse {PostList = new List<PostDto>()};

            var postFound = Olympus._Enterprise.Posts.ToList();

            //if (postFound != null)
            if (postFound.Count > 0)
            {
                foreach (var post in postFound)
                {
                    Olympus._Enterprise.Detach(post);
                    var tmpPost = Mapper.Map<PostDto>(post);
                    response.PostList.Add(tmpPost);
                }
            }
            return response;
        }

        public PostResponse GetPost(PostRequest request)
        {
            var response = new PostResponse();
            if (request.PostId > 0)
            {
                var postFound = Olympus._Enterprise.Posts.Where(x => x.Id == request.PostId).SingleOrDefault();
                if (postFound != null)
                {
                    response.Post = Mapper.Map<PostDto>(postFound);
                }
            }
            return response;
        }

        public PostResponse SavePost(PostRequest request)
        {
            var response = new PostResponse();

            if (request.Post != null)
            {
                Post post;

                // Check if Edit or Add
                if (request.Post.Id > 0)
                {   // Edit
                    post = Olympus._Enterprise.Posts.Where(x => x.Id == request.Post.Id).SingleOrDefault();
                    Mapper.Map(request.Post, post);
                }
                else
                {   // Add
                    post = new Post();
                    Mapper.Map(request.Post, post);
                    Olympus._Enterprise.Posts.AddObject(post);
                }
                Olympus._Enterprise.SaveChanges();
                if (post != null) response.PostId = post.Id;
            }
            return response;
        }
    }
}
