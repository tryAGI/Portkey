
#nullable enable

namespace Portkey
{
    /// <summary>
    /// 
    /// </summary>
    public enum PortkeyModerationParametersCategorie
    {
        /// <summary>
        /// 
        /// </summary>
        Harassment,
        /// <summary>
        /// 
        /// </summary>
        HarassmentDividethreatening,
        /// <summary>
        /// 
        /// </summary>
        Hate,
        /// <summary>
        /// 
        /// </summary>
        HateDividethreatening,
        /// <summary>
        /// 
        /// </summary>
        SelfHarm,
        /// <summary>
        /// 
        /// </summary>
        SelfHarmDivideinstructions,
        /// <summary>
        /// 
        /// </summary>
        SelfHarmDivideintent,
        /// <summary>
        /// 
        /// </summary>
        Sexual,
        /// <summary>
        /// 
        /// </summary>
        SexualDivideminors,
        /// <summary>
        /// 
        /// </summary>
        Violence,
        /// <summary>
        /// 
        /// </summary>
        ViolenceDividegraphic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PortkeyModerationParametersCategorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PortkeyModerationParametersCategorie value)
        {
            return value switch
            {
                PortkeyModerationParametersCategorie.Harassment => "harassment",
                PortkeyModerationParametersCategorie.HarassmentDividethreatening => "harassment/threatening",
                PortkeyModerationParametersCategorie.Hate => "hate",
                PortkeyModerationParametersCategorie.HateDividethreatening => "hate/threatening",
                PortkeyModerationParametersCategorie.SelfHarm => "self-harm",
                PortkeyModerationParametersCategorie.SelfHarmDivideinstructions => "self-harm/instructions",
                PortkeyModerationParametersCategorie.SelfHarmDivideintent => "self-harm/intent",
                PortkeyModerationParametersCategorie.Sexual => "sexual",
                PortkeyModerationParametersCategorie.SexualDivideminors => "sexual/minors",
                PortkeyModerationParametersCategorie.Violence => "violence",
                PortkeyModerationParametersCategorie.ViolenceDividegraphic => "violence/graphic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PortkeyModerationParametersCategorie? ToEnum(string value)
        {
            return value switch
            {
                "harassment" => PortkeyModerationParametersCategorie.Harassment,
                "harassment/threatening" => PortkeyModerationParametersCategorie.HarassmentDividethreatening,
                "hate" => PortkeyModerationParametersCategorie.Hate,
                "hate/threatening" => PortkeyModerationParametersCategorie.HateDividethreatening,
                "self-harm" => PortkeyModerationParametersCategorie.SelfHarm,
                "self-harm/instructions" => PortkeyModerationParametersCategorie.SelfHarmDivideinstructions,
                "self-harm/intent" => PortkeyModerationParametersCategorie.SelfHarmDivideintent,
                "sexual" => PortkeyModerationParametersCategorie.Sexual,
                "sexual/minors" => PortkeyModerationParametersCategorie.SexualDivideminors,
                "violence" => PortkeyModerationParametersCategorie.Violence,
                "violence/graphic" => PortkeyModerationParametersCategorie.ViolenceDividegraphic,
                _ => null,
            };
        }
    }
}