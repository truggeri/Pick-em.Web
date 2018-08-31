# Pick-em.Web

The web part of Pick-em, a project for picking winners of sports games.

## TL;DR

TBD ;)

## Background

This project is a throwback to a project I worked on in 2008 that was a "pick-em" app - one that allowed users to choose the winner of games in a sports league season, with a running total for the season. The purpose was to get familar with CakePHP which I was using at the time for work, and to replace a manual process that was going on in the office.

## This project

This projet will be written with ASP.NET in C# with dotnet core 2.1. The data store for this project will be Postgres - a releational database. I will _not_ be using an ORM to connect to this database.

## Architecture

This section will be fleshed out more as the project is worked on, but to start with, this project will focus on maintaining a layered architecture with the web layer, service/application layer, domain layer, and data access layer. For the scope of this project, I don't want to get into [CQRS](https://martinfowler.com/bliki/CQRS.html) or microservices. For an example that experiments with that pattern, see the [Books project](https://github.com/truggeri/Books.Service.Transaction).
