# Pick-em.Web

A sports pick-em project for picking winners of sports games.

## TL;DR

This project uses dotnet core to build a web application. It uses four layers to achieve this.

To build the app locally,

```bash
./scripts/build.sh
```

To run locally (without Docker),

```bash
cd src/Pick-em.Web && dotnet run
```

And finally, to test any given project,

```bash
cd test/Pick-em.<proj>.Test && dotnet test
```

## Background

This project is a throwback to a project I worked on in 2008 that was a "pick-em" app - one that allowed users to choose the winner of games in a sports league season, with a running total for the season. The purpose was to get familar with CakePHP which I was using at the time for work, and to replace a manual process that was going on in the office.

## This project

This projet will be written with ASP.NET in C# with dotnet core 2.1. The data store for this project will be Postgres - a releational database. I will _not_ be using an ORM to connect to this database.

## Architecture

This section will be fleshed out more as the project is worked on, but to start with, this project will focus on maintaining a layered architecture with four layers:  web, service, domain and data. For the scope of this project, I don't want to get into [CQRS](https://martinfowler.com/bliki/CQRS.html) or microservices. For an example that experiments with those patterns, see the [Books project](https://github.com/truggeri/Books.Service.Transaction). Each layer is implemented in its own unique project such that the dependencies between layers are the same as the dependencies between cs projects.

The following details each layer from the bottom up.

### Data

The purpose of this layer is to provide access to the data storage mechanism (DB). This layer will _not_ be implemented with the use of an ORM. For more details on this layer, visit the [README](src/Pick-em.Lib.Data/README.md) in the project file.

### Domain

The purpose of this layer is to provide teh domain level logic. Domain logic (as defined in Domain Driven Design), is the core "business" logic of the application. This is the structure that creates the basis for the application - in this case the classes for teams, matchups, picks, weeks, seasons, etc. For more details on this layer, visit the [README](src/Pick-em.Lib.Domain/README.md) in the project file.

### Service (Application)

The purpose of this layer is to provide logic for incoming and outgoing requests. You could draw a comparison to the "Controller" from an MVC pattern, where this layer is acting to controll logic for fetching and creating/updating data. None of this logic lives in the view layer that users see, but there is still a large amount of practical plubming that is not part of the core domain. For more details on this layer, visit the [README](src/Pick-em.Lib.Service/README.md) in the project file.

### Web

This layer is the front-end views that users utilize to interact with the application. As little logic as possible should be in this layer. For more details on this layer, visit the [README](src/Pick-em.Web/README.md) in the project file.
