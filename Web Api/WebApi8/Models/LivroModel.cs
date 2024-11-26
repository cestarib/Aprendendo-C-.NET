namespace WebApi8.Models
{
    public class LivroModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public ICollection<AutorModel> Autor { get; set; }

    }
}
