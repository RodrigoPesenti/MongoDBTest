using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBTest
{
    [BsonIgnoreExtraElements]
    internal class Carrito
    {

        private Usuario usuario;
        private Articulo[] listaArticulos;

        public Carrito(Usuario usuario, Articulo[] listaArticulos)
        {
            this.usuario = usuario;
            this.listaArticulos = listaArticulos;
        }

        internal Usuario Usuario { get => usuario; set => usuario = value; }
        internal Articulo[] ListaArticulos { get => listaArticulos; set => listaArticulos = value; }
    }
}
