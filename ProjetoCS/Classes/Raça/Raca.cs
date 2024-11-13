public partial class Raca
{
    private string Nome;
    private string Informacoes;
    private List<Diagnostico> Diagnostico;

    public Raca(string _Nome, string _Informacoes = null)
    {
        if (!Validacoes.VerificarCampo(_Nome))
        {
            Console.WriteLine(
                "Nome ",
                "Não foi possivel criar a Raca devido a dados invalidos no Nome"
            );
        }
        else if (_Informacoes != null)
        {
            if (!Validacoes.VerificarCampo(_Informacoes))
            {
                Console.WriteLine(
                    "Informações",
                    "Não foi possivel criar a Raca devido a dados invalidos nas Informações"
                );
            }
            else
            {
                Nome = _Nome;
                Informacoes = _Informacoes;
                Diagnostico = new List<Diagnostico>();
            }
        }
    }
}
