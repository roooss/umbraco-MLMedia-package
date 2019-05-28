# V8 MLMediaLibray

This package is inteneded to extend the Umbraco V8 MediaLibrary with MSFT Custom Vision image classification tagging. 
A Custom Vison Subscription will be needed (free options exist for testing) for this package to create a prediction project in.
A new Media Type is added which extends the existing 'Image' Media Type with a new custom propterty called ML Tags.
The ML Tags property is essentially a comma delimited list of tags that describe the image. Upon uploading a new image, it is sent of to the prediction endpoint and appropriate tags are then returned and stored.
In the event these tags are not appropriate. directly modifying them and then saving will s	end this information back to the model to be retrainied.

These tags are also indexed and cached to keep things performant.

The Media Library will have a new look, the tree will become a list of Distinct tags (with count in brackets). 
The search will allow directly typing a tag or tags to refine the main view. The Upload new ML Image will allow you to predefine tags if desired as well as acquiring others on saving.
Dragging an image on to the main window will also do the same.

To allow easier adding of images a new Custom Media Picker exists that allows filtering by tags through an autocomplete style input.

## Getting Started

Clone the repo. Restore all nuget packages. Build.

Important to know that Web project has a post build task:
`
xcopy /Y /S /D "$(SolutionDir)src\MLMediaPackage.Package\App_Plugins\*" "$(ProjectDir)App_Plugins\"
`

### Prerequisites

VS 2017 etc.

Admin:
admin@admin.com
Admin123456


### Running....

A step by step series of examples that tell you how to get a development env running

Say what the step will be

```
Give the example
```

And repeat

```
until finished
```

End with an example of getting some data out of the system or using it for a little demo

## Running the tests

Explain how to run the automated tests for this system

### Break down into end to end tests

Explain what these tests test and why

```
Give an example
```

### And coding style tests

Explain what these tests test and why

```
Give an example
```

## Deployment

Add additional notes about how to deploy this on a live system

## Built With

* [Dropwizard](http://www.dropwizard.io/1.0.2/docs/) - The web framework used
* [Maven](https://maven.apache.org/) - Dependency Management
* [ROME](https://rometools.github.io/rome/) - Used to generate RSS Feeds

## Contributing

Please read [CONTRIBUTING.md](https://gist.github.com/PurpleBooth/b24679402957c63ec426) for details on our code of conduct, and the process for submitting pull requests to us.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Billie Thompson** - *Initial work* - [PurpleBooth](https://github.com/PurpleBooth)

See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

## Acknowledgments

* Hat tip to anyone whose code was used
* Inspiration
* etc
