using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManagement.Core.Domain
{
    public class Library : Identifiable
    {
        #region Private Fields

        private string _name = "";

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region Constructors

        public Library()
        {
            
        }

        #endregion
    }
}
