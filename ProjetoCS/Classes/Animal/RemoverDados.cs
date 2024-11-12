public partial class Animal{
      #region Procedimentos para Remover Atributos
        public void RemoverResposavel()
        {
            Auxliar.IdentificacaoOperacao("Remover Responsavel de "+NomeAnimal+"");
            if (Responsavel != null)
            {
                Console.WriteLine("Responsável removido com sucesso.");
                Responsavel = null;
            }
            else
            {
                Console.WriteLine("Nenhum responsável para remover.");

            }

        }

        public void RemoverRaca()
        {
            Auxliar.IdentificacaoOperacao("Remover Raca de "+NomeAnimal+"");
            if (NomeRaca != null)
            {
                Console.WriteLine("Raca removido com sucesso.");
                NomeRaca = null;
            }
            else
            {
                Console.WriteLine("Nenhum Raca atribuida para remover.");

            }
        }
        #endregion

}