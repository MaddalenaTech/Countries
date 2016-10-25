# Countries

ISO 3166 countries library, including:
  - Common Name
  - Official Name
  - TLD
  - Country code two letter
  - ISO numeric code
  - Country code three letter
  - CIOC
  - Currencies
  - CallingCodes
  - Capital
  - AlternativeSpellings
  - Region
  - SubRegion
  - Borders
  - Landlocked
  - Area in square kilometers

## Usage
```c
        public ActionResult Home(Func<string> mustache)
        {
			//instancing a country
            var country = Country.Albania;
            Console.WriteLine(country);
			
			//linq queries
            var founds = Country.All.Where(x=>x.Landlocked == true && x.Currencies.Contains("EUR"));

			var usa  = Country.FromCode(CountryCode.US);
        }
````
