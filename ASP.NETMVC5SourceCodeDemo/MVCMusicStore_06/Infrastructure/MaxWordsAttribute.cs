using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore_06.Infrastructure
{
    public class MaxWordsAttribute:ValidationAttribute
    {
        public MaxWordsAttribute(int maxWords):base("{0} has too many words.")
        {
            _maxWords = maxWords;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var valueAsString = value.ToString();
                int strLen = valueAsString.Trim().Length;
                if ( strLen> _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
        
        private readonly int _maxWords;
    }
}