namespace liaqati_master.Services.CustomValidationAttribute
{
    public class AllowedExtensionsMulti : ValidationAttribute
    {
        private readonly string[] _extensions;
        private readonly string? _errormessage;

        public AllowedExtensionsMulti(string[] extensions, string? errormessage = null)
        {
            _extensions = extensions;
            _errormessage = errormessage;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var file = value as IFormFileCollection;
            if (file != null)
            {
                foreach (var item in file)
                {
                    var extension = Path.GetExtension(item.FileName);
                    if (!_extensions.Contains(extension.ToLower()))
                    {
                        return new ValidationResult(GetErrorMessage());
                    }
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return _errormessage;
        }
    }
    //public class FileType : ValidationAttribute
    //{
    //    private readonly string _FileType;
    //    private readonly string? _errormessage;
    //    public FileType(string FileType, string? errormessage = null)
    //    {
    //        _FileType = FileType;
    //        _errormessage = errormessage;
    //    }

    //    protected override ValidationResult IsValid(
    //    object? value, ValidationContext validationContext)
    //    {
    //        var file = value as IFormFile;
    //        if (file != null)
    //        {
    //            string[] listOFtypes = _FileType.ToLower().Split(',');
    //            var Extension = Path.GetExtension(file.FileName);
    //            if (listOFtypes.Contains(Extension))
    //            {
    //                return new ValidationResult(GetErrorMessage());
    //            }
    //        }

    //        return ValidationResult.Success;
    //    }

    //    public override string FormatErrorMessage(string name)
    //    {
    //        return string.Format($"{0} انواع الملفات المسموحة {1} .", name, _FileType);
    //    }
    //    public string? GetErrorMessage()
    //    {
    //        return _errormessage;
    //    }
    //}

}
