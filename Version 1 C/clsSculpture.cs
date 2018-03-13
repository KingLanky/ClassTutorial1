using System;
using System.Windows.Forms;

namespace Version_1_C {
    [Serializable()]
    public class clsSculpture : clsWork {
        private float _weight;
        private string _material;

        [NonSerialized()]
        private static frmSculpture sculptDialog;

        public override void EditDetails() {
            if (sculptDialog == null) {
                sculptDialog = new frmSculpture();
            }
            sculptDialog.SetDetails(_Name, _date, _value, _weight, _material);
            if (sculptDialog.ShowDialog() == DialogResult.OK) {
                sculptDialog.GetDetails(ref _Name, ref _date, ref _value, ref _weight, ref _material);
            }
        }
    }
}
