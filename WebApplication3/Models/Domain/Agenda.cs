using System.Data.SqlTypes;


namespace CrudAgenda.Models.Domain
{
    public class Agenda
    {
        public Guid Id { get; set; }
        public string Responsavel { get; set; }    
        public string Titulo { get; set; }
        public string Descrição { get; set; }
        public bool Status { get; set; }
        public int Prazo { get; set; }
        public double Data_inicial { get; set; }
        public double data_conclusão { get; set; }

    }
}
