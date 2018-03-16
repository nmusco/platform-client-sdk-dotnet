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
    /// Question
    /// </summary>
    [DataContract]
    public partial class Question :  IEquatable<Question>
    {
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Multiplechoicequestion for "multipleChoiceQuestion"
            /// </summary>
            [EnumMember(Value = "multipleChoiceQuestion")]
            Multiplechoicequestion,
            
            /// <summary>
            /// Enum Freetextquestion for "freeTextQuestion"
            /// </summary>
            [EnumMember(Value = "freeTextQuestion")]
            Freetextquestion,
            
            /// <summary>
            /// Enum Npsquestion for "npsQuestion"
            /// </summary>
            [EnumMember(Value = "npsQuestion")]
            Npsquestion,
            
            /// <summary>
            /// Enum Readonlytextblockquestion for "readOnlyTextBlockQuestion"
            /// </summary>
            [EnumMember(Value = "readOnlyTextBlockQuestion")]
            Readonlytextblockquestion
        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Question" /> class.
        /// </summary>
        
        
        /// <param name="Id">Id.</param>
        
        
        
        /// <param name="Text">Text.</param>
        
        
        
        /// <param name="HelpText">HelpText.</param>
        
        
        
        /// <param name="Type">Type.</param>
        
        
        
        /// <param name="NaEnabled">NaEnabled.</param>
        
        
        
        /// <param name="CommentsRequired">CommentsRequired.</param>
        
        
        
        /// <param name="VisibilityCondition">VisibilityCondition.</param>
        
        
        
        /// <param name="AnswerOptions">Options from which to choose an answer for this question. Only used by Multiple Choice type questions..</param>
        
        
        
        /// <param name="MaxResponseCharacters">How many characters are allowed in the text response to this question. Used by NPS and Free Text question types..</param>
        
        
        
        /// <param name="ExplanationPrompt">Prompt for details explaining the chosen NPS score. Used by NPS questions..</param>
        
        
        
        /// <param name="IsCritical">IsCritical.</param>
        
        
        
        /// <param name="IsKill">IsKill.</param>
        
        
        public Question(string Id = null, string Text = null, string HelpText = null, TypeEnum? Type = null, bool? NaEnabled = null, bool? CommentsRequired = null, VisibilityCondition VisibilityCondition = null, List<AnswerOption> AnswerOptions = null, int? MaxResponseCharacters = null, string ExplanationPrompt = null, bool? IsCritical = null, bool? IsKill = null)
        {
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
this.Id = Id;
            
            
            
            
            
            
            
            
this.Text = Text;
            
            
            
            
            
            
            
            
this.HelpText = HelpText;
            
            
            
            
            
            
            
            
this.Type = Type;
            
            
            
            
            
            
            
            
this.NaEnabled = NaEnabled;
            
            
            
            
            
            
            
            
this.CommentsRequired = CommentsRequired;
            
            
            
            
            
            
            
            
this.VisibilityCondition = VisibilityCondition;
            
            
            
            
            
            
            
            
this.AnswerOptions = AnswerOptions;
            
            
            
            
            
            
            
            
this.MaxResponseCharacters = MaxResponseCharacters;
            
            
            
            
            
            
            
            
this.ExplanationPrompt = ExplanationPrompt;
            
            
            
            
            
            
            
            
this.IsCritical = IsCritical;
            
            
            
            
            
            
            
            
this.IsKill = IsKill;
            
            
            
            
        }
        
        
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets HelpText
        /// </summary>
        [DataMember(Name="helpText", EmitDefaultValue=false)]
        public string HelpText { get; set; }
        
        
        
        
        
        /// <summary>
        /// Gets or Sets NaEnabled
        /// </summary>
        [DataMember(Name="naEnabled", EmitDefaultValue=false)]
        public bool? NaEnabled { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets CommentsRequired
        /// </summary>
        [DataMember(Name="commentsRequired", EmitDefaultValue=false)]
        public bool? CommentsRequired { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets VisibilityCondition
        /// </summary>
        [DataMember(Name="visibilityCondition", EmitDefaultValue=false)]
        public VisibilityCondition VisibilityCondition { get; set; }
        
        
        
        /// <summary>
        /// Options from which to choose an answer for this question. Only used by Multiple Choice type questions.
        /// </summary>
        /// <value>Options from which to choose an answer for this question. Only used by Multiple Choice type questions.</value>
        [DataMember(Name="answerOptions", EmitDefaultValue=false)]
        public List<AnswerOption> AnswerOptions { get; set; }
        
        
        
        /// <summary>
        /// How many characters are allowed in the text response to this question. Used by NPS and Free Text question types.
        /// </summary>
        /// <value>How many characters are allowed in the text response to this question. Used by NPS and Free Text question types.</value>
        [DataMember(Name="maxResponseCharacters", EmitDefaultValue=false)]
        public int? MaxResponseCharacters { get; set; }
        
        
        
        /// <summary>
        /// Prompt for details explaining the chosen NPS score. Used by NPS questions.
        /// </summary>
        /// <value>Prompt for details explaining the chosen NPS score. Used by NPS questions.</value>
        [DataMember(Name="explanationPrompt", EmitDefaultValue=false)]
        public string ExplanationPrompt { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IsCritical
        /// </summary>
        [DataMember(Name="isCritical", EmitDefaultValue=false)]
        public bool? IsCritical { get; set; }
        
        
        
        /// <summary>
        /// Gets or Sets IsKill
        /// </summary>
        [DataMember(Name="isKill", EmitDefaultValue=false)]
        public bool? IsKill { get; set; }
        
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Question {\n");
            
            sb.Append("  Id: ").Append(Id).Append("\n");
            
            sb.Append("  Text: ").Append(Text).Append("\n");
            
            sb.Append("  HelpText: ").Append(HelpText).Append("\n");
            
            sb.Append("  Type: ").Append(Type).Append("\n");
            
            sb.Append("  NaEnabled: ").Append(NaEnabled).Append("\n");
            
            sb.Append("  CommentsRequired: ").Append(CommentsRequired).Append("\n");
            
            sb.Append("  VisibilityCondition: ").Append(VisibilityCondition).Append("\n");
            
            sb.Append("  AnswerOptions: ").Append(AnswerOptions).Append("\n");
            
            sb.Append("  MaxResponseCharacters: ").Append(MaxResponseCharacters).Append("\n");
            
            sb.Append("  ExplanationPrompt: ").Append(ExplanationPrompt).Append("\n");
            
            sb.Append("  IsCritical: ").Append(IsCritical).Append("\n");
            
            sb.Append("  IsKill: ").Append(IsKill).Append("\n");
            
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
            return this.Equals(obj as Question);
        }

        /// <summary>
        /// Returns true if Question instances are equal
        /// </summary>
        /// <param name="other">Instance of Question to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Question other)
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
                    this.Text == other.Text ||
                    this.Text != null &&
                    this.Text.Equals(other.Text)
                ) &&
                (
                    this.HelpText == other.HelpText ||
                    this.HelpText != null &&
                    this.HelpText.Equals(other.HelpText)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.NaEnabled == other.NaEnabled ||
                    this.NaEnabled != null &&
                    this.NaEnabled.Equals(other.NaEnabled)
                ) &&
                (
                    this.CommentsRequired == other.CommentsRequired ||
                    this.CommentsRequired != null &&
                    this.CommentsRequired.Equals(other.CommentsRequired)
                ) &&
                (
                    this.VisibilityCondition == other.VisibilityCondition ||
                    this.VisibilityCondition != null &&
                    this.VisibilityCondition.Equals(other.VisibilityCondition)
                ) &&
                (
                    this.AnswerOptions == other.AnswerOptions ||
                    this.AnswerOptions != null &&
                    this.AnswerOptions.SequenceEqual(other.AnswerOptions)
                ) &&
                (
                    this.MaxResponseCharacters == other.MaxResponseCharacters ||
                    this.MaxResponseCharacters != null &&
                    this.MaxResponseCharacters.Equals(other.MaxResponseCharacters)
                ) &&
                (
                    this.ExplanationPrompt == other.ExplanationPrompt ||
                    this.ExplanationPrompt != null &&
                    this.ExplanationPrompt.Equals(other.ExplanationPrompt)
                ) &&
                (
                    this.IsCritical == other.IsCritical ||
                    this.IsCritical != null &&
                    this.IsCritical.Equals(other.IsCritical)
                ) &&
                (
                    this.IsKill == other.IsKill ||
                    this.IsKill != null &&
                    this.IsKill.Equals(other.IsKill)
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
                
                if (this.Text != null)
                    hash = hash * 59 + this.Text.GetHashCode();
                
                if (this.HelpText != null)
                    hash = hash * 59 + this.HelpText.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.NaEnabled != null)
                    hash = hash * 59 + this.NaEnabled.GetHashCode();
                
                if (this.CommentsRequired != null)
                    hash = hash * 59 + this.CommentsRequired.GetHashCode();
                
                if (this.VisibilityCondition != null)
                    hash = hash * 59 + this.VisibilityCondition.GetHashCode();
                
                if (this.AnswerOptions != null)
                    hash = hash * 59 + this.AnswerOptions.GetHashCode();
                
                if (this.MaxResponseCharacters != null)
                    hash = hash * 59 + this.MaxResponseCharacters.GetHashCode();
                
                if (this.ExplanationPrompt != null)
                    hash = hash * 59 + this.ExplanationPrompt.GetHashCode();
                
                if (this.IsCritical != null)
                    hash = hash * 59 + this.IsCritical.GetHashCode();
                
                if (this.IsKill != null)
                    hash = hash * 59 + this.IsKill.GetHashCode();
                
                return hash;
            }
        }
    }

}
