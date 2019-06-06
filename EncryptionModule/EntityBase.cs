using EncryptionModule.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EncryptionModule
{
    public abstract class EntityBase : EncryptionBase
    {
        protected List<string> protectedValues;
        
        /// <summary>
        /// Encode object for serialization
        /// </summary>
        public virtual void Encode()
        {
            if (protectedValues is null || protectedValues.Count < 1)
                throw new NoPropertiesException("Protected values has no items");

            foreach(string value in protectedValues)
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
            if (protectedValues is null || protectedValues.Count < 1)
                throw new NoPropertiesException("Protected values has no items");
            
            foreach (string value in protectedValues)
            {
                PropertyInfo pi = GetPropertyByName(value);
                pi.SetValue(this, Decrypt(pi.GetValue(this).ToString()));
            }
        }

        private PropertyInfo GetPropertyByName(string name)
        {
            PropertyInfo pi = GetType().GetProperty(name);

            if (pi is null)
                throw new ArgumentNullException(string.Format("Property with name {0} was not found", name));
            else
                return pi;
        }
    }
}
