using System.ComponentModel.DataAnnotations;

namespace dotnetWebApi.Models
{
    public class GameObj
    {
        [Key]
        public int Id {get; set;}
        public string Name {get; set;}
        public int Price {get; set;}
    }
}