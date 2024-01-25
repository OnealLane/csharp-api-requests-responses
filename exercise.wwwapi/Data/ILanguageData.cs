using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{
    public interface ILanguageData
    {

        Language AddLanguage(string name);

        IEnumerable<Language> GetLanguages();

        Language GetLanguage(string name);

        Language UpdateLanguage(string name);

        Language DeleteLanguage(string name);
    }
}
