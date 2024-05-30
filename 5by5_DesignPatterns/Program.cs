// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;
Console.WriteLine("Inicio do Processamento");

Car car = new Car()
{
    Id = 1,
    Name = "Fusca",
    Color = "Azul",
    Year = 1970
};
Console.WriteLine(car);

//if ternário
Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido" : "Erro ao inserir registro");

Console.WriteLine(new CarController().Update(car) ? "Registro alterado" : "Erro ao alterar registro");

Console.WriteLine(new CarController().Delete(car.Id) ? "Registro deletado" : "Erro ao deletar registro");

Console.WriteLine(new CarController().GetById(car.Id)!=null ? "registro encontrado" : "Erro ao encontrar registro" );

Console.WriteLine(new CarController().GetAll().Count > 0 ? "Registros encontrados" : "Erro ao encontrar registros" );


