using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackSea.Link
{
    public class EEMessage
    {
        string _Type;
        object[] _Message;

        public EEMessage(string type, object[] msg)
        {
            _Type = type;
            _Message = msg;
        }

        public object[] Message
        {
            get { return _Message; }
        }

        public string Type
        {
            get { return _Type; }
        }

        public int Count
        {
            get { return _Message.Count(); }
        }

        public object this[uint index]
        {
            get { return _Message[index]; }
        }

        public int GetInt(uint index)
        {
            return Convert.ToInt32(_Message[index]);
        }

        public double GetDouble(uint index)
        {
            return Convert.ToDouble(_Message[index]);
        }

        public bool GetBoolean(uint index)
        {
            return Convert.ToBoolean(_Message[index]);
        }

        public bool GetBool(uint index)
        {
            return Convert.ToBoolean(_Message[index]);
        }

        public string GetString(uint index)
        {
            return Convert.ToString(_Message[index]);
        }

        public byte[] GetByteArray(uint index)
        {
            return (byte[])_Message[index];
        }
    }
}
