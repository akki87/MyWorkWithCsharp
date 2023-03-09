using System.ComponentModel.DataAnnotations;

namespace RMS.Api.Core.Attributes
{
	public class EmailValidationAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
		{
			if (value == null || value.ToString().Length == 0)
			{
				return new ValidationResult("Email Address is Required");
			}
			else
			{
				if (value.ToString().IndexOf('@') == -1)
				{
					return new ValidationResult("Invalid Email Address");
				}
				string[] strings = value.ToString().Split('@');
				if (strings[1].ToLower() == "qualminds.com")
				{
					return ValidationResult.Success;
				}
				else
				{
					return new ValidationResult("Email domain should be qualminds.com");
				}
			}
		}
	}
}
