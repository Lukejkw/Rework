![Rework Logo](https://raw.githubusercontent.com/Lukejkw/Rework/master/rw_logo.png "Rework Logo")

# Rework  [![Build status](https://ci.appveyor.com/api/projects/status/gpo5a4kjm97p7ews?svg=true)](https://ci.appveyor.com/project/Lukejkw/rework)

A simple library containing all the helper methods that you have probably written a million times.

If you have methods that your think should be included, please put in a pull request.

## NuGet

Install via NuGet: ``` Install-Package Rework ```

[Or click here to go to the package landing page](https://www.nuget.org/packages/Rework)

## Require

```javascript
// Make sure that object is not null
Require.NotNull(yourObject);
Require.NotNullOrEmpty(myCollection);
Require.NotNullOrEmptyOrWhitespace(someString);
```

## Strings

```javascript
"my awesome string".Slugify(); // Returns "my-awesome-string"
```

## Check

```javascript
// Easily check variables for null or empty
object thing = null;
List<Person> peopleNull = null;
List<Person> peopleEmpty = new List<Person>();

Check.NotNull(thing); // Returns false
Check.HasItems(peopleNull); // Returns false
Check.HasItems(peopleEmpty); // Returns false
```

## Range

Some handy methods for checking if a value falls in acertain range

``` javascript
var dateToCheck = new DateTime(2016, 01, 01);
var dateToUse = new DateTime(2016, 01, 02);
Range.Before(dateToCheck, dateToUse); // Returns True

// Returns True
Range.Between(new DateTime(2016, 01, 1), new DateTime(2016, 01, 3), new DateTime(2016, 01, 2));

// Returns True
Range.After(new DateTime(2016, 01, 02), new DateTime(2016, 01, 01));
```

## Pretty

```javascript
// Returns a readable relative time between 2 DateTime values

// Usage example for time elapsed since writing this readme.
// I can't tell you what it will return because the DateTime.Now will take the current Date and Time.
Pretty.GetRelativeTimeBetweenDates(new DateTime(2016, 11, 11, 9, 45, 0), DateTime.Now);

//Here are some examples from the test cases:

// Returns "just now"
Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 1, 0));

// Returns "just now"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 1, 1));

// Returns "1 minute ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 2, 1));

// Returns "2 minutes ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 1, 3, 1));

// Returns "59 minutes ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 2, 0, 0));

// Returns "1 hour ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 1, 1, 0), new DateTime(2001, 1, 1, 2, 2, 0));

// Returns "23 hours ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1, 0, 0, 1), new DateTime(2001, 1, 2, 0, 0, 0));

// Returns "yesterday"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 2));

// Returns "yesterday"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 2, 10, 0, 0));

// Returns "2 days ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 3));

// Returns "1 week ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 8));

// Returns "2 weeks ago"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 1, 17));

// Returns "01 Jan 2001"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 1, 1), new DateTime(2001, 2, 2));

// Returns "02 Feb 2001"
string result = Pretty.GetRelativeTimeBetweenDates(new DateTime(2001, 2, 2), new DateTime(2001, 1, 1));


## Crypto

Helpful methods for encrypting strings
Currently generates SHA1, SHA256, SHA512 hashed strings

``` javascript
"abc".ToSHA(Crypto.SHA_Type.SHA1); // Returns "A9993E364706816ABA3E25717850C26C9CD0D89D"

"abc".ToSHA(Crypto.SHA_Type.SHA256); // Returns "BA7816BF8F01CFEA414140DE5DAE2223B00361A396177A9CB410FF61F20015AD"

"abc".ToSHA(Crypto.SHA_Type.SHA512); //Returns "DDAF35A193617ABACC417349AE20413112E6FA4E89A97EA20A9EEEE64B55D39A2192992A274FC1A836BA3C23A3FEEBBD454D4423643CE80E2A9AC94FA54CA49F"
```

### More coming soon!

