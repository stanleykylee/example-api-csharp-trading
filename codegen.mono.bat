@REM wget https://repo1.maven.org/maven2/io/swagger/codegen/v3/swagger-codegen-cli/3.0.54/swagger-codegen-cli-3.0.54.jar -O swagger-codegen-cli.jar

java -jar swagger-codegen-cli.jar generate -i ./swagger/openapi.json ^
  -l csharp ^
  -o services-api ^
  -DapiTests=false ^
  -DmodelTests=false ^
  --reserved-words-mappings base=@base,params=@params,readonly=@readonly ^
  --additional-properties=packageName=Tradovate.Services,optionalProjectFile=true,excludeTests=true,packageGuid={1C715F6B-E613-4F6D-8B68-189A9CFABEA1}