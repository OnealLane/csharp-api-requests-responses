using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface ILanguageRepository
    {
        Language PostLanguage(string language);

        IEnumerable<Language> GetLanguages();

        Language GetLanguage(string name);

        Language PutLanguage(string name);

        Language DeleteLanguage(string name);
    }
}
