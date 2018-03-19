using System;

namespace Version_1_C {
    [Serializable()]
    public class clsArtist {
        private string _name;
        private string _speciality;
        private string _phone;

        private decimal _totalValue;

        private clsWorksList _worksList;
        private clsArtistList _artistList;

        private static frmArtist _artistDialog = new frmArtist();

        public string Name { get => _name; set => _name = value; }
        public string Speciality { get => _speciality; set => _speciality = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public decimal TotalValue { get => _totalValue;}
        public clsWorksList WorksList { get => _worksList;}
        public clsArtistList ArtistList { get => _artistList;}

        public clsArtist(clsArtistList prArtistList) {
            _worksList = new clsWorksList();
            _artistList = prArtistList;
            EditDetails();
        }

        public void EditDetails() {
            _artistDialog.SetDetails(this);
            _totalValue = _worksList.GetTotalValue();
        }

        public bool IsDuplicate(string prArtistName) {
            return _artistList.ContainsKey(prArtistName);
        }

        //public string GetKey() {
        //    return _name;
        //}

        //public decimal GetWorksValue() {
        //    return _totalValue;
        //}
    }
}
