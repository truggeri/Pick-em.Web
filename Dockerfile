FROM microsoft/dotnet:2.1-aspnetcore-runtime
EXPOSE 5000

COPY src/Pick-em.Web/out/ /app/

WORKDIR /app
ENTRYPOINT ["dotnet", "Pick-em.Web.dll"]
