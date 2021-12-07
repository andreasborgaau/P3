﻿using System.Collections.Generic;
using ManagementPages.Model;

namespace ManagementPages.Functions
{
    public interface ILicenseViewModel
    {
        public LicenseModel LicenseModel { get; set; }

        public List<IInformationBoardViewModel> InformationBoards { get; set; }

        public IInformationBoardViewModel SelectedInformationBoard { get; set; }
    }
}