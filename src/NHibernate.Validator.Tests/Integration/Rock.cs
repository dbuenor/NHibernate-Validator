 using NHibernate.Validator.Constraints;

namespace NHibernate.Validator.Tests.Integration
{
	public class Rock : Music
	{
		[NotNull]
		public int bit;
	}
}