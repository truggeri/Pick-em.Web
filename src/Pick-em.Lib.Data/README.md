# Pick-em.Lib.Data

This project is a net standard 2.0 project that focuses on bringing data into the project and saving data out to a persistant data store. The initial target of this application is to use Postgres relational database to store all data. This project will likely mirror the way the Service layer offers actions/services for the domain layer to use, but is not dependent on the domain layer. There will likely be a shared library so they can speak the same language.

## Running

```bash
dotnet run
```

## Dependencies

This project _shouldn't_ have any dependencies on other projects in this app. This layer does have a dependency on the actual database, but that should be properly abstracted such that the data implementation could easily be swapped.

## Other notes

None so far.