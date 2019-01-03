using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_TheTravelingSalesperson.Models
{
    public class SalesTrackerViewModel
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private Salesperson _salesperson;
        private ObservableCollection<CityTransaction> _transactions;
        private CityTransaction _selectedTransaction;
        private string _product;
        private double _unitPrice;

        #endregion

        #region PROPERTIES

        public Salesperson Salesperson
        {
            get { return _salesperson; }
            set { _salesperson = value; }
        }

        public ObservableCollection<CityTransaction> Transactions
        {
            get { return _transactions; }
            set { _transactions = value; }
        }

        public CityTransaction SelectedTransaction
        {
            get { return _selectedTransaction; }
            set { _selectedTransaction = value; }
        }

        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public double UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
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
