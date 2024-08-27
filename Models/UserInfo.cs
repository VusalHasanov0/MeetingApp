using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo 
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Ad alani zorunludur")]
        public string? Name { get; set; }
        [Required(ErrorMessage ="Telefon alani zorunludur")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="Email alani zorunludur")]
        [EmailAddress(ErrorMessage ="Hatali Email")]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katilim durumunuzu belirtin")]
        public bool? WillAttend { get; set; }
    }
}