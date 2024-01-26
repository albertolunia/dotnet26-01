namespace TechMed.Core.Entities
{
    public class Exame : BaseEntity
    {
        public int ExameId {get; set;}
        public string? Nome {get; set;}
        public int AtendimentoId {get; set;}
        public Atendimento Atendimento {get; set;}
    }
};
