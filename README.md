# DocFx Min Example
Just a minimal example for lupin.

- The example project is contained in the [/source](/source/) directory.
- the [/docs](/docs) directory is where you can write custom markdown articles to include in your site, like getting started pages or whatever
- [index.md](index.md) is the landing page
- [toc.yml](toc.yml) is the initial table of contents for the site, which is how the top navigation bar is built.

Look at the [docfx.json](./docfx.json) configuration file. 

- The `metadata` section is what tells it where to look for csproj files to generate the api documentation.  In this case it's telling it to look for that specific csproj file (relative path from the docfx.json) and to output the metadata it builds in a directory called `api`
```json
"metadata": [
{
    "src": [
    {
        "files": [ "source/ExampleProject/ExampleProject.csproj"]
    }
    ],
    "dest": "api"
}
]
```
- The `build` section tells it what to actually build when it generates the site
  - `content` tells it what content files to look for (in this case any md or yml files)
  - `exclude` tells it what to exclude (we don't want it rerendering the _site over and over in an infinite loop)
  - `resources` are the locations to resource files like images if you create documentation is the `docs` folder
  - `output` is where the build is output to
  - `template` is the template to use. Docfx only has two standard out of the box templates: `default` and `modern`.  Modern requires default so you need to include both.
```json
"build": {
"content": [
    {
    "files": [
        "**/*.{md,yml}"
    ],
    "exclude": [
        "_site/**"
    ]
    }
],
"resource": [
    {
    "files": [
        "images/**"
    ]
    }
],
"output": "_site",
"template": [
    "default",
    "modern"
],
```

Then when you want to serve the site locally to view it just run `dotnet docfx --serve`
When you want to build it to deploy run `dotnet docfx build`