using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Wpf_TheTravelingSalesperson.Models
{
    public class CityTransaction
    {

        #region ENUMS



        #endregion

        #region FIELDS

        private string _cityName;
        private DateTime _date;
        private int _buy;
        private int _sell;
        private string _note;
        private string _photo;
        private bool _hasPhoto;

        #endregion

        #region PROPERTIES

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        public int Buy
        {
            get { return _buy; }
            set { _buy = value; }
        }

        public int Sell
        {
            get { return _sell; }
            set { _sell = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        public bool HasPhoto
        {
            get { return _hasPhoto; }
            set { _hasPhoto = value; }
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
