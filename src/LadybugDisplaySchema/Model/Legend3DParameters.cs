/* 
 * Ladybug Visualization Schema
 *
 * Documentation for Ladybug visualization schema
 *
 * Contact: info@ladybug.tools
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

extern alias LBTNewtonsoft; using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using LBTNewtonsoft::Newtonsoft.Json;
using LBTNewtonsoft::Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;


namespace LadybugDisplaySchema
{
    /// <summary>
    /// Base class for all objects that are not extensible with additional keys.
    /// </summary>
    [Serializable]
    [DataContract(Name = "Legend3DParameters")]
    public partial class Legend3DParameters : OpenAPIGenBaseModel, IEquatable<Legend3DParameters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Legend3DParameters" /> class.
        /// </summary>
        /// <param name="basePlane">A Ladybug Plane object to note the starting position from where the legend will be generated. The default is the world XY plane at origin (0, 0, 0) unless the legend is assigned to a specific geometry, in which case the origin is in the lower right corner of the geometry bounding box for vertical legends and the upper right corner for horizontal legends..</param>
        /// <param name="segmentHeight">A number to set the height for each of the legend segments. The default is 1 unless the legend is assigned to a specific geometry, in which case it is automatically set to a value on an appropriate scale (some fraction of the bounding box around the geometry)..</param>
        /// <param name="segmentWidth">A number to set the width for each of the legend segments. The default is 1 unless the legend is assigned to a specific geometry, in which case it is automatically set to a value on an appropriate scale (some fraction of the bounding box around the geometry)..</param>
        /// <param name="textHeight">A number to set the height for the legend text. Default is 1/3 of the segment_height..</param>
        public Legend3DParameters
        (
            // Required parameters
           Plane basePlane= default, AnyOf<Default, double> segmentHeight= default, AnyOf<Default, double> segmentWidth= default, AnyOf<Default, double> textHeight= default// Optional parameters
        ) : base()// BaseClass
        {
            this.BasePlane = basePlane;
            this.SegmentHeight = segmentHeight;
            this.SegmentWidth = segmentWidth;
            this.TextHeight = textHeight;

            // Set non-required readonly properties with defaultValue
            this.Type = "Legend3DParameters";

            // check if object is valid, only check for inherited class
            if (this.GetType() == typeof(Legend3DParameters))
                this.IsValid(throwException: true);
        }

        //============================================== is ReadOnly 
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type")]
        public override string Type { get; protected set; }  = "Legend3DParameters";

        /// <summary>
        /// A Ladybug Plane object to note the starting position from where the legend will be generated. The default is the world XY plane at origin (0, 0, 0) unless the legend is assigned to a specific geometry, in which case the origin is in the lower right corner of the geometry bounding box for vertical legends and the upper right corner for horizontal legends.
        /// </summary>
        /// <value>A Ladybug Plane object to note the starting position from where the legend will be generated. The default is the world XY plane at origin (0, 0, 0) unless the legend is assigned to a specific geometry, in which case the origin is in the lower right corner of the geometry bounding box for vertical legends and the upper right corner for horizontal legends.</value>
        [DataMember(Name = "base_plane")]
        public Plane BasePlane { get; set; } 
        /// <summary>
        /// A number to set the height for each of the legend segments. The default is 1 unless the legend is assigned to a specific geometry, in which case it is automatically set to a value on an appropriate scale (some fraction of the bounding box around the geometry).
        /// </summary>
        /// <value>A number to set the height for each of the legend segments. The default is 1 unless the legend is assigned to a specific geometry, in which case it is automatically set to a value on an appropriate scale (some fraction of the bounding box around the geometry).</value>
        [DataMember(Name = "segment_height")]
        public AnyOf<Default, double> SegmentHeight { get; set; } 
        /// <summary>
        /// A number to set the width for each of the legend segments. The default is 1 unless the legend is assigned to a specific geometry, in which case it is automatically set to a value on an appropriate scale (some fraction of the bounding box around the geometry).
        /// </summary>
        /// <value>A number to set the width for each of the legend segments. The default is 1 unless the legend is assigned to a specific geometry, in which case it is automatically set to a value on an appropriate scale (some fraction of the bounding box around the geometry).</value>
        [DataMember(Name = "segment_width")]
        public AnyOf<Default, double> SegmentWidth { get; set; } 
        /// <summary>
        /// A number to set the height for the legend text. Default is 1/3 of the segment_height.
        /// </summary>
        /// <value>A number to set the height for the legend text. Default is 1/3 of the segment_height.</value>
        [DataMember(Name = "text_height")]
        public AnyOf<Default, double> TextHeight { get; set; } 

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return "Legend3DParameters";
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
            sb.Append("Legend3DParameters:\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  BasePlane: ").Append(this.BasePlane).Append("\n");
            sb.Append("  SegmentHeight: ").Append(this.SegmentHeight).Append("\n");
            sb.Append("  SegmentWidth: ").Append(this.SegmentWidth).Append("\n");
            sb.Append("  TextHeight: ").Append(this.TextHeight).Append("\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the object from JSON string
        /// </summary>
        /// <returns>Legend3DParameters object</returns>
        public static Legend3DParameters FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<Legend3DParameters>(json, JsonSetting.AnyOfConvertSetting);
            if (obj == null)
                return null;
            return obj.Type.ToLower() == obj.GetType().Name.ToLower() && obj.IsValid(throwException: true) ? obj : null;
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>Legend3DParameters object</returns>
        public virtual Legend3DParameters DuplicateLegend3DParameters()
        {
            return FromJson(this.ToJson());
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel Duplicate()
        {
            return DuplicateLegend3DParameters();
        }

        /// <summary>
        /// Creates a new instance with the same properties.
        /// </summary>
        /// <returns>OpenAPIGenBaseModel</returns>
        public override OpenAPIGenBaseModel DuplicateOpenAPIGenBaseModel()
        {
            return DuplicateLegend3DParameters();
        }
     
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            input = input is AnyOf anyOf ? anyOf.Obj : input;
            return this.Equals(input as Legend3DParameters);
        }

        /// <summary>
        /// Returns true if Legend3DParameters instances are equal
        /// </summary>
        /// <param name="input">Instance of Legend3DParameters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Legend3DParameters input)
        {
            if (input == null)
                return false;
            return base.Equals(input) && 
                    Extension.Equals(this.Type, input.Type) && 
                    Extension.Equals(this.BasePlane, input.BasePlane) && 
                    Extension.Equals(this.SegmentHeight, input.SegmentHeight) && 
                    Extension.Equals(this.SegmentWidth, input.SegmentWidth) && 
                    Extension.Equals(this.TextHeight, input.TextHeight);
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BasePlane != null)
                    hashCode = hashCode * 59 + this.BasePlane.GetHashCode();
                if (this.SegmentHeight != null)
                    hashCode = hashCode * 59 + this.SegmentHeight.GetHashCode();
                if (this.SegmentWidth != null)
                    hashCode = hashCode * 59 + this.SegmentWidth.GetHashCode();
                if (this.TextHeight != null)
                    hashCode = hashCode * 59 + this.TextHeight.GetHashCode();
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

            
            // Type (string) pattern
            Regex regexType = new Regex(@"^Legend3DParameters$", RegexOptions.CultureInvariant);
            if (this.Type != null && false == regexType.Match(this.Type).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, must match a pattern of " + regexType, new [] { "Type" });
            }

            yield break;
        }
    }
}
