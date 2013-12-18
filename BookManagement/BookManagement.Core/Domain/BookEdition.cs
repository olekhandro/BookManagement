using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManagement.Core.Domain
{
    public class BookEdition:Identifiable
    {
        #region Private Fields

        private string _name = "";
        private int _number = 0;

        #endregion

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        #endregion

        #region Constructors

        public BookEdition()
        {
            
        }

        #endregion
    }
}
