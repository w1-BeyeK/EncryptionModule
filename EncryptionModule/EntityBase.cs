using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EncryptionModule
{
    public abstract class EntityBase : EncryptionBase
    {
        protected List<string> ProtectedValues { get; }

        public EntityBase(List<string> protectedValues)
        {
            ProtectedValues = protectedValues;
        }

        /// <summary>
        /// Encode object for serialization
        /// </summary>
        public virtual void Encode()
        {
            foreach(string value in ProtectedValues)
            {
               PropertyInfo pi = GetPropertyByName(value);
               pi.SetValue(this, Encrypt(pi.GetValue(this).ToString()));
            }
        }

        /// <summary>
        /// Decode object for deserialization
        /// </summary>
        public virtual void Decode()
        {
            foreach(string value in ProtectedValues)
            {
                PropertyInfo pi = GetPropertyByName(value);
                pi.SetValue(this, Decrypt(pi.GetValue(this).ToString()));
            }
        }

        private PropertyInfo GetPropertyByName(string name)
        {
            return GetType().GetProperty(name);
        }
    }
}
