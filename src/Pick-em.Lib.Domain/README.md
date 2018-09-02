# Pick-em.Lib.Domain

This project is a net standard 2.0 project that focuses on providing the core application logic. This domain layer is not focused on the nuts and bolts of a web app (GETs, POSTs, message queues, etc.), it only focuses on the core application and how it behaves.

## Running

```bash
dotnet run
```

## Dependencies

This project _should_ have a single dependency on Pick-em.Lib.Data. It does __not__ have a dependency on Pick-em.Web nor Pick-em.Lib.Service; that would become a circular dependency. So keep in mind that this layer knows nothing of the gui nor the services - it is focused on how the application works, not the glue.

## Other notes

None so far.