using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// ConversationDeletionProtectionQuery
    /// </summary>
    [DataContract]
    public partial class ConversationDeletionProtectionQuery :  IEquatable<ConversationDeletionProtectionQuery>
    {
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDeletionProtectionQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationDeletionProtectionQuery() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationDeletionProtectionQuery" /> class.
        /// </summary>
        /// <param name="ConversationIds">list of ConversationIds (required).</param>
        public ConversationDeletionProtectionQuery(List<string> ConversationIds = null)
        {
            this.ConversationIds = ConversationIds;
            
        }
        
        
        
        /// <summary>
        /// list of ConversationIds
        /// </summary>
        /// <value>list of ConversationIds</value>
        [DataMember(Name="conversationIds", EmitDefaultValue=false)]
        public List<string> ConversationIds { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationDeletionProtectionQuery {\n");
            
            sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConversationDeletionProtectionQuery);
        }

        /// <summary>
        /// Returns true if ConversationDeletionProtectionQuery instances are equal
        /// </summary>
        /// <param name="other">Instance of ConversationDeletionProtectionQuery to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConversationDeletionProtectionQuery other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ConversationIds == other.ConversationIds ||
                    this.ConversationIds != null &&
                    this.ConversationIds.SequenceEqual(other.ConversationIds)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.ConversationIds != null)
                    hash = hash * 59 + this.ConversationIds.GetHashCode();
                
                return hash;
            }
        }
    }

}
