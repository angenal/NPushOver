﻿namespace NPushOver
{
    public class InvalidKeyException : PushOverException
    {
        public string Key { get; private set; }

        public InvalidKeyException(string paramName, string key)
            : base(paramName)
        {
            this.Key = key;
        }
    }
}