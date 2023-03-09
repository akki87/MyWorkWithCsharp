using System.Runtime.Serialization;

namespace RMS.Api.Infrastructure.Validations
{
	[Serializable]
	internal class NoPrivilegesFoundException : Exception
	{
		public NoPrivilegesFoundException()
		{
		}

		public NoPrivilegesFoundException(string? message) : base(message)
		{
		}

		public NoPrivilegesFoundException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected NoPrivilegesFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}