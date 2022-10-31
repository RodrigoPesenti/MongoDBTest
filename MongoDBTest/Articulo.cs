using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace MongoDBTest
{
    [BsonIgnoreExtraElements]
    internal class Articulo
    {
        private string descripcion;
        private string codigo;
        private int costo;

        public Articulo(string descripcion, string codigo, int costo)
        {
            this.descripcion = descripcion;
            this.codigo = codigo;
            this.costo = costo;
        }

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Costo { get => costo; set => costo = value; }
    }
}
