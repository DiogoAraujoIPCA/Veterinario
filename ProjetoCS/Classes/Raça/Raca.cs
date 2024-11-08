public  partial class Raça
{
    private string Nome;
    private string Informacoes;
    private List<Raça> Raca;
    public Raça(string _Nome, string _Informacoes=null)
    {
        if (!Validacoes.VerificarCampo(_Nome))
        {
            Console.WriteLine("Nome ", "Não foi possivel criar a Raça devido a dados invalidos no Nome");
        }
        else if ( _Informacoes!=null )
        {   
            if(!Validacoes.VerificarCampo(_Informacoes) ){
                Console.WriteLine("Informações", "Não foi possivel criar a Raça devido a dados invalidos nas Informações");
            }
                else
        {
            Nome = _Nome;
            Informacoes = _Informacoes;
          //  Raca = new List<Raça>();
        }
            
        }
    



    }

}
