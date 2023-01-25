
Before using the Server API project(GraphQL.POC.API) first:
1] Create the database using the scripts provided in the project folder named "Database Scripts"
2] After DB creation, add the connection string in appsetting.json for the project.

before running Client project(GraphQL.API.Client)
1] Check if correct URL updated in appsettings.json "GraphQLURI" parameter. (This should be actual URL of the server project with the host and port number)
2] Make sure client is running on different port that of server project. 
	Change this in properties=> launchsettings.json=> GraphQL.API.Client=>ApplicationURL section