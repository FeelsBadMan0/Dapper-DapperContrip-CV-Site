using ARSProje.DapperCvAppEntities.Concrate.BaseClasses;
using ARSProje.DapperCvAppEntities.Interfaces;

namespace ARSProje.DapperCvAppEntities.Concrate
{
    [Dapper.Contrib.Extensions.Table("Interests")]
    public class Interest : BaseEntity2, ITable
    {
    }
}
