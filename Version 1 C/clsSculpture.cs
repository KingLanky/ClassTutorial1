using System;

namespace Version_1_C {
    [Serializable()]
    public class clsSculpture : clsWork {
        private float _weight;
        private string _material;

        [NonSerialized()]
        private static frmSculpture _SculptDialog;

        public float Weight { get => _weight; set => _weight = value; }
        public string Material { get => _material; set => _material = value; }

        public override void EditDetails() {
            if (_SculptDialog == null)
                _SculptDialog = new frmSculpture();
            _SculptDialog.SetDetails(this);
        }
    }
}
