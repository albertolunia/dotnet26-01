using TechMed.Application.InputModels;
using TechMed.Application.Services.Interfaces;
using TechMed.Application.ViewModels;
using TechMed.Core.Exceptions;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Application.Services;

public class ExameService : BaseService, IExameService
{
    private readonly IAtendimentoService _atendimentoService;
    public ExameService(ITechMedContext context, IAtendimentoService atendimento) : base(context)
    {
        _atendimentoService = atendimento;
    }
    public int Create(NewExameInputModel exame)
    {
        return _atendimentoService.CreateExame(exame);
    }

    public List<ExameViewModel> GetAll()
    {
        var exames = _context.ExamesCollection.GetAll().Select(e => new ExameViewModel
        {
            ExameId = e.ExameId,
            Nome = e.Nome,
            Atendimento = new AtendimentoViewModel
            {
                AtendimentoId = e.Atendimento.AtendimentoId,
                DataHora = e.Atendimento.DataHora,
                Medico = new MedicoViewModel
                {
                    MedicoId = e.Atendimento.Medico.MedicoId,
                    Nome = e.Atendimento.Medico.Nome
                },
                Paciente = new PacienteViewModel
                {
                    PacienteId = e.Atendimento.Paciente.PacienteId,
                    Nome = e.Atendimento.Paciente.Nome
                }
            }
        }).ToList();
        return exames;
    }

    public List<ExameViewModel> GetByAtendimentoId(int atendimentoId)
    {
        throw new NotImplementedException();
    }
}
