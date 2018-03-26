using System;

namespace Version_1_C
{
    [Serializable()]
    public abstract class clsWork
    {
        private string name;
        private DateTime date = DateTime.Now;
        private decimal value;

        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }
        public decimal Value { get => value; set => this.value = value; }

        public clsWork()
        {
            EditDetails();
        }

        public abstract void EditDetails();

        public static clsWork NewWork(char prChoice)
        {
            switch (char.ToUpper(prChoice))
            {
                case 'P': return new clsPainting();
                case 'S': return new clsSculpture();
                case 'H': return new clsPhotograph();
                default: return null;
            }
        }

        public override string ToString()
        {
            return Name + "\t" + Date.ToShortDateString();
        }

        //public string GetName()
        //{
        //    return Name;
        //}

        //public DateTime GetDate()
        //{
        //    return Date;
        //}

        //public decimal GetValue()
        //{
        //    return Value;
        //}
    }
}
