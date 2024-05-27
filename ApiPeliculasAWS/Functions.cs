using System.Net;
using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Annotations;
using Amazon.Lambda.Annotations.APIGateway;
using ApiPeliculasAWS.Repositories;
using ApiPeliculasAWS.Models;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ApiPeliculasAWS;

public class Functions
{
    private RepositoryPeliculas repo;

    public Functions(RepositoryPeliculas repo)
    {
        this.repo = repo;
    }

  


    [LambdaFunction]
    [RestApi(LambdaHttpMethod.Get, "/")]
    public async Task<IHttpResult> Get(ILambdaContext context)
    {
        context.Logger.LogInformation("Handling the 'Get' Request");
        List<Pelicula> peliculas = await this.repo.GetPeliculasAsync();

        return HttpResults.Ok(peliculas);
    }


    [LambdaFunction]
    [RestApi(LambdaHttpMethod.Get, "/find/{id}")]
    public async Task<IHttpResult> Find(int id, ILambdaContext context)
    {
        context.Logger.LogInformation("Handling the 'Find' Request");
        Pelicula pelicula = await this.repo.FindPeliculaAsync(id);

        return HttpResults.Ok(pelicula);
    }

    [LambdaFunction]
    [RestApi(LambdaHttpMethod.Get, "/getactor/{actor}/")]
    public async Task<IHttpResult> GetActor(string actor,ILambdaContext context)
    {
        context.Logger.LogInformation("Handling the 'Get' Request");
        List<Pelicula> peliculas = await this.repo.GetPeliculasByActor(actor);

        return HttpResults.Ok(peliculas);
    }


}
