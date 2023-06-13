using ARSProje.DapperCvAppEntities.Concrate.BaseClasses;
using ARSProje.DapperCvAppEntities.Interfaces;

namespace ARSProje.DapperCvAppEntities.Concrate
{
    [Dapper.Contrib.Extensions.Table("Certifications")]
    public class Certification : BaseEntity2, ITable
    {
    }
}
