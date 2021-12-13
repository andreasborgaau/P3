﻿using System.ComponentModel.DataAnnotations;

namespace ManagementPages.Model.Category
{
    public class CategoryDataModel
    {
        public int CategoryId { get; set; }

        public int InformationBoardId { get; set; }

        [Required(ErrorMessage = "Titel-feltet skal udfyldes")]
        [StringLength(30, ErrorMessage = "Titlen er for lang")]
        public string Title { get; set; }

        public bool IsPublished { get; set; }

        [Required(ErrorMessage = "Vælg et ikon")]
        [StringLength(30, ErrorMessage = "Det valgte ikon kan ikke bruges. Vælg et andet")]
        public string Icon { get; set; }
    }
}