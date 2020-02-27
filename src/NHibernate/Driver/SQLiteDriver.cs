using NHibernate.Engine;

namespace NHibernate.Driver
{

	public class SQLiteDriver : ReflectionBasedDriver
	{

		public SQLiteDriver() : base(
			"Microsoft.Data.Sqlite.Core",
			"Microsoft.Data.Sqlite",
			"Microsoft.Data.Sqlite.SqliteConnection",
			"Microsoft.Data.Sqlite.SqliteCommand")
		{
		}

		public override IResultSetsCommand GetResultSetsCommand(ISessionImplementor session)
		{
			return new BasicResultSetsCommand(session);
		}

		public override bool UseNamedPrefixInSql => true;

		public override bool UseNamedPrefixInParameter => true;

		public override string NamedPrefix => "@";

		public override bool SupportsMultipleOpenReaders => false;

		public override bool SupportsMultipleQueries => true;

		public override bool SupportsNullEnlistment => false;

		public override bool HasDelayedDistributedTransactionCompletion => true;

	}

}
