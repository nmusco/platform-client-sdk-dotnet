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
    /// Site
    /// </summary>
    [DataContract]
    public partial class Site :  IEquatable<Site>
    {
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates if the resource is active, inactive, or deleted.
        /// </summary>
        /// <value>Indicates if the resource is active, inactive, or deleted.</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Active for "active"
            /// </summary>
            [EnumMember(Value = "active")]
            Active,
            
            /// <summary>
            /// Enum Inactive for "inactive"
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive,
            
            /// <summary>
            /// Enum Deleted for "deleted"
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Indicates if the resource is active, inactive, or deleted.
        /// </summary>
        /// <value>Indicates if the resource is active, inactive, or deleted.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Site" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Site() { }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Site" /> class.
        /// </summary>
        /// <param name="Name">The name of the entity. (required).</param>
        /// <param name="Description">The resource&#39;s description..</param>
        /// <param name="Version">The current version of the resource..</param>
        /// <param name="DateCreated">The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateModified">The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ModifiedBy">The ID of the user that last modified the resource..</param>
        /// <param name="CreatedBy">The ID of the user that created the resource..</param>
        /// <param name="ModifiedByApp">The application that last modified the resource..</param>
        /// <param name="CreatedByApp">The application that created the resource..</param>
        /// <param name="PrimarySites">PrimarySites.</param>
        /// <param name="SecondarySites">SecondarySites.</param>
        /// <param name="PrimaryEdges">PrimaryEdges.</param>
        /// <param name="SecondaryEdges">SecondaryEdges.</param>
        /// <param name="Addresses">Addresses.</param>
        /// <param name="Edges">Edges.</param>
        /// <param name="EdgeAutoUpdateConfig">Recurrance rule, time zone, and start/end settings for automatic edge updates for this site.</param>
        /// <param name="MediaRegionsUseLatencyBased">MediaRegionsUseLatencyBased.</param>
        /// <param name="Location">Location (required).</param>
        /// <param name="Managed">Managed.</param>
        /// <param name="NtpSettings">Network Time Protocol settings for the site.</param>
        public Site(string Name = null, string Description = null, int? Version = null, DateTime? DateCreated = null, DateTime? DateModified = null, string ModifiedBy = null, string CreatedBy = null, string ModifiedByApp = null, string CreatedByApp = null, List<DomainEntityRef> PrimarySites = null, List<DomainEntityRef> SecondarySites = null, List<Edge> PrimaryEdges = null, List<Edge> SecondaryEdges = null, List<Contact> Addresses = null, List<Edge> Edges = null, EdgeAutoUpdateConfig EdgeAutoUpdateConfig = null, bool? MediaRegionsUseLatencyBased = null, LocationDefinition Location = null, bool? Managed = null, NTPSettings NtpSettings = null)
        {
            this.Name = Name;
            this.Description = Description;
            this.Version = Version;
            this.DateCreated = DateCreated;
            this.DateModified = DateModified;
            this.ModifiedBy = ModifiedBy;
            this.CreatedBy = CreatedBy;
            this.ModifiedByApp = ModifiedByApp;
            this.CreatedByApp = CreatedByApp;
            this.PrimarySites = PrimarySites;
            this.SecondarySites = SecondarySites;
            this.PrimaryEdges = PrimaryEdges;
            this.SecondaryEdges = SecondaryEdges;
            this.Addresses = Addresses;
            this.Edges = Edges;
            this.EdgeAutoUpdateConfig = EdgeAutoUpdateConfig;
            this.MediaRegionsUseLatencyBased = MediaRegionsUseLatencyBased;
            this.Location = Location;
            this.Managed = Managed;
            this.NtpSettings = NtpSettings;
            
        }
        
        
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        
        
        
        /// <summary>
        /// The name of the entity.
        /// </summary>
        /// <value>The name of the entity.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        
        
        
        /// <summary>
        /// The resource&#39;s description.
        /// </summary>
        /// <value>The resource&#39;s description.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        
        
        
        /// <summary>
        /// The current version of the resource.
        /// </summary>
        /// <value>The current version of the resource.</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public int? Version { get; set; }
        
        
        
        /// <summary>
        /// The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the resource was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
        
        
        
        /// <summary>
        /// The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date of the last modification to the resource. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }
        
        
        
        /// <summary>
        /// The ID of the user that last modified the resource.
        /// </summary>
        /// <value>The ID of the user that last modified the resource.</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }
        
        
        
        /// <summary>
        /// The ID of the user that created the resource.
        /// </summary>
        /// <value>The ID of the user that created the resource.</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }
        
        
        
        
        
        /// <summary>
        /// The application that last modified the resource.
        /// </summary>
        /// <value>The application that last modified the resource.</value>
        [DataMember(Name="modifiedByApp", EmitDefaultValue=false)]
        public string ModifiedByApp { get; set; }
        
        
        
        /// <summary>
        /// The application that created the resource.
        /// </summary>
        /// <value>The application that created the resource.</value>
        [DataMember(Name="createdByApp", EmitDefaultValue=false)]
        public string CreatedByApp { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PrimarySites
        /// </summary>
        [DataMember(Name="primarySites", EmitDefaultValue=false)]
        public List<DomainEntityRef> PrimarySites { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SecondarySites
        /// </summary>
        [DataMember(Name="secondarySites", EmitDefaultValue=false)]
        public List<DomainEntityRef> SecondarySites { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets PrimaryEdges
        /// </summary>
        [DataMember(Name="primaryEdges", EmitDefaultValue=false)]
        public List<Edge> PrimaryEdges { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets SecondaryEdges
        /// </summary>
        [DataMember(Name="secondaryEdges", EmitDefaultValue=false)]
        public List<Edge> SecondaryEdges { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<Contact> Addresses { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Edges
        /// </summary>
        [DataMember(Name="edges", EmitDefaultValue=false)]
        public List<Edge> Edges { get; set; }
        
        
        
        /// <summary>
        /// Recurrance rule, time zone, and start/end settings for automatic edge updates for this site
        /// </summary>
        /// <value>Recurrance rule, time zone, and start/end settings for automatic edge updates for this site</value>
        [DataMember(Name="edgeAutoUpdateConfig", EmitDefaultValue=false)]
        public EdgeAutoUpdateConfig EdgeAutoUpdateConfig { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets MediaRegionsUseLatencyBased
        /// </summary>
        [DataMember(Name="mediaRegionsUseLatencyBased", EmitDefaultValue=false)]
        public bool? MediaRegionsUseLatencyBased { get; set; }
        
        
        
        /// <summary>
        /// Location
        /// </summary>
        /// <value>Location</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public LocationDefinition Location { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Managed
        /// </summary>
        [DataMember(Name="managed", EmitDefaultValue=false)]
        public bool? Managed { get; set; }
        
        
        
        /// <summary>
        /// Network Time Protocol settings for the site
        /// </summary>
        /// <value>Network Time Protocol settings for the site</value>
        [DataMember(Name="ntpSettings", EmitDefaultValue=false)]
        public NTPSettings NtpSettings { get; set; }
        
        
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Site {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ModifiedByApp: ").Append(ModifiedByApp).Append("\n");
            sb.Append("  CreatedByApp: ").Append(CreatedByApp).Append("\n");
            sb.Append("  PrimarySites: ").Append(PrimarySites).Append("\n");
            sb.Append("  SecondarySites: ").Append(SecondarySites).Append("\n");
            sb.Append("  PrimaryEdges: ").Append(PrimaryEdges).Append("\n");
            sb.Append("  SecondaryEdges: ").Append(SecondaryEdges).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Edges: ").Append(Edges).Append("\n");
            sb.Append("  EdgeAutoUpdateConfig: ").Append(EdgeAutoUpdateConfig).Append("\n");
            sb.Append("  MediaRegionsUseLatencyBased: ").Append(MediaRegionsUseLatencyBased).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  Managed: ").Append(Managed).Append("\n");
            sb.Append("  NtpSettings: ").Append(NtpSettings).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as Site);
        }

        /// <summary>
        /// Returns true if Site instances are equal
        /// </summary>
        /// <param name="other">Instance of Site to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Site other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) &&
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateModified == other.DateModified ||
                    this.DateModified != null &&
                    this.DateModified.Equals(other.DateModified)
                ) &&
                (
                    this.ModifiedBy == other.ModifiedBy ||
                    this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(other.ModifiedBy)
                ) &&
                (
                    this.CreatedBy == other.CreatedBy ||
                    this.CreatedBy != null &&
                    this.CreatedBy.Equals(other.CreatedBy)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ModifiedByApp == other.ModifiedByApp ||
                    this.ModifiedByApp != null &&
                    this.ModifiedByApp.Equals(other.ModifiedByApp)
                ) &&
                (
                    this.CreatedByApp == other.CreatedByApp ||
                    this.CreatedByApp != null &&
                    this.CreatedByApp.Equals(other.CreatedByApp)
                ) &&
                (
                    this.PrimarySites == other.PrimarySites ||
                    this.PrimarySites != null &&
                    this.PrimarySites.SequenceEqual(other.PrimarySites)
                ) &&
                (
                    this.SecondarySites == other.SecondarySites ||
                    this.SecondarySites != null &&
                    this.SecondarySites.SequenceEqual(other.SecondarySites)
                ) &&
                (
                    this.PrimaryEdges == other.PrimaryEdges ||
                    this.PrimaryEdges != null &&
                    this.PrimaryEdges.SequenceEqual(other.PrimaryEdges)
                ) &&
                (
                    this.SecondaryEdges == other.SecondaryEdges ||
                    this.SecondaryEdges != null &&
                    this.SecondaryEdges.SequenceEqual(other.SecondaryEdges)
                ) &&
                (
                    this.Addresses == other.Addresses ||
                    this.Addresses != null &&
                    this.Addresses.SequenceEqual(other.Addresses)
                ) &&
                (
                    this.Edges == other.Edges ||
                    this.Edges != null &&
                    this.Edges.SequenceEqual(other.Edges)
                ) &&
                (
                    this.EdgeAutoUpdateConfig == other.EdgeAutoUpdateConfig ||
                    this.EdgeAutoUpdateConfig != null &&
                    this.EdgeAutoUpdateConfig.Equals(other.EdgeAutoUpdateConfig)
                ) &&
                (
                    this.MediaRegionsUseLatencyBased == other.MediaRegionsUseLatencyBased ||
                    this.MediaRegionsUseLatencyBased != null &&
                    this.MediaRegionsUseLatencyBased.Equals(other.MediaRegionsUseLatencyBased)
                ) &&
                (
                    this.Location == other.Location ||
                    this.Location != null &&
                    this.Location.Equals(other.Location)
                ) &&
                (
                    this.Managed == other.Managed ||
                    this.Managed != null &&
                    this.Managed.Equals(other.Managed)
                ) &&
                (
                    this.NtpSettings == other.NtpSettings ||
                    this.NtpSettings != null &&
                    this.NtpSettings.Equals(other.NtpSettings)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateModified != null)
                    hash = hash * 59 + this.DateModified.GetHashCode();
                
                if (this.ModifiedBy != null)
                    hash = hash * 59 + this.ModifiedBy.GetHashCode();
                
                if (this.CreatedBy != null)
                    hash = hash * 59 + this.CreatedBy.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.ModifiedByApp != null)
                    hash = hash * 59 + this.ModifiedByApp.GetHashCode();
                
                if (this.CreatedByApp != null)
                    hash = hash * 59 + this.CreatedByApp.GetHashCode();
                
                if (this.PrimarySites != null)
                    hash = hash * 59 + this.PrimarySites.GetHashCode();
                
                if (this.SecondarySites != null)
                    hash = hash * 59 + this.SecondarySites.GetHashCode();
                
                if (this.PrimaryEdges != null)
                    hash = hash * 59 + this.PrimaryEdges.GetHashCode();
                
                if (this.SecondaryEdges != null)
                    hash = hash * 59 + this.SecondaryEdges.GetHashCode();
                
                if (this.Addresses != null)
                    hash = hash * 59 + this.Addresses.GetHashCode();
                
                if (this.Edges != null)
                    hash = hash * 59 + this.Edges.GetHashCode();
                
                if (this.EdgeAutoUpdateConfig != null)
                    hash = hash * 59 + this.EdgeAutoUpdateConfig.GetHashCode();
                
                if (this.MediaRegionsUseLatencyBased != null)
                    hash = hash * 59 + this.MediaRegionsUseLatencyBased.GetHashCode();
                
                if (this.Location != null)
                    hash = hash * 59 + this.Location.GetHashCode();
                
                if (this.Managed != null)
                    hash = hash * 59 + this.Managed.GetHashCode();
                
                if (this.NtpSettings != null)
                    hash = hash * 59 + this.NtpSettings.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }
    }

}
