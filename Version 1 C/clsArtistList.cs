using System;
using System.Collections.Generic;

namespace Version_1_C
{
    [Serializable()]
    public class clsArtistList : SortedList<string, clsArtist>
    {
        private const string _fileName = "gall.xml";

        public void EditArtist(string prKey)
        {
            clsArtist lcArtist;
            lcArtist = this[prKey];
            if (lcArtist != null)
            {
                lcArtist.EditDetails();
            } else
            {
                throw new Exception("No such artist!");
            }

        }

        public void NewArtist()
        {
            clsArtist lcArtist = new clsArtist(this);
            if (lcArtist.Name != "")
            {
                try
                {
                    Add(lcArtist.Name, lcArtist);
                } catch
                {
                    throw new Exception("Duplicate Key!");
                }
            } else
            {
                throw new Exception("Key can't be empty!");
            }
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.TotalValue;
            }
            return lcTotal;
        }
        public void Save()
        {
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_fileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                lcFormatter.Serialize(lcFileStream, this);
                lcFileStream.Close();
            } catch (Exception e)
            {
                throw new Exception(e.Message + " File Save Error");
            }
        }

        public static clsArtistList Retrieve()
        {
            clsArtistList lcArtistList;
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(_fileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            } catch (Exception e)
            {
                lcArtistList = new clsArtistList();
                throw new Exception(e.Message + " File Retrieve Error");
            }
            return lcArtistList;
        }
    }
}
