public partial class Animal{
    
        #region Procedimentos para atualizar Valores
        public void AtualizarResponsavel(Pessoa _Responsavel)
        {     
            Auxliar.IdentificacaoOperacao("Atualizar Responsavel Animal:");
            Responsavel = _Responsavel;
        }

          public void AtualizaNomeRaca(Raça _Raca)
        {     
             Auxliar.IdentificacaoOperacao("Atualizar Nome Raça animal:");
            NomeRaca = _Raca;
        }

        public void AtualizarNumeroChip(int _NumeroChip)
        {
            Auxliar.IdentificacaoOperacao("Atualizar Numero Chip:");
            if( NumeroChip >0 ){
                NumeroChip=_NumeroChip;
            }
            else{
                Console.WriteLine("Não foi possivel atualizar nuemro do chip.");
            }
           
        }
        public void AtualizarNomeAnimal(string _NomeAnimal){

            Auxliar.IdentificacaoOperacao("Atualizar Nome Animal:");
            if(Validacoes.VerificarCampo(NomeAnimal)){
                NomeAnimal=_NomeAnimal;
            }
            else{
                Console.WriteLine("Não foi possivel atualizar nome do animal.");
            }
        }
        
        #endregion

}