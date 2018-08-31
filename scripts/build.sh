#! /bin/bash

cd src/Pick-em.Web && dotnet restore
dotnet publish -o out
