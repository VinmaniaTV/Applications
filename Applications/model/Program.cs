// See https://aka.ms/new-console-template for more information
using Applications.model;
using Applications.controller;

Console.WriteLine("Hello, World!");

Client c = new Client("Jean Dupond", "2 rue du turfu", "0123456789", "2 septembre");

Console.WriteLine(c.Telephone);

//DataManager dm = new DataManager();
DataManager.writeToXml(c);