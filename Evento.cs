using System.Collections;

namespace TimeTrackAPI.Models
{
    public class Evento
    {
        //Entidade Eventos: Id, Data, Hora, Nome, TipoID, Descrição, UsuárioID

        public int Id { get; set; }
        public DateTime DataHora { get; set; }
        public int Nome { get; set; }
        public int Descricao { get; set; }

    }

}