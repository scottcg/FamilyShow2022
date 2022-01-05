using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Microsoft.FamilyShow
{
    public partial class MainWindowViewModel
    {
        public ICommand ChangeSkin { get; }

        public ICommand Close { get; }

        public ICommand Create { get; }

        public ICommand ExportBirth { get; }

        public ICommand ExportGedcom { get; }

        public ICommand ImportGedcom { get; }

        public ICommand Open { get; }

        public ICommand Save { get; }

        public ICommand SaveAs { get; }

        public ICommand SaveXps { get; }

        public ICommand VersionMessageClosed { get; }

        public ICommand VisitVertigoWebSite { get; }

        public ICommand WhatIsGedcom { get; }

    }
}
