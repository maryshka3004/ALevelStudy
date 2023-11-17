// See https://aka.ms/new-console-template for more information
using Shop.Goods;
using Shop.Repositories;
using Shop.Services;


var result = new UserService(new UserRepository());

result.AddUser("Patric", "Jogns");

var play = new Iprogram();