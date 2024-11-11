public partial class Raça
{


    #region GerirRaças
    public void AdicionarRaça(Diagnostico _Diagnostico)
    {
        Diagnostico.Add(_Diagnostico);

    }

    public void ListarDiagnosticosRaca()
    {
        Auxliar.IdentificacaoOperacao("Listar Diagnnosticos comuns na raça:");
        if (Diagnostico.Count == 0)
        {
            Console.WriteLine("Nenhum Diagnostico associado.");
        }
        else
        {
            foreach (Diagnostico tipoRaca in Diagnostico)
            {
                tipoRaca.RetornarNomeDiagnostico();
            }
        }
    }
    #endregion
}