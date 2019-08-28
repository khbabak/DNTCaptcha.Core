namespace DNTCaptcha.Core.Providers
{
    /// <summary>
    /// Display mode of the captcha's text
    /// </summary>
    public enum DisplayMode
    {
        /// <summary>
        /// Display a numeric value using the equivalent text
        /// </summary>
        NumberToWord,

        /// <summary>
        /// Show only digits
        /// </summary>
        ShowDigits,

        /// <summary>
        /// Display a numeric value as a sum of 2 numbers
        /// </summary>
        SumOfTwoNumbers
    }
}