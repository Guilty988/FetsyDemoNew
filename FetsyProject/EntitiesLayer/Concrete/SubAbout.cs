using System.ComponentModel.DataAnnotations;

namespace EntitiesLayer.Concrete
{
    public class SubAbout
    {
        [Key]
        public int SubAboutId { get; set;}
        public string Title { get; set; }
        public string Description { get; set; }

    }



}
