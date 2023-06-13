using ARSProje.DapperCvAppEntities.Concrate.BaseClasses;
using ARSProje.DapperCvAppEntities.Interfaces;

namespace ARSProje.DapperCvAppEntities.Concrate
{
    [Dapper.Contrib.Extensions.Table("Skills")]
    public class Skill : BaseEntity2, ITable
    {
    }
}
