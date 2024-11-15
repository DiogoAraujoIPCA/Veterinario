public partial class Raca
{

    #region Procedimentos para Atualizar Valores
    public bool AtualizarNomeRaca(string _Nome)
    {
        if (Validacoes.VerificarCampo(_Nome))
        {
            Nome = _Nome;
            return true;
        }
        else
        {
            Console.WriteLine("Não Foi possivel atualizar nome Raca");
            return false;
        }
    }

    public void AtualizarInformacoesRaca(string _Informacoes)
    {
        if (Validacoes.VerificarCampo(_Informacoes))
        {
            Informacoes = _Informacoes;

        }
        else
        {
            Console.WriteLine("Não Foi possivel atualizar Informações");
        }
    }


    public void AdicionarCondicaoMedica(Diagnostico CondicaoMedica)
    {
        Diagnostico.Add(CondicaoMedica);
    }

    public void ListarCondicoesComuns()
    {

        Auxliar.IdentificacaoOperacao("Lista comuns Raca :" + RetornarNomeRaca() + " ");
        foreach (Diagnostico diag in Diagnostico)
        {
            Console.WriteLine(diag.RetornarNomeDiagnostico());
        }
    }
    #endregion
}