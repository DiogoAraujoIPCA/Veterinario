public partial class Raça{
     #region Metodos para Atualizar Valores
    public void AtualizarNomeRaca(string _Nome)
    {
        if (Validacoes.VerificarCampo(_Nome))
        {
            Nome = _Nome;
        }
        else
        {
            Console.WriteLine("Não Foi possivel atualizar nome raça");
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
    #endregion
}