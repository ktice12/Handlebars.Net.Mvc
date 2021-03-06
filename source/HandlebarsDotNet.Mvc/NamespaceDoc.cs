﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// Things left to do/consider before this is version 1:
// Write the remaining documentation (probably better suited for GitHub's Wiki or Pages): How the model is turned into a dictionary (or dynamic), that IHandlebars is per area+controller combination, about layouts and PartialView, ...
// Review the other TODO:s in the source
// Remove the ramblings about "useCache"? Maybe use it as the built-in view engines do?

// Future:
// Consider making ICache public.
// Add an example MVC application that uses this view engine exclusively. An extended version would be to use the .hbs files client-side too.
// Provide an example using Webstart.Bundling in order to allow the view to render bundles in the layout (a rough stand-in already exists by using sections, but without being able to check section contents before possibly adding is limiting)
// Think of some way to use resources (for localization)? Probably not: clients can register helpers that do it the way they want, or use a different IPathsProvider implementation if it is only "file-based internationalization" they want.
// Syntax highlighter in Visual Studio for ".hbs" files (if it doesn't exist): looks like it somewhat does already, with VS Web Essentials (?).

// Ongoing effort:
// Add unit tests. Both for ensuring the code in this project works as intended but also that assumptions about how Handlebars.Net works (or rather how it's used here) still holds.
// Add integration tests so the whole pipeline from source ".hbs" to rendered HTML works as intended when served by IIS. And that the cache usage is as intended - both for a VirtualPathProvider that supports CacheDependency and one that doesn't.

// Suggested Handlebars changes
// ----------------------------
// Support Html and Bundles helpers
//		Meaning allow eg {{Html.ActionLink ...}} in a view file. I don't know if it works, haven't tried.
//		If it doesn't work yet I see two possible ways:
//			* Register a helper with the full name "Html.ActionLink". Handlebars would need to be changed so that if "Html" and/or "ActionLink" isn't found in the context it would look for the complete name "Html.ActionLink".
//			* Register a dictionary with the name "Html" in the model (context) data. The keys in the dictionary are the methodnames and their value is a Func<>. Handlebars would need to support that last part.
//		It is also possible this isn't important because one could use underscore notation instead of dot notation in order to get some "namespacing" for the helpers.
//		(This is what I opted for. Keeping the note above for future re-evaluation.)
//
// Make a PR to Handlebars.Net so it can be CLSCompliant, meaning we can remove the [CLSCompliant(false)] attributes wherever types from the Handlebars.Net library are used.
//
// Maybe somehow use "@" for variable names to align the functionality with Ghost.

namespace HandlebarsDotNet.Mvc
{
	/// <summary>
	/// This namespace contains an implementation for using <see href="https://github.com/rexm/Handlebars.Net" target="_blank">Handlebars</see> as a view engine in ASP.NET MVC (server-side).
	/// </summary>
	/// <seealso href="https://github.com/rexm/Handlebars.Net" target="_blank">Handlebars.Net - Blistering-fast Handlebars.js templates in your .NET application.</seealso>
	/// <seealso href="http://handlebarsjs.com/" target="_blank">Handlebars.js - The syntax is described here (but note that is the client-side Javascript compiler)</seealso>
	[CompilerGenerated]
	class NamespaceDoc
	{
	}
}
