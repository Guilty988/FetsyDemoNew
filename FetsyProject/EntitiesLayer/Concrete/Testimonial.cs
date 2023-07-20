using System.ComponentModel.DataAnnotations;

namespace EntitiesLayer.Concrete
{
    public class Testimonial
    {

        [Key]
        public int TestimonialId { get; set; }
        public string Client { get; set; }
        public string Comment { get; set; }
        public string ClientName { get; set; }
        public bool Status { get; set; }  

    }



}
