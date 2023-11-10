using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animalSpace.Model.Game
{
    internal class Game
    {

        //mover todo esto a una controladora asdklfja

        /*
         * Acá va toda la lógica del juego, reglas, turnos, etc
         */
        public List<Player> players = new List<Player>();
        //Inicializar el juego
        public void initGame()
        {
            // inicializar arreglo de turnos en vacio
            // crear usuarios (x cantidad de usuarios)
            // preguntar cuantas criaturas va a haber en el juego
            // crear las que quiera, las demás tener un generador
            //      - asignar las criaturas

            // iniciar turnos (loop):
            //      - definir condicion de corte (cuando quede un solo jugador con criaturas vivas)
            //      - definir el orden de jugadores(Primer jugador de cada ronda = random,
            //        ultimo jugador de la siguiente ronda = jugador que inicio la ronda anterior).
            //      - por cada turno el usuario puede utilizar todas las entidades que quiera 
        }
    }
}
