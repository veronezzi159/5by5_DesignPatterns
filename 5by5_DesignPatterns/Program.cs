// See https://aka.ms/new-console-template for more information
using Controllers;
using Models;
Console.WriteLine("Inicio do Processamento");

Car car = new Car()
{   
    Id = 2,
    Name = "Opala",
    Color = "Vermelho",
    Year = 1992
};


//if ternário
//Console.WriteLine(new CarController().Insert(car) ? "Registro Inserido" : "Erro ao inserir registro");

//Console.WriteLine(new CarController().Update(car) ? "Registro Atualizado" : "Erro ao atualizar registro");

Console.WriteLine(new CarController().Delete(139) ? "Registro Deletado" : "Erro ao deletar registro");

//new CarController().GetAll().ForEach(c => Console.WriteLine(c));

//Console.WriteLine(new CarController().GetById(1));