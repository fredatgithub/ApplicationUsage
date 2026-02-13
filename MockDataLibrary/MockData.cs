using System;
using System.Collections.Generic;

namespace MockDataLibrary
{
  public static class MockData
  {
    private static readonly Random _random = new Random();

    private static readonly List<string> _EnglishMaleFirstNames = new List<string> { "Aiden", "Alexander", "Andrew", "Austin", "Benjamin", "Bill", "Blake", "Brandon", "Bruce", "Carter", "Charles", "Chase", "Christopher", "Cody", "Colton", "Cooper", "Daniel", "David", "Dylan", "Ethan", "Fred", "Henry", "Hunter", "Jackson", "Jacob", "James", "Jesse", "Joe", "John", "Joseph", "Kyle", "Levi", "Liam", "Logan", "Lucas", "Luke", "Mason", "Matthew", "Michael", "Nathaniel", "Noah", "Peter", "Robert", "Ryan", "Samuel", "Sebastian", "Theodore", "Thomas", "Trevor", "Tucker", "Tyler", "William", "Wyatt" };

    private static readonly List<string> _EnglishFemaleFirstNames = new List<string> {
    "Abigail", "Addison", "Adeline", "Adriana", "Ainsley", "Alexandra", "Alexis", "Alice", "Alicia", "Allison",
    "Alyssa", "Amanda", "Amber", "Amelia", "Amy", "Ana", "Andrea", "Angelina", "Anna", "Annabelle",
    "Ariana", "Arianna", "Ashley", "Aspen", "Athena", "Aubrey", "Audrey", "Aurora", "Ava", "Bailey",
    "Barbara", "Beatrice", "Bella", "Bethany", "Beverly", "Bianca", "Blair", "Bonnie", "Brenda", "Brianna",
    "Brittany", "Brooke", "Brooklyn", "Camila", "Candace", "Caroline", "Cassandra", "Catherine", "Charlotte", "Chelsea", "Chloe", "Christina", "Claire", "Clara", "Cora", "Courtney", "Crystal", "Daisy", "Dakota", "Danielle", "Daphne", "Deborah", "Delilah", "Destiny", "Diana", "Dominique", "Donna", "Eleanor", "Elena", "Elizabeth", "Ella", "Ellie", "Emily", "Emma", "Erica", "Erin", "Evelyn", "Faith", "Fiona", "Gabriella",     "Giselle", "Grace", "Hailey", "Hannah", "Harper", "Hazel", "Heather", "Heidi", "Holly", "Isabella", "Ivy", "Jade", "Jamie", "Jasmine", "Jennifer", "Jessica", "Jocelyn", "Jordan", "Julia", "Juliana", "Kaitlyn", "Katherine", "Kayla", "Keira", "Kennedy", "Kimberly", "Kinsley", "Kylie", "Laila", "Lauren", "Layla", "Leah", "Lillian", "Lily", "Lucy", "Luna", "Mackenzie", "Madeline", "Madison", "Makayla", "Maria", "Maya", "Megan", "Melanie", "Melissa", "Mia", "Michelle", "Mila", "Miranda", "Molly", "Naomi", "Natalie", "Nicole", "Nora", "Olivia", "Paige", "Penelope", "Peyton", "Phoebe", "Piper", "Rachel", "Rebecca", "Riley", "Rose", "Ruby", "Sadie", "Samantha", "Sarah", "Savannah", "Scarlett", "Serena", "Sienna", "Sophia", "Stella", "Summer", "Sydney", "Taylor", "Trinity", "Valerie", "Vanessa", "Victoria", "Violet", "Whitney", "Willow", "Zoe", "Zoey"};

    private static readonly List<string> _EnglishLastNames = new List<string> { "Adams", "Allen", "Anderson", "Bailey", "Baker", "Barnes", "Bell", "Bennett", "Brooks", "Brown", "Butler", "Campbell", "Carter", "Clark", "Collins", "Cook", "Cooper", "Cox", "Davis", "Diaz", "Edwards", "Evans", "Foster", "Garcia", "Gonzalez", "Gray", "Green", "Griffin", "Hall", "Harris", "Hernandez", "Hill", "Howard", "Hughes", "Jackson", "James", "Johnson", "Jones", "Kelly", "King", "Lee", "Lewis", "Long", "Lopez", "Martin", "Martinez", "Miller", "Mitchell", "Moore", "Morgan", "Morris", "Murphy", "Nelson", "Nguyen", "Parker", "Perez", "Perry", "Powell", "Price", "Reed", "Richardson", "Rivera", "Roberts", "Robinson", "Rodriguez", "Ross", "Russell", "Sanchez", "Sanders", "Scott", "Shaw", "Smith", "Stewart", "Taylor", "Thomas", "Thompson", "Torres", "Turner", "Walker", "Ward", "Washington", "Watson", "White", "Williams", "Wilson", "Wood", "Wright", "Young" };

    private static readonly List<string> _AmericanCities = new List<string> { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia", "San Antonio", "San Diego", "Dallas", "San Jose", "Austin", "Jacksonville", "Fort Worth", "Columbus", "Charlotte", "San Francisco", "Indianapolis", "Seattle", "Denver", "Washington" };

    private static readonly Dictionary<string, string> _AmericanStates = new Dictionary<string, string>
{
    { "Alabama", "AL" }, { "Alaska", "AK" }, { "Arizona", "AZ" }, { "Arkansas", "AR" }, { "California","CA" }, { "Colorado", "CO" }, { "Connecticut", "CT" }, { "Delaware", "DE" }, { "Florida", "FL" }, { "Georgia", "GA" }, { "Hawaii", "HI" }, { "Idaho", "ID" }, { "Illinois", "IL" }, { "Indiana", "IN" }, { "Iowa", "IA" },    { "Kansas", "KS" }, { "Kentucky", "KY" }, { "Louisiana", "LA" }, { "Maine", "ME" }, { "Maryland", "MD" },    { "Massachusetts", "MA" }, { "Michigan", "MI" }, { "Minnesota", "MN" }, { "Mississippi", "MS" },    { "Missouri", "MO" },    { "Montana", "MT" }, { "Nebraska", "NE" }, { "Nevada", "NV" }, { "New Hampshire", "NH" }, { "New Jersey", "NJ" }, { "New Mexico", "NM" }, { "New York", "NY" }, { "North Carolina", "NC" },    { "North Dakota", "ND" }, { "Ohio", "OH" }, { "Oklahoma", "OK" }, { "Oregon", "OR" }, { "Pennsylvania", "PA" }, { "Rhode Island", "RI" }, { "South Carolina", "SC" }, { "South Dakota", "SD" }, { "Tennessee", "TN" }, { "Texas", "TX" }, { "Utah", "UT" }, { "Vermont", "VT" }, { "Virginia", "VA" }, { "Washington", "WA" }, { "West Virginia", "WV" }, { "Wisconsin", "WI" }, { "Wyoming", "WY" }};

    private static readonly List<string> _Countries = new List<string>
    {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia",  "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium",    "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan",   "Laos",  "Latvia",  "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg",   "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania",    "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe",  "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City",  "Venezuela", "Vietnam", "Yemen", "Zambia","Zimbabwe"};

    // 1) Retourne un état aléatoire (nom complet)
    public static string GetRandomState()
    {
      var states = new List<string>(_AmericanStates.Keys);
      return states[_random.Next(states.Count)];
    }

    // 2) Retourne une abréviation d’état aléatoire (ex: CA, NY)
    public static string GetRandomStateAbbreviation()
    {
      var abbreviations = new List<string>(_AmericanStates.Values);
      return abbreviations[_random.Next(abbreviations.Count)];
    }

    // 3) Retourne un état + son abréviation (ex: "California (CA)")
    public static string GetRandomStateWithAbbreviation()
    {
      var states = new List<KeyValuePair<string, string>>(_AmericanStates);
      var randomState = states[_random.Next(states.Count)];
      return $"{randomState.Key} ({randomState.Value})";
    }

    private static readonly List<string> _EmailDomains = new List<string> {
        "gmail.com", "yahoo.com", "outlook.com", "hotmail.com", "aol.com"
    };

    // Email aléatoire
    public static string GetRandomEmail(string firstName, string lastName)
    {
      string domain = _EmailDomains[_random.Next(_EmailDomains.Count)];
      int number = _random.Next(1, 9999);
      return $"{firstName.ToLower()}.{lastName.ToLower()}{number}@{domain}";
    }

    // Numéro de téléphone aléatoire (format américain)
    public static string GetRandomPhoneNumber()
    {
      int areaCode = _random.Next(200, 999);
      int exchange = _random.Next(200, 999);
      int lineNumber = _random.Next(1000, 9999);
      return $"({areaCode}) {exchange}-{lineNumber}";
    }

    // Génère un profil complet
    public static string GetRandomProfile()
    {
      string firstName = GetRandomFirstName();
      string lastName = GetRandomLastName();
      int age = GetRandomAge();
      string city = GetRandomCity();
      string email = GetRandomEmail(firstName, lastName);
      string phone = GetRandomPhoneNumber();

      return $"Name: {firstName} {lastName}, Age: {age}, City: {city}, Email: {email}, Phone: {phone}";
    }

    public static string GetMockData()
    {
      return "define what to return";
    }

    // Génère un âge aléatoire entre min et max
    public static int GetRandomAge(int min = 1, int max = 120)
    {
      return _random.Next(min, max + 1);
    }

    // Génère une ville américaine aléatoire
    public static string GetRandomCity()
    {
      return _AmericanCities[_random.Next(_AmericanCities.Count)];
    }

    // Génère une liste de profils complets
    public static List<string> GenerateRandomProfiles(int count)
    {
      var profiles = new List<string>();
      for (int i = 0; i < count; i++)
      {
        profiles.Add(GetRandomProfile());
      }
      return profiles;
    }

    public static string GetRandomFirstName(bool isMale)
    {
      if (isMale)
      {
        return _EnglishMaleFirstNames[_random.Next(_EnglishMaleFirstNames.Count)];
      }
      else
      {
        return _EnglishFemaleFirstNames[_random.Next(_EnglishFemaleFirstNames.Count)];
      }
    }

    public static string GetRandomFullName(bool isMale)
    {
      return $"{GetRandomFirstName(isMale)} {GetRandomLastName()}";
    }

    // Méthode pour générer un prénom aléatoire (homme ou femme selon un tirage aléatoire)
    public static string GetRandomFirstName()
    {
      bool isMale = _random.Next(2) == 0; // 50% chance
      return isMale
          ? _EnglishMaleFirstNames[_random.Next(_EnglishMaleFirstNames.Count)]
          : _EnglishFemaleFirstNames[_random.Next(_EnglishFemaleFirstNames.Count)];
    }

    // Méthode pour générer un nom de famille aléatoire
    public static string GetRandomLastName()
    {
      return _EnglishLastNames[_random.Next(_EnglishLastNames.Count)];
    }

    // Méthode pour générer un nom complet aléatoire
    public static string GetRandomFullName()
    {
      return $"{GetRandomFirstName()} {GetRandomLastName()}";
    }

    // Génère une liste de noms complets aléatoires
    public static List<string> GenerateRandomFullNames(int count)
    {
      var names = new List<string>();
      for (int i = 0; i < count; i++)
      {
        names.Add(GetRandomFullName());
      }

      return names;
    }
  }
}
