using System.ComponentModel.DataAnnotations;

namespace Lychee.Entities.Entities
{
    public class Setting
    {
        [Key]
        public int SettingId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public string Group1 { get; set; }
        public string Group2 { get; set; }
        public string Category { get; set; }
    }
}
