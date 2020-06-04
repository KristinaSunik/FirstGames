using System;

namespace GeniiIdiotWinFormsApp1
{
    public partial class FullNameForm: GeniiIdiotWinFormsApp
    {
        internal new GeniiIdiotWinFormsApp MdiParent;
        private GeniiIdiotWinFormsApp geniiIdiotWinFormsApp;

        public FullNameForm(GeniiIdiotWinFormsApp geniiIdiotWinFormsApp)
        {
            this.geniiIdiotWinFormsApp = geniiIdiotWinFormsApp;
        }
    }
}