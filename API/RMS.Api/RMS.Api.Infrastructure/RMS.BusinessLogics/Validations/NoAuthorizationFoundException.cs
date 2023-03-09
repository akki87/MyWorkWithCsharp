using System.Runtime.Serialization;

namespace RMS.Api.Infrastructure.Validations
{
	[Serializable]
	internal class NoAuthorizationFoundException : Exception
	{
		public NoAuthorizationFoundException()
		{
		}

		public NoAuthorizationFoundException(string? message) : base(message)
		{
		}

		public NoAuthorizationFoundException(string? message, Exception? innerException) : base(message, innerException)
		{
		}

		protected NoAuthorizationFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}