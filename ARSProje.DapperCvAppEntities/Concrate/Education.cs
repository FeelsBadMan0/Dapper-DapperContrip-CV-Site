using ARSProje.DapperCvAppEntities.Concrate.BaseClasses;
using ARSProje.DapperCvAppEntities.Interfaces;

namespace ARSProje.DapperCvAppEntities.Concrate
{
    [Dapper.Contrib.Extensions.Table("Educations")]
    public class Education : BaseEntity, ITable
    {
    }
}
