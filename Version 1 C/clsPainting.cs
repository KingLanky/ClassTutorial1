using System;

namespace Version_1_C {
    [Serializable()]
    public class clsPainting : clsWork {
        private float _width;
        private float _height;
        private string _type;

        [NonSerialized()]
        private static frmPainting _PaintDialog;

        public float Width { get => _width; set => _width = value; }
        public float Height { get => _height; set => _height = value; }
        public string Type { get => _type; set => _type = value; }

        public override void EditDetails() {
            if (_PaintDialog == null)
                _PaintDialog = new frmPainting();
            _PaintDialog.SetDetails(this);
        }
    }
}
