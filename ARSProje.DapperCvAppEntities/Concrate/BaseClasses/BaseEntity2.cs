using Dapper.Contrib.Extensions;

namespace ARSProje.DapperCvAppEntities.Concrate.BaseClasses
{
    public class BaseEntity2
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
