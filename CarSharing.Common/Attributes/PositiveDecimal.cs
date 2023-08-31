using System.ComponentModel.DataAnnotations;

namespace CarSharing.Common.Attributes
{
    public class PositiveDecimal : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null) return false;

            if (value is decimal decimalValue)
            {
                return decimalValue > 0;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.IsNullOrEmpty(ErrorMessage)
                ? $"{name} must be a positive number."
                : ErrorMessage;
        }
    }
}
