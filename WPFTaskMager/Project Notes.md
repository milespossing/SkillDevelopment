# WPF Task Manager

## Introduction

This is a project that will basically help me get used to a database schema, some essential WPF elements, and eventually allow me to run a database out of Azure and also interface with ASP.NET. Long term I'd like to expose a Task API through ASP.NET and maybe even run the project on Mobile as well.

## The app

The app will be very simple. At least 1 detail view for individual tasks, a create task view, and a task list view (which allows completing tasks directly). The initial app will be in WPF, I might also whip one up in WinForms to get a feel for the differences between the two while working on a similar project.

## The database

The database is a simple SQL Server. I'm running it off of docker right now using the Microsoft provided image. It actually took me quite a long time to figure out that `Server=localhost:1433;` is *not* the correct syntax. It is now `Server=.;`. I'm also using JetBrains DataGrip to run simple queries against the database to make sure everything works as expected over time.

In the codebase I'm using Entity Framework Core to run migrations and update the database as well as work with the context. Getting everything set up was super dicy, actually. The trick here was getting Entity Framework Core to work with .Net Framework 4.6.1, which meant seperating my model into a .net core 2.0 app. But then it was not accessible from my main WPF app, so the app also, it would seem, needs to target .net standard as well. This took a *long* time for me to figure out. But we're running now. Migrations can be completed directly from powershell (or any other terminal) and the database updates and runs correctly.