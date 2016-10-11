# ![Rework Logo](https://raw.githubusercontent.com/Lukejkw/Rework/master/rw_logo.png "Rework Logo") Rework  [![Build status](https://ci.appveyor.com/api/projects/status/gpo5a4kjm97p7ews?svg=true)](https://ci.appveyor.com/project/Lukejkw/rework)

A simple library containing all the helper methods that you have probably written a million times.

If you have methods that your think should be included, please put in a pull request.

## NuGet

Install via NuGet: ``` Install-Package Rework ```

[Or click here to go to the package landing page](https://www.nuget.org/packages/Rework)

## Require

<pre>

// Make sure that object is not null
Require.NotNull(yourObject);
Require.NotNullOrEmpty(myCollection);
Require.NotNullOrEmpty(myCollection);
Require.NotNullOrEmptyOrWhitespace(someString);

</pre>

## Strings

<pre>

"my awesome string".Slugify(); // Returns "my-awesome-string"

</pre>

## Check

<pre>

// Easily check variables for null or empty
object thing = null;
List<Person> peopleNull = null;
List<Person> peopleEmpty = new List<Person>();

Check.NotNull(thing); // Returns false
Check.HasItems(peopleNull); // Returns false
Check.HasItems(peopleEmpty); // Returns false

</pre>

## Range

Some handy methods for checking if a value falls in acertain range

<pre>

var dateToCheck = new DateTime(2016, 01, 01);
var dateToUse = new DateTime(2016, 01, 02);
Range.Before(dateToCheck, dateToUse); // Returns True

// Returns True
Range.Between(new DateTime(2016, 01, 1), new DateTime(2016, 01, 3), new DateTime(2016, 01, 2));

// Returns True
Range.After(new DateTime(2016, 01, 02), new DateTime(2016, 01, 01));

</pre>

### More coming soon!

