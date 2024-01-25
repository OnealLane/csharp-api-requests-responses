using exercise.wwwapi.Data;
using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public class LanguageRepository : ILanguageRepository
    {
        private ILanguageData _languageDatabase;

        public LanguageRepository(ILanguageData languageDatabase)
        {
            _languageDatabase = languageDatabase;
        }

        public Language DeleteLanguage(string name)
        {
            return _languageDatabase .DeleteLanguage(name);
        }

        public Language GetLanguage(string name)
        {
            return _languageDatabase.GetLanguage(name);
        }

        public IEnumerable<Language> GetLanguages()
        {
            return _languageDatabase.GetLanguages();
        }

        public Language PostLanguage(string language)
        {
           return _languageDatabase.AddLanguage(language);
           
        }

        public Language PutLanguage(string name)
        {
            return _languageDatabase.UpdateLanguage(name);
        }
    }
}
