using System.ComponentModel.DataAnnotations;

namespace EntitiesLayer.Concrete
{
    public class NewsLetter
    {
        [Key]
        public int NewsLetterId { get;}
        public string Mail { get; set; }
        public string Status { get; set; }

    }



}
