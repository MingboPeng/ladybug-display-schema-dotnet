/* 
 * Ladybug Visualization Schema
 *
 * Documentation for Ladybug visualization schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace LadybugDisplaySchema
{
    /// <summary>
    /// Generic data type representation.
    /// </summary>
    [Serializable]
    [DataContract(Name = "GenericDataType")]
    public partial class GenericDataType : OpenAPIGenBaseModel, IEquatable<GenericDataType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDataType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenericDataType() 
        { 
            // Set non-required readonly properties with defaultValue
            this.Type = "GenericDataType";
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="GenericDataType" /> class.
        /// </summary>
        /// <param name="name">Text to indicate how the data type displays. This can be more specific than the data_type. (required).</param>
        /// <param name="baseUnit">Text string for the base unit of the data type, which should be standard SI units where possible. (required).</param>
        /// <param name="dataType">dataType (default to &quot;GenericType&quot;).</param>
        /// <param name="min">Optional lower limit for the data type, values below which should be physically or mathematically impossible. (Default: -inf).</param>
        /// <param name="max">Optional upper limit for the data type, values above which should be physically or mathematically impossible. (Default: +inf).</param>
        /// <param name="abbreviation">An optional abbreviation for the data type as text. (default to &quot;&quot;).</param>
        /// <param name="unitDescr">An optional dictionary describing categories that the numerical values of the units relate to. For example: {-1: \&quot;Cold\&quot;, 0: \&quot;Neutral\&quot;, +1: \&quot;Hot\&quot;}; {0: \&quot;False\&quot;, 1: \&quot;True\&quot;}..</param>
        /// <param name="pointInTime">Boolean to note whether the data type represents conditions at a single instant in time (True) as opposed to being an average or accumulation over time (False) when it is found in hourly lists of data. (default to true).</param>
        /// <param name="cumulative">Boolean to tell whether the data type can be cumulative when it is represented over time (True) or it can only be averaged over time to be meaningful (False). Note that cumulative cannot be True when point_in_time is also True. (default to false).</param>
        public GenericDataType
        (
           string name, string baseUnit, // Required parameters
           string dataType = "GenericType", AnyOf<Default, double> min= default, AnyOf<Default, double> max= default, string abbreviation = "", Object unitDescr= default, bool pointInTime = true, bool cumulative = false// Optional parameters
        ) : base()// BaseClass
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for GenericDataType and cannot be null");
            // to ensure "baseUnit" is required (not null)
            this.BaseUnit = baseUnit ?? throw new ArgumentNullException("baseUnit is a required property for GenericDataType and cannot be null");
            // use default value if no "dataType" provided
            this.DataType = dataType ?? "GenericType";
            this.Min = min;
            this.Max = max;
            // use default value if no "abbreviation" provided
            this.Abbreviation = abbreviation ?? "";
            this.UnitDescr = unitDescr;
            this.PointInTime = pointInTime;
            this.Cumulative = cumulative;

            // Set non-required readonly properties with defaultValue
            this.Type = "GenericDataType";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(GenericDataType))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "GenericDataType";

        /// <summary>
        /// Text to indicate how the data type displays. This can be more specific than the data_type.
        /// </summary>
        /// <value>Text to indicate how the data type displays. This can be more specific than the data_type.</value>
        [DataMember(Name = "name", IsRequired = true)]
        public string Name { get; set; } 
        /// <summary>
        /// Text string for the base unit of the data type, which should be standard SI units where possible.
        /// </summary>
        /// <value>Text string for the base unit of the data type, which should be standard SI units where possible.</value>
        [DataMember(Name = "base_unit", IsRequired = true)]
        public string BaseUnit { get; set; } 
        /// <summary>
        /// Gets or Sets DataType
        /// </summary>
        [DataMember(Name = "data_type")]
        public string DataType { get; set; }  = "GenericType";
        /// <summary>
        /// Optional lower limit for the data type, values below which should be physically or mathematically impossible. (Default: -inf)
        /// </summary>
        /// <value>Optional lower limit for the data type, values below which should be physically or mathematically impossible. (Default: -inf)</value>
        [DataMember(Name = "min")]
        public AnyOf<Default, double> Min { get; set; } 
        /// <summary>
        /// Optional upper limit for the data type, values above which should be physically or mathematically impossible. (Default: +inf)
        /// </summary>
        /// <value>Optional upper limit for the data type, values above which should be physically or mathematically impossible. (Default: +inf)</value>
        [DataMember(Name = "max")]
        public AnyOf<Default, double> Max { get; set; } 
        /// <summary>
        /// An optional abbreviation for the data type as text.
        /// </summary>
        /// <value>An optional abbreviation for the data type as text.</value>
        [DataMember(Name = "abbreviation")]
        public string Abbreviation { get; set; }  = "";
        /// <summary>
        /// An optional dictionary describing categories that the numerical values of the units relate to. For example: {-1: \&quot;Cold\&quot;, 0: \&quot;Neutral\&quot;, +1: \&quot;Hot\&quot;}; {0: \&quot;False\&quot;, 1: \&quot;True\&quot;}.
        /// </summary>
        /// <value>An optional dictionary describing categories that the numerical values of the units relate to. For example: {-1: \&quot;Cold\&quot;, 0: \&quot;Neutral\&quot;, +1: \&quot;Hot\&quot;}; {0: \&quot;False\&quot;, 1: \&quot;True\&quot;}.</value>
        [DataMember(Name = "unit_descr")]
        public Object UnitDescr { get; set; } 
        /// <summary>
        /// Boolean to note whether the data type represents conditions at a single instant in time (True) as opposed to being an average or accumulation over time (False) when it is found in hourly lists of data.
        /// </summary>
        /// <value>Boolean to note whether the data type represents conditions at a single instant in time (True) as opposed to being an average or accumulation over time (False) when it is found in hourly lists of data.</value>
        [DataMember(Name = "point_in_time")]
        public bool PointInTime { get; set; }  = true;
        /// <summary>
        /// Boolean to tell whether the data type can be cumulative when it is represented over time (True) or it can only be averaged over time to be meaningful (False). Note that cumulative cannot be True when point_in_time is also True.
        /// </summary>
        /// <value>Boolean to tell whether the data type can be cumulative when it is represented over time (True) or it can only be averaged over time to be meaningful (False). Note that cumulative cannot be True when point_in_time is also True.</value>
        [DataMember(Name = "cumulative")]
        public bool Cumulative { get; set; }  = false;

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "GenericDataType";
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString(bool detailed)
        {
            if (!detailed)
                return this.ToString();
            
            var sb = new StringBuilder();
            sb.Append("GenericDataType:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  Name: ").Append(this.Name).Append("\n");
            sb.Append("  BaseUnit: ").Append(this.BaseUnit).Append("\n");
            sb.Append("  DataType: ").Append(this.DataType).Append("\n");
            sb.Append("  Min: ").Append(this.Min).Append("\n");
            sb.Append("  Max: ").Append(this.Max).Append("\n");
            sb.Append("  Abbreviation: ").Append(this.Abbreviation).Append("\n");
            sb.Append("  UnitDescr: ").Append(this.UnitDescr).Append("\n");
            sb.Append("  PointInTime: ").Append(this.PointInTime).Append("\n");
            sb.Append("  Cumulative: ").Append(this.Cumulative).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>GenericDataType object</returns>
        public static GenericDataType FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<GenericDataType>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>GenericDataType object</returns>
        public virtual GenericDataType DuplicateGenericDataType()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateGenericDataType();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateGenericDataType();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as GenericDataType);
        }

        /// <summary>
        /// Returns true if GenericDataType instances are equal
        /// </summary>
        /// <param name="input">Instance of GenericDataType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenericDataType input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Name, input.Name) && 
                    Extension.Equals(this.BaseUnit, input.BaseUnit) && 
                    Extension.Equals(this.DataType, input.DataType) && 
                    Extension.Equals(this.Min, input.Min) && 
                    Extension.Equals(this.Max, input.Max) && 
                    Extension.Equals(this.Abbreviation, input.Abbreviation) && 
                    Extension.Equals(this.UnitDescr, input.UnitDescr) && 
                    Extension.Equals(this.PointInTime, input.PointInTime) && 
                    Extension.Equals(this.Cumulative, input.Cumulative) && 
                    Extension.Equals(this.Type, input.Type);
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.BaseUnit != null)
                    hashCode = hashCode * 59 + this.BaseUnit.GetHashCode();
                if (this.DataType != null)
                    hashCode = hashCode * 59 + this.DataType.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Abbreviation != null)
                    hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                if (this.UnitDescr != null)
                    hashCode = hashCode * 59 + this.UnitDescr.GetHashCode();
                if (this.PointInTime != null)
                    hashCode = hashCode * 59 + this.PointInTime.GetHashCode();
                if (this.Cumulative != null)
                    hashCode = hashCode * 59 + this.Cumulative.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            foreach(var x in base.BaseValidate(validationContext)) yield return x;

            
            // DataType (string) pattern
            Regex regexDataType = new Regex(@"^GenericType$", RegexOptions.CultureInvariant);
            if (this.DataType != null && false == regexDataType.Match(this.DataType).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DataType, must match a pattern of " + regexDataType, new [] { "DataType" });
            }


            
            // Type (string) pattern
            Regex regexType = new Regex(@"^GenericDataType$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}