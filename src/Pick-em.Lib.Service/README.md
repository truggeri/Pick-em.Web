# Pick-em.Lib.Service

This project is a net standard 2.0 project that focuses on providing logic between the gui and domain layer of the project. This logic should not be _application_ logic, it should be glue logic that ties the core application (domain layer) to the interface with users.

## Running

```bash
dotnet run
```

## Dependencies

This project _should_ have a single dependency on Pick-em.Lib.Domain. It does __not__ have a dependency on Pick-em.Web; that would become a circular dependency. So keep in mind that this layer knows nothing of the gui - it simply offers services that the gui can be aware of.

## Other notes

None so far.