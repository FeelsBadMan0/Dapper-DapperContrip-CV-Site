using ARSProje.DapperCvAppEntities.Interfaces;
using Dapper.Contrib.Extensions;

namespace ARSProje.DapperCvAppEntities.Concrate
{
    [Dapper.Contrib.Extensions.Table("SocialMediaIcons")]
    public class SocialMediaIcon : ITable
    {
        [Key]
        public int Id { get; set; }
        public string Link { get; set; }
        public string Icon { get; set; }
        public int AppUserId { get; set; }
    }
}
