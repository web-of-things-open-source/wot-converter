﻿using WotConverterCore.Models.Serializers;

namespace WotConverterCore.Models.Common
{
    public class GenericStringBool : IGenericString
    {

        private bool? boolean;
        private string? stringBoolean;

        public bool? Bool { get { return boolean; } set { stringBoolean = null; boolean = value; } }
        public string? StringBool { get { return stringBoolean; } set { boolean = null; stringBoolean = value; } }

        public static implicit operator GenericStringBool(bool boolean) => new GenericStringBool { Bool = boolean };
        public static implicit operator GenericStringBool(string stringBool) => new GenericStringBool { StringBool = stringBool };

        internal static readonly GenericStringBoolSerializer Serializer = new GenericStringBoolSerializer();
        public bool isString() => stringBoolean != null;

    }
}
