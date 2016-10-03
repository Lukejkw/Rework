# Rework  [![Build status](https://ci.appveyor.com/api/projects/status/gpo5a4kjm97p7ews?svg=true)](https://ci.appveyor.com/project/Lukejkw/rework)

A simple library containing all the helper methods that you have probably written a million times.

If you have methods that your think should be included, please put in a pull request.

## NuGet

Install via NuGet: ``` Install-Package Rework ```

[Or click here to go to the package landing page](https://www.nuget.org/packages/Rework)

## Requires

<pre>

// Make sure that object is not null
Requires.NotNull(yourObject);
Requires.NotNullOrEmpty(myCollection);
Requires.NotNullOrEmpty(myCollection);
Requires.NotNullOrEmptyOrWhitespace(someString);

</pre>

## Strings

<pre>

"my awesome string".Slugify(); // Returns "my-awesome-string"

</pre>

### More coming soon!

