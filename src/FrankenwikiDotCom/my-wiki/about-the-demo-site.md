---
title: About the demo site
categories: about, nancy, owin, iis
---

This is a demonstration site that uses both the core 
[Frankenwiki](https://www.nuget.org/packages/frankenwiki/) package and the 
[Frankenwiki.Host.Nancy](https://www.nuget.org/packages/frankenwiki.host.nancy/) 
site which contains some pre-rolled helper Nancy modules
that expose Frankenwiki's functionality. This demonstration site contains the Autofac
initialisation steps and the [Razor templates](/wiki/customising-the-demo-site) 
used to render the site. It also contains the
wiki pages themselves - Markdown files and supplementary assets contained within the
`my-wiki` and `Content` folders.

The Nancy site is an OWIN application on the IIS host. Initialisation starts in `Startup.cs`,
which creates the Autofac container and sets up Nancy. The Autofac initialisation includes
registering various Frankenwiki and Frankenwiki.Host.Nancy services as singletons and setting
up some configuration. The Nancy initialisation is in the `Bootstrapper` class, which sets up 
Frankenwiki and performs the one-off generation of the wiki from the source files (in the 
`my-wiki` folder).

Frankenwiki is configured to use an in-memory store, which is the only store currently 
available. The wiki generation includes converting all of the Markdown into HTML, along with
indexing the links.

The Frankenwiki.Host.Nancy package includes a number of Nancy modules which provide a web-based
interface to Frankenwiki's features. The modules then refer to the Razor templates in this site.

