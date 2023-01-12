namespace WebApplication3.Models
{
    public class AddAgendaViewModel
    {
        public string Responsavel { get; set; }
        public string Titulo { get; set; }
        public string Descrição { get; set; }
        public bool Status { get; set; }
        public int Prazo { get; set; }
        public double Data_inicial { get; set; }
        public double data_conclusão { get; set; }
    }
}
