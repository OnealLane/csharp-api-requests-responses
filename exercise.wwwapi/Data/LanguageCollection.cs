using exercise.wwwapi.Models;

namespace exercise.wwwapi.Data
{

    public class LanguageCollection : ILanguageData
    {
        private List<Language> languages = new List<Language>(){
            new Language("Java"),
            new Language("C#")
        };

        public Language AddLanguage(string language)
        {
            Language newLanguage = new Language(language);
            languages.Add(newLanguage);
            return newLanguage;
        }

        public Language DeleteLanguage(string name)
        {
            var newLanguage = GetLanguage(name);
            languages.Remove(newLanguage);
            return newLanguage;
        }

        public Language GetLanguage(string name)
        {
            Language newLanguage = languages.Where(x => x.name == name).FirstOrDefault();
            return newLanguage;
        }

        public IEnumerable<Language> GetLanguages()
        {
            return languages.ToList();
        }

        public Language UpdateLanguage(string name)
        {
            languages.First().name = name;
            return languages.First();
        }
    }
}
