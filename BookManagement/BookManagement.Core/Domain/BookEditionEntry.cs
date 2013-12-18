using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;

namespace BookManagement.Core.Domain
{
    public class BookEditionEntry:Identifiable
    { 
        #region Private Fields

        private int _number = 0;
        
        #endregion
        
        #region Properties

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public BookEdition BookEdition { get; set; }

        public Library Library { get; set; }

        #endregion

        #region Constructors

        public BookEditionEntry()
        {
            
        }

        #endregion
    }
}
