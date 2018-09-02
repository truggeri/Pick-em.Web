# Pick-em.Web

This project is a dotnet core asp.net mvc project that will utilize dynamic (server side) pages, but is not a single page application (SPA) of the Angular and Vue.js framework style.

## Running

```bash
dotnet run
```

## Dependencies

This project _should_ have a single dependency on Pick-em.Lib.Service. All data that's retrieved (GET) or added (PUT, POST, PATCH, DELETE) should go through the logical layer of the Service layer, not go further down the stack and NEVER all the way to the database.

## Other notes

None so far.