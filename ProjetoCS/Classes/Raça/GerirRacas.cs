public partial class Raca
{


    #region GerirRacas
    public void AdicionarRaca(Diagnostico _Diagnostico)
    {
        Diagnostico.Add(_Diagnostico);

    }

    public void ListarDiagnosticosRaca()
    {
        Auxliar.IdentificacaoOperacao("Listar Diagnnosticos comuns na Raca:");
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