using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDBTest;
using System;


try
{


    //MongoClient dbClient = new MongoClient("mongodb+srv://Rodrigo:123@mongoapirest.qfk6oqi.mongodb.net/?retryWrites=true&w=majority");

    //BsonClassMap.RegisterClassMap<Carrito>(cm =>
    //{
    //    cm.MapMember(c => c.Usuario);
    //    cm.MapMember(c => c.ListaArticulos);
    //});

    //var db = dbClient.GetDatabase("test");
    //var carritos = db.GetCollection<Carrito>("Carrito");
    //var listaCarritos = carritos.Find(new BsonDocument()).ToList();
    //Console.WriteLine("Los carritos son: ");
    //foreach (Carrito carrito in listaCarritos)
    //{
    //    Console.WriteLine("- Datos del usuario del carrito -");
    //    Console.WriteLine("     Nombre: " + carrito.Usuario.Nombre);
    //    Console.WriteLine("     Telefono: " + carrito.Usuario.Telefono);
    //    Console.WriteLine("     Direccion: " + carrito.Usuario.Direccion);
    //    Console.WriteLine("");
    //    Console.WriteLine("- Lista de aritculos del carrito -");

    //    foreach (Articulo articulo in carrito.ListaArticulos)
    //    {
    //        Console.WriteLine("     Codigo: " + articulo.Codigo);
    //        Console.WriteLine("     Descripcion: " + articulo.Descripcion);
    //        Console.WriteLine("     Costo: " + articulo.Costo);
    //        Console.WriteLine("     -----------------------------");
    //    }
    //    Console.WriteLine("----------------------------------------------------");
    //}
}
catch (Exception e)
{
    Console.WriteLine(e);
}

