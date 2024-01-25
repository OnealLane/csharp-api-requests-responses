using exercise.wwwapi.Models;
using exercise.wwwapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Diagnostics.Metrics;

namespace exercise.wwwapi.Endpoints
{
    public static class LanguageEndpoint
    {
        public static void ConfigureLanguageEndpoint(this WebApplication app)
        {
            var languageGroup = app.MapGroup("languages");


            languageGroup.MapPost("/", PostLanguage);
            languageGroup.MapGet("/", GetLanguages);
            languageGroup.MapGet("/{name}", GetLanguage);
            languageGroup.MapPut("/{name}", PutLanguage);
            languageGroup.MapDelete("/{name}", DeleteLanguage);


        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetLanguages(ILanguageRepository languageRepository)
        {
            return TypedResults.Ok(languageRepository.GetLanguages());
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> PostLanguage(string language, ILanguageRepository languageRepository)
        {

            var newLanguage = languageRepository.PostLanguage(language);
            return TypedResults.Created(" ", newLanguage);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetLanguage(string name, ILanguageRepository languageRepository)
        {
            return TypedResults.Ok(languageRepository.GetLanguage(name));
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> PutLanguage(string name, ILanguageRepository languageRepository)
        {
            var newLanguage = languageRepository.PutLanguage(name);
            return TypedResults.Created(" ", newLanguage);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteLanguage(string name, ILanguageRepository languageRepository)
        {
            
            return TypedResults.Ok(languageRepository.DeleteLanguage(name));
        }
    }
}