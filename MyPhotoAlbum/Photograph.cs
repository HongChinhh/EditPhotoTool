using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;


namespace Manning.MyPhotoAlbum
{
    /// <summary>
    /// the photograph class represents a photographic
    /// image stored in the file system
    /// </summary>
    public class Photograph : IDisposable, IFormattable
    {
        private string _fileName;
        public string Filename
        {
            get { return this._fileName; }
        }
        
        private Bitmap _bitmap;

        public Bitmap Image
        {
            get
            {
                if (_bitmap == null)
                    _bitmap = new Bitmap(_fileName);
                return _bitmap;
            }
        }

        private string _caption = "";
        public string Caption
        {
            get { return _caption; }
            set
            {
                if (_caption != value)
                {
                    _caption = value;
                    HasChanged = true;
                }
            }
        }

        private string _photographer = "";
        public string Photographer
        {
            get { return _photographer; }
            set
            {
                if (_photographer != value)
                {
                    _photographer = value;
                    HasChanged = true;
                }
            }
        }

        private DateTime _dateTaken = DateTime.Now;
        public DateTime DateTaken
        {
            get { return _dateTaken; }
            set
            {
                if (_dateTaken != value)
                {
                    _dateTaken = value;
                    HasChanged = true;
                }
            }
        }

        private string _notes = "";
        public string Note
        {
            get { return _notes; }
            set
            {
                if (_notes != value)
                {
                    _notes = value;
                    HasChanged = true;
                }
            }
        }

        private bool _hasChanged = true;
        public bool HasChanged
        {
            get { return _hasChanged; }
            set { _hasChanged = value; }
        }
        public Photograph(string fileName)
        {
            _fileName = fileName;
            _bitmap = null;
            _caption = System.IO.Path.GetFileNameWithoutExtension(fileName);
        }
        public override bool Equals(object obj)
        {
            if (obj is Photograph)
            {
                Photograph p = (Photograph)obj;
                return string.Equals(Filename, p.Filename, StringComparison.InvariantCultureIgnoreCase);
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Filename.ToLowerInvariant().GetHashCode();
        }
        public override string ToString()
        {
            return Filename;
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                format = "f";

            char first = format.ToLower()[0];
            if (format.Length == 1)
            {
                switch (first)
                {
                    case 'c': return Caption;
                    case 'd': return DateTaken.ToShortDateString();
                    case 'f': return Filename;
                }
            }
            else if (first == 'd')
                return DateTaken.ToString(format.Substring(1), formatProvider);

            throw new FormatException();
        }

        public string ToString( string format)
        {
            return ToString(format, null);
        }
        public string ToString(IFormatProvider fp)
        {
            return ToString( null,fp);
        }

        public void ReleaseImage()
        {
            if (_bitmap != null)
            {
                _bitmap.Dispose();
                _bitmap = null;
            }
        }

        
        public void Dispose()
        {
            ReleaseImage();
        }

        
    }
}
