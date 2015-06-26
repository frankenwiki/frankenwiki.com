---
title: Customising the demo site
categories: nancy, about, customising, customizing, markdown, razor
---

The views for the demo site are in the `Views` folder. To continue using the 
`Frankenwiki.Host.Nancy` helpers the existing views must remain.

The wiki landing page is `index.md`. This is the default page shown when requesting the root of the
wiki (or `/wiki/index`).


## Supplementary assets

The default demo site uses [Twitter Bootstrap](https://getbootstrap.com). Assets can be placed
in the `Content` folder.


## _Layout.cshtml

The global template is in `Views/_Layout.cshtml`. This is the place to change the global style of
the wiki site including the title of the site, the sidebar, the page content and the footer.

Links are relative to the current wiki page,
so use absolute paths to link to scripts, CSS or images.

The title of the current content is in `ViewBag.Title`, which should be included in the 
page title. `ViewBag.Title` is set in each individual page template. There is also a `tools` 
section that gets rendered as an inclusion in a sidebar. 
This can be added to in a template using a section declaration. By default the section should
contain a list of `<li>` elements. See `page.cshtml` for an example.

The body of the page is rendered using the `RenderBody()` command.


## categories.cshtml

This is the content of the "[All categories](/categories)" page. The page model is a
set of categories, each with a [slug](/wiki/slug) and a human-friendly name.


## category.cshtml

This page shows the articles associated with a specific category (`/category/<slug>`). 
Eg. [/category/nancy](/category/nancy).


## page.cshtml

This shows a specific article including the title of the article, the content, and a list of categories
associated with the article if present. Pages use a [basic YAML front-matter](/wiki/yaml-front-matter)
to declare a human friendly
title. If a YAML front-matter isn't present or doesn't declare the title, the page [slug](/wiki/slug)
is humanised.

This template includes a `tools` section, containing a link to the "What links here" page.


## pages-index.cshtml

This is a special page that shows every wiki article existing in the index, organised by the
first letter of the title.


## search-results.cshtml

This shows the results from the search - a list of links to articles containing the search phrase. A 
search box is present in the global template (`_Layout.cshtml`) or a link such as 
`/search?phrase=some+search+phrase` can be hard-coded or crafted.


## search.cshtml

Broken?


## Tools

### tools-what-links-here.cshtml

Shows a list of the articles that link to the selected article (`/what-links-to/<slug>`, eg. 
[/what-links-to/customising-the-demo-site](/what-links-to/customising-the-demo-site)).


