

public partial class Organizacao{

#region Procedimentos Atualizar Dados Organização

    public  void AtualizarNomeOrganização( string _NomeOrganizacao ){
        

       if( Validacoes.VerificarCampo(_NomeOrganizacao)){
        Console.WriteLine("Atualizar Nome da Organização");
        NomeOrganizacao=_NomeOrganizacao;


       }else{
         Console.WriteLine("Não foi possivel atualizar Nome da Organização");
       }
        
    }

    public  void AtulizarMoradaOrganizacao( string _MoradaOrganizacao ){
        

       if( Validacoes.VerificarCampo(_MoradaOrganizacao)){
        Console.WriteLine("Atualizar Nome da Organização");
        Morada=_MoradaOrganizacao;


       }else{
         Console.WriteLine("Não foi possivel atualizar a morada da Organização");
       }
        
    }

    public void AtualizarNumeroTelemovel(int _NumeroTelemovel){
        if (Validacoes.VerificarNumeroTelemovel(_NumeroTelemovel)){
            NumeroTelemovel=_NumeroTelemovel;
        }else{
            Console.WriteLine("Não foi possivel atualizar Nº Telemovel ");
        }
    }

    public void AtualizarEmail(string _Email){
        if(Validacoes.VerificarCampoNull(Email)){
            Email=_Email;
        }else{
            Console.WriteLine("Não foi possivel o Email");
        }
    }
    public void adicionarConsulta(Consulta _consulta){
        ListaConsultas.Add( _consulta);
    }
#endregion

}