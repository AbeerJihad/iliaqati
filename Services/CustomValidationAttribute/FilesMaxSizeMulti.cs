namespace liaqati_master.Services.CustomValidation
{

    public class FilesMaxSizeMulti : ValidationAttribute
    {
        private readonly int _maxFileSize;
        private readonly string? _errormessage;
        public FilesMaxSizeMulti(int maxFileSize, string? errormessage = null)
        {
            _maxFileSize = maxFileSize;
            _errormessage = errormessage;
        }

        protected override ValidationResult IsValid(
        object? value, ValidationContext validationContext)
        {
            var file = value as IFormFileCollection;
            if (file != null)
            {
                foreach (var item in file)
                {
                    if (item.Length > _maxFileSize)
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }
            }
            else
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

        public override string FormatErrorMessage(string name)
        {
            return string.Format($"{0} Maximum allowed File size is {1} bytes.", name, _maxFileSize);
        }
        public string? GetErrorMessage()
        {
            return _errormessage;
        }
    }
}
