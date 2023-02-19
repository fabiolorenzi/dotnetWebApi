using System.ComponentModel.DataAnnotations;

namespace dotnetWebApi.Models
{
    public class GamePlayer
    {
        [Key]
        public int Id {get; set;}
        public string PlayerName {get; set;}
        public int RecordScore {get; set;}
        public DateTime Created {get; set;}
        public DateTime LastAccess {get; set;}
    }
}