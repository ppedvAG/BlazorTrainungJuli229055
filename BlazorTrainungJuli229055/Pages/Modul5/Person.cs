using System.ComponentModel.DataAnnotations;

namespace BlazorTrainungJuli229055.Pages.Modul5
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10,ErrorMessage ="Max 10")]
        public string Name { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        public DateTime GebDat { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
        [Range(120,190,ErrorMessage ="zwischen 120 und 190")]
        public int Gross { get; set; }

    }
}
