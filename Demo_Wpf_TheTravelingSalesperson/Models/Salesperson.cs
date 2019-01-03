using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_TheTravelingSalesperson.Models
{
    public class Salesperson
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private string _firstName;
        private string _lastName;
        private int _accountId;

        #endregion

        #region PROPERTIES

        public int AccountId
        {
            get { return _accountId; }
            set { _accountId = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        
        #endregion

        #region CONSTRUCTORS



        #endregion

        #region METHODS



        #endregion

        #region EVENTS



        #endregion
    }
}
