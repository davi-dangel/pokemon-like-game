namespace PokemonGame.App.Entities
{
    public class PokemonMoviment
    {
        public string Name { get; set; }
        public string Type { get; set; }
        //TODO: Pensar melhors nessa classe, ver se faz sentido
        public float Power { get; set; }

        /*
         * 
         * Nome do Golpe - OK
         * 
         * Tipos
         *      Ataque - Dar dano no oponente
         *      Recuperação - Recuperar pontos de vida
         *      Diminuir Defesa - Diminui a defesa do oponente
         *      Diminuir Ataque - Diminui o ataque do oponente
         *      
         *      ou
         *      
         *      ataque
         *      recuperação de vida
         *      defesa (jogador escolhe se quer aumentar ou diminuir a defesa
         *      
         *      ou
         *      
         *      ataque
         *      aumentar ataque
         *      diminuir defesa
         *      aumentar defesa
         *      
         * 
         * Power
         *      Como que eu balanceio isso
         * 
         */
    }
}
