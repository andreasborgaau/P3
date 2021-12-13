﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementPages.Function;
using ManagementPages.Model.Post;

namespace ManagementPages.Model.Category
{
    public interface ICategoryModel
    {
        CategoryDataModel CategoryDataModel { get; set; }

        List<IPostModel> Posts { get; set; }

        Task<List<IPostModel>> LoadPosts(IDbService dbService);

        Task AddNewPost(PostDataModel newPost, bool isPublished, IDbService dbService);

        Task EditCategory(IDbService dbService);

        Task DeleteCategoryFromDatabase(IDbService dbService);

        void DeletePost(IPostModel postModel);
    }
}