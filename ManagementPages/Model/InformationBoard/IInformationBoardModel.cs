﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ManagementPages.Model.Category;
using ManagementPages.Services;

namespace ManagementPages.Model.InformationBoard
{
    public interface IInformationBoardModel
    {
        InformationBoardDataModel InformationBoardDataModel { get; set; }

        Dictionary<int, ICategoryModel> Categories { get; set; }

        ICategoryModel SelectedCategory { get; set; }

        List<int> CategoryOrder { get; set; }

        Task<Dictionary<int, ICategoryModel>> LoadCategories(IDbService dbService);

        Task AddNewCategory(CategoryDataModel newCategory, bool isPublished, IDbService dbService);

        Task EditInformationBoard(IDbService dbService);

        Task EditCategoryOrder(IDbService dbService);

        void CheckCategoryOrder();
    }
}