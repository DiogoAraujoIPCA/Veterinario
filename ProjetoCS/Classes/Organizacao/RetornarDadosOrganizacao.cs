
public partial class Organizacao {
    #region Procedimentos Retornar Dados Organizacao



public void RetornarNomeUtilizador(){
    Console.WriteLine("Nome Organização:"+NomeOrganizacao+"");
}



public void RetornarMoradautilizador(){
    Console.WriteLine("Morada Organização:"+Morada+"");
}


public void RetornarNumeroTelemovelUtilizador(){
    Console.WriteLine("Nº Telemovel Organização:"+NumeroTelemovel+"");
}


public void RetornarEmailUtilizador(){
    Console.WriteLine("Email da  Organização:"+Email+"");
}

public void RetornarListaConsultas(){

    Auxliar.EspacoEntreOperacoes(2);
    Auxliar.IdentificacaoOperacao("Lista de Consultas");
        Auxliar.EspacoEntreOperacoes(1);
        int  i= 0;
        foreach (Consulta var in ListaConsultas)
        {
            Console.WriteLine(i+")"+var.RetornarDescricao()+";") ;
            i++;
        }
}

public void InformacoesConsultaBaseLista(int n_indice){

    int  i= 0;
        foreach (Consulta var in ListaConsultas)
        {
            if(n_indice==i){
                var.RetornarTodasInformacoesConsultaUtilizador();
            }
            Console.WriteLine(i+")"+var.RetornarDescricao()+";") ;
            i++;
        }
}


// ListaVeterinarios
public void RetornarVeterinario(){
    Console.WriteLine("Retornar Lista de Veterinarios");
        foreach (Veterinario var in ListaVeterinarios)
        {
            var.RetornarTodosDados(false);
        }
}
#endregion

#region Metodos Retornar Dados Organizacao


public string RetornarNome(){
    return NomeOrganizacao;
}


public int RetornarNumeroTelemovel(){
    if(NumeroTelemovel<=0)
    return NumeroTelemovel;
    else{
         throw new ArgumentException("Numero Telemovel Invalido", nameof(NumeroTelemovel));
    }
}


public string RetornarEmail(){
    return Email;
}

public string RetornarMorada(){
    return Morada;
}




//Lista Consultas

// ListaVeterinarios
#endregion
}
