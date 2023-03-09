namespace RMS.Api.Infrastructure.Validations
{
	public interface IUserValidation
	{
		public  void Validate(string username, string password, string methodName);
		public bool OnUserPrivilegeValidation(int id, string method);
	}
}