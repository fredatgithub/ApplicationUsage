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

    private static readonly Dictionary<string, string> _AmericanStates = new Dictionary<string, string> { { "Alabama", "AL" }, { "Alaska", "AK" }, { "Arizona", "AZ" }, { "Arkansas", "AR" }, { "California","CA" }, { "Colorado", "CO" }, { "Connecticut", "CT" }, { "Delaware", "DE" }, { "Florida", "FL" }, { "Georgia", "GA" }, { "Hawaii", "HI" }, { "Idaho", "ID" }, { "Illinois", "IL" }, { "Indiana", "IN" }, { "Iowa", "IA" },    { "Kansas", "KS" }, { "Kentucky", "KY" }, { "Louisiana", "LA" }, { "Maine", "ME" }, { "Maryland", "MD" },    { "Massachusetts", "MA" }, { "Michigan", "MI" }, { "Minnesota", "MN" }, { "Mississippi", "MS" },    { "Missouri", "MO" },    { "Montana", "MT" }, { "Nebraska", "NE" }, { "Nevada", "NV" }, { "New Hampshire", "NH" }, { "New Jersey", "NJ" }, { "New Mexico", "NM" }, { "New York", "NY" }, { "North Carolina", "NC" },    { "North Dakota", "ND" }, { "Ohio", "OH" }, { "Oklahoma", "OK" }, { "Oregon", "OR" }, { "Pennsylvania", "PA" }, { "Rhode Island", "RI" }, { "South Carolina", "SC" }, { "South Dakota", "SD" }, { "Tennessee", "TN" }, { "Texas", "TX" }, { "Utah", "UT" }, { "Vermont", "VT" }, { "Virginia", "VA" }, { "Washington", "WA" }, { "West Virginia", "WV" }, { "Wisconsin", "WI" }, { "Wyoming", "WY" }};

    private static readonly List<string> _Countries = new List<string>
    {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia",  "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium",    "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cabo Verde", "Cambodia", "Cameroon", "Canada", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Democratic Republic of the Congo", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Israel", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Kuwait", "Kyrgyzstan",   "Laos",  "Latvia",  "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg",   "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania",    "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", "Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "North Korea", "North Macedonia", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", "Poland", "Portugal", "Qatar", "Romania", "Russia", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Saint Vincent and the Grenadines", "Samoa", "San Marino", "Sao Tome and Principe",  "Saudi Arabia", "Senegal", "Serbia", "Seychelles", "Sierra Leone", "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", "South Korea", "South Sudan", "Spain", "Sri Lanka", "Sudan", "Suriname", "Sweden", "Switzerland", "Syria", "Taiwan", "Tajikistan", "Tanzania", "Thailand", "Timor-Leste", "Togo", "Tonga", "Trinidad and Tobago", "Tunisia", "Turkey", "Turkmenistan", "Tuvalu", "Uganda", "Ukraine", "United Arab Emirates", "United Kingdom", "United States", "Uruguay", "Uzbekistan", "Vanuatu", "Vatican City",  "Venezuela", "Vietnam", "Yemen", "Zambia","Zimbabwe"};

    /// <summary>
    /// Returns the name of a randomly selected U.S. state.
    /// </summary>
    /// <remarks>The selection is uniformly random among all states currently present in the internal
    /// collection. This method is thread-safe and can be called multiple times to obtain different results.</remarks>
    /// <returns>A string containing the name of a U.S. state chosen at random from the available list.</returns>
    public static string GetRandomState()
    {
      var states = new List<string>(_AmericanStates.Keys);
      return states[_random.Next(states.Count)];
    }

    /// <summary>
    /// Returns a randomly selected two-letter abbreviation for a U.S. state.
    /// </summary>
    /// <remarks>This method can be used to generate random state abbreviations for testing, sampling, or
    /// demonstration purposes. The selection is uniformly random among all U.S. states.</remarks>
    /// <returns>A string containing the abbreviation of a randomly chosen U.S. state. The abbreviation will always be two
    /// uppercase letters.</returns>
    public static string GetRandomStateAbbreviation()
    {
      var abbreviations = new List<string>(_AmericanStates.Values);
      return abbreviations[_random.Next(abbreviations.Count)];
    }

    /// <summary>
    /// Returns the name and abbreviation of a randomly selected U.S. state.
    /// </summary>
    /// <remarks>The method selects a state at random from the complete list of U.S. states. Each call may
    /// return a different state. The returned string is formatted as "StateName (Abbreviation)".</remarks>
    /// <returns>A string containing the full name of a U.S. state followed by its abbreviation in parentheses. For example,
    /// "California (CA)".</returns>
    public static string GetRandomStateWithAbbreviation()
    {
      var states = new List<KeyValuePair<string, string>>(_AmericanStates);
      var randomState = states[_random.Next(states.Count)];
      return $"{randomState.Key} ({randomState.Value})";
    }

    /// <summary>
    /// Contains the list of supported email domains used for validation or filtering purposes.
    /// </summary>
    private static readonly List<string> _EmailDomains = new List<string> {
        "gmail.com", "yahoo.com", "outlook.com", "hotmail.com", "aol.com"
    };

    /// <summary>
    /// Generates a random email address using the specified first and last names.
    /// </summary>
    /// <remarks>The generated email address includes a random numeric suffix and a randomly selected domain.
    /// This method is useful for creating test data or placeholder email addresses.</remarks>
    /// <param name="firstName">The first name to include in the email address. Cannot be null or empty.</param>
    /// <param name="lastName">The last name to include in the email address. Cannot be null or empty.</param>
    /// <returns>A randomly generated email address in the format 'firstname.lastname####@domain', where the names are lowercase
    /// and the domain is selected at random.</returns>
    public static string GetRandomEmail(string firstName, string lastName)
    {
      string domain = _EmailDomains[_random.Next(_EmailDomains.Count)];
      int number = _random.Next(1, 9999);
      return $"{firstName.ToLower()}.{lastName.ToLower()}{number}@{domain}";
    }

    /// <summary>
    /// Generates a random U.S. phone number in the standard format.
    /// </summary>
    /// <remarks>The generated phone number is intended for testing or placeholder purposes and does not
    /// correspond to an actual assigned number. The area code and exchange are chosen from 200 to 998, and the line
    /// number from 1000 to 9998, avoiding commonly reserved or invalid ranges.</remarks>
    /// <returns>A string representing a randomly generated phone number in the format "(XXX) XXX-XXXX". Each segment is within
    /// typical valid ranges for U.S. phone numbers.</returns>
    public static string GetRandomPhoneNumber()
    {
      int areaCode = _random.Next(200, 999);
      int exchange = _random.Next(200, 999);
      int lineNumber = _random.Next(1000, 9999);
      return $"({areaCode}) {exchange}-{lineNumber}";
    }

    /// <summary>
    /// Generates a random user profile as a formatted string containing name, age, city, email, and phone number.
    /// </summary>
    /// <remarks>The returned profile is intended for testing, demonstration, or placeholder purposes and does
    /// not represent real user data. Each call produces a new random profile.</remarks>
    /// <returns>A string representing a randomly generated user profile. The string includes the user's name, age, city, email
    /// address, and phone number in a human-readable format.</returns>
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

    /// <summary>
    /// Generates a random integer representing an age within the specified range.
    /// </summary>
    /// <param name="min">The inclusive lower bound of the age range. Must be greater than zero and less than or equal to <paramref
    /// name="max"/>.</param>
    /// <param name="max">The inclusive upper bound of the age range. Must be greater than or equal to <paramref name="min"/>.</param>
    /// <returns>A random integer between <paramref name="min"/> and <paramref name="max"/>, inclusive.</returns>
    public static int GetRandomAge(int min = 1, int max = 120)
    {
      return _random.Next(min, max + 1);
    }

    /// <summary>
    /// Returns the name of a randomly selected American city.
    /// </summary>
    /// <returns>A string containing the name of an American city chosen at random from the available list.</returns>
    public static string GetRandomCity()
    {
      return _AmericanCities[_random.Next(_AmericanCities.Count)];
    }

    /// <summary>
    /// Generates a list of random profile names.
    /// </summary>
    /// <param name="count">The number of random profiles to generate. Must be non-negative.</param>
    /// <returns>A list of strings containing randomly generated profile names. The list will contain exactly the specified
    /// number of profiles. If count is zero, the list will be empty.</returns>
    public static List<string> GenerateRandomProfiles(int count)
    {
      var profiles = new List<string>();
      for (int i = 0; i < count; i++)
      {
        profiles.Add(GetRandomProfile());
      }

      return profiles;
    }

    /// <summary>
    /// Returns a randomly selected English first name based on the specified gender.
    /// </summary>
    /// <param name="isMale">A value indicating whether to return a male first name. Specify <see langword="true"/> to return a male name;
    /// otherwise, a female name is returned.</param>
    /// <returns>An English first name chosen at random. The name corresponds to the specified gender.</returns>
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

    /// <summary>
    /// Generates a random full name composed of a first name and a last name.
    /// </summary>
    /// <param name="isMale">Specifies whether the generated first name should be male. If <see langword="true"/>, a male first name is used;
    /// otherwise, a female first name is used.</param>
    /// <returns>A string containing the randomly generated full name. The format is "FirstName LastName".</returns>
    public static string GetRandomFullName(bool isMale)
    {
      return $"{GetRandomFirstName(isMale)} {GetRandomLastName()}";
    }

    /// <summary>
    /// Returns a randomly selected English first name, choosing between male and female names with equal probability.
    /// </summary>
    /// <remarks>This method is useful for generating sample data or test values where a random English first
    /// name is needed. The selection is evenly distributed between male and female names. Thread safety is not
    /// guaranteed; concurrent calls may result in unpredictable behavior if the underlying random generator is not
    /// thread-safe.</remarks>
    /// <returns>A string containing a randomly chosen English first name. The name will be selected from either the male or
    /// female name list.</returns>
    public static string GetRandomFirstName()
    {
      bool isMale = _random.Next(2) == 0; // 50% chance
      return isMale
          ? _EnglishMaleFirstNames[_random.Next(_EnglishMaleFirstNames.Count)]
          : _EnglishFemaleFirstNames[_random.Next(_EnglishFemaleFirstNames.Count)];
    }

    /// <summary>
    /// Returns a randomly selected English last name from the available list.
    /// </summary>
    /// <remarks>The returned last name is selected uniformly at random. This method is thread-safe and can be
    /// called multiple times to obtain different results.</remarks>
    /// <returns>A string containing an English last name chosen at random from the internal collection.</returns>
    public static string GetRandomLastName()
    {
      return _EnglishLastNames[_random.Next(_EnglishLastNames.Count)];
    }

    /// <summary>
    /// Generates a random full name composed of a first name and a last name.
    /// </summary>
    /// <remarks>The returned name is intended for use in scenarios where sample or placeholder data is
    /// required, such as testing or demonstration purposes. The method does not guarantee uniqueness across multiple
    /// calls.</remarks>
    /// <returns>A string containing a randomly selected full name in the format "FirstName LastName".</returns>
    public static string GetRandomFullName()
    {
      return $"{GetRandomFirstName()} {GetRandomLastName()}";
    }

    /// <summary>
    /// Generates a list of randomly created full names.
    /// </summary>
    /// <remarks>This method is useful for creating sample data or testing scenarios where random names are
    /// required. The format and uniqueness of the generated names depend on the implementation of the underlying random
    /// name generator.</remarks>
    /// <param name="count">The number of full names to generate. Must be non-negative.</param>
    /// <returns>A list of strings containing randomly generated full names. The list will be empty if <paramref name="count"/>
    /// is zero.</returns>
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
