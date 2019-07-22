using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace JsonGenomix
{
    public class File : IEnumerable<string>
    {
        private string _path;

        public string Path
        {
            get { return _path; }
            private set { _path = value; }
        }

        public File(string path) : this(path, false) { }
        public File(string path, bool clean)
        {
            _path = path;
            if (clean)
            {
                Clean();
            }
        }

        public void Clean()
        {
            StreamWriter stream = new StreamWriter(_path, false);
            stream.Close();
        }
        public string JsonString
        {
            get
            {
                string txt = "";
                foreach (string line in this)
                {
                    txt += line + "\r\n";
                }

                return txt;

            }
            set
            {
                Clean();
                this.Add(value);
            }
        }

        public void Add(string line)
        {
            StreamWriter stream = new StreamWriter(_path, true);
            stream.WriteLine(line);
            stream.Close();
        }


        public IEnumerator<string> GetEnumerator()
        {
            return new FileEnumerator(_path);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class FileEnumerator : IEnumerator<string>
    {
        private StreamReader _stream;
        private string _line;

        public FileEnumerator(string name)
        {
            _stream = new StreamReader(name);
        }

        public string Current => _line;

        object IEnumerator.Current => this.Current;

        public void Dispose()
        {
            _stream.Close();
        }

        public bool MoveNext()
        {
            if (!_stream.EndOfStream)
            {
                _line = _stream.ReadLine();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            _stream.DiscardBufferedData();
            _line = null;
        }
    }
}
