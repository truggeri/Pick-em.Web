# Pick-em.Lib.Data

This project is a net standard 2.0 project that focuses on bringing data into the project and saving data out to a persistant data store. The initial target of this application is to use [Postgres relational database](https://www.postgresql.org/about/) to store all data. This project will likely mirror the way the Service layer offers actions/services for the domain layer to use, but is not dependent on the domain layer. This acts as a layer of abstraction between the Domain layer and the actual implementation of the database (Postgres). There will likely be a shared library so they can speak the same language.

__Why use the Data layer at all?__

The point of the Data layer is to abstract the concrete implementation of the database connection and SQL statements from the Domain layer which should _only_ be focused on the logic of the app (commonly called "business logic"). Without this abstraction, each piece of code written for the database would tightly couple the app logic to the implementation of the database. Providing this abstraction code allow the domain logic to be more extensible and reusable. Just think of how hard it would be to switch database providers (say from Postgres to MongoDB) without such an abstraction layer.

__Why not use Entity Framework?__

[Entity Framework](https://docs.microsoft.com/en-us/ef/core/) is a very useful [Object-Relational Mapper](https://en.wikipedia.org/wiki/Object-relational_mapping) (ORM) that is [developed by Microsoft as part of aspnet](https://github.com/aspnet/EntityFrameworkCore). For this project, I want to focus on the SQL statments rather than how to use the EF ORM. It's not a solution that would scale if multiple developers were working on the project, but it does make sense for the golas of this individual developer.

## Using

```bash
dotnet add reference <relative path>/Pick-em.Lib.Data.csproj
```

## Interface

@TODO

## Dependencies

This project _shouldn't_ have any dependencies on other projects in this app. This layer does have a dependency on the actual database, but that should be properly abstracted such that the data implementation could easily be swapped.

## Other notes

None so far.