FROM microsoft/dotnet:2.2-sdk-alpine AS Builder
WORKDIR /app
COPY . .
RUN ${DOTNET_RESTORE_PRE} && dotnet restore && dotnet publish -c Release -o /out
CMD ["cp","-r","/out/","/tmp/"]

FROM microsoft/dotnet:2.2-aspnetcore-runtime-alpine

WORKDIR /app
COPY --from=Builder /out/ .
EXPOSE 5060
#CMD ["dotnet","Sample.RabbitMQ.MySql.dll"]
CMD ["sleep","9999999999"]