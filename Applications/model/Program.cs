// See https://aka.ms/new-console-template for more information
using Applications.model;
using Applications.controller;

Commis commis = new Commis("Didier",0);

await Task.Run(() => commis.questionner());
Thread.Sleep(30000);
