# Nuget Example Project

An example project for a NuGet Package with code coverage, code quality and auto-deploy to nuget.

## Travis-CI

The continuous integration platform used is [Travis-CI](https://travis-ci.com).

There are several variables that need to be set to allow Travis to work correctly with automated builds.

### Setting Environment Variables in Travis-CI

To set environment variables within travis CI follow [this guide.](https://docs.travis-ci.com/user/environment-variables/#defining-variables-in-repository-settings)

### PROJECT_NAME

An essential variable that is required is the `PROJECT_NAME` variable. This is used to specify the project name for the project and allows for all references to the project name to be updated once from within the CI.

This variable should be set to the project name displayed at the end of the github url - <https://github.com/ajwgroup/NugetExampleProject>

### NUGET_KEY

To be able to push the package to nuget in the deployment stage, the `$NUGET_KEY` needs to be set.

The `$NUGET_KEY` can be created by selecting 'API Keys' from the account menu drop down on the nuget website.

From here give the key a friendly name and set the key duration (This is 365 days by default).

If the package has already been published you can select an Available package, or you can specify a Glob pattern for the package(s) that you would like the API key to apply to. It's adviced to create a key for each package that is to be published so that keys can be revoked on a per package basis.

Once the token has been obtained add it to the CI variables as instructed above with the Key name `$NUGET_KEY`.

## Code Coverage

[Codecov](https://codecov.io/gh/ajwgroup/NugetExampleProject) is used for displaying the projects test code coverage.

Code coverage can be seen [here](https://codecov.io/gh/ajwgroup/NugetExampleProject).

**No variables need to be set for the code coverage to published.**

## SonarCloud

[SonarCloud](https://docs.travis-ci.com/user/sonarcloud/) is used to analyse the code and provide feedback on several aspects such as code quality, bugs, potential vulnerabilities among others.

![Add new project](images/AddProjectSonarCloud.png)

![Add project details](images/ProjectDetailsSonarCloud.png)

![Generate/Use Token](images/SonarTokenGenerated.png)

![Open Project Settings in Travis](images/TravisCISettings.png)

![Add Sonar token to CI variables](images/SonarTokenVariable.png)

The sonarcloud token should be set to the key `$SONARCLOUD_TOKEN`.

## Github Pages

[Guide to deploy to github pages](https://docs.travis-ci.com/user/deployment/pages/)

## Badges

For a consistent look it's recommended to use badges available from [shields.io](https://shields.io). Example Badges can be seen below.

- [![License - MIT](https://img.shields.io/github/license/ajwgroup/NugetExampleProject.svg?style=flat-square)](https://github.com/ajwgroup/NugetExampleProject/blob/master/LICENSE)
- [![Build Status](https://img.shields.io/travis/com/ajwgroup/NugetExampleProject/master.svg?logo=travis&style=flat-square)](https://travis-ci.com/ajwgroup/NugetExampleProject)
- [![Issues](https://img.shields.io/github/issues/ajwgroup/NugetExampleProject.svg?style=flat-square)](https://github.com/ajwgroup/NugetExampleProject/issues)
- ![Latest Nuget Release](https://img.shields.io/nuget/v/NugetExampleProject.svg?style=flat-square&link=http://www.nuget.org/packages/NugetExampleProject/&link=http://www.nuget.org/packages/NugetExampleProject/) **Package not published**
- [![Latest Nuget Pre-Release](https://img.shields.io/nuget/vpre/NugetExampleProject.svg?style=flat-square&colorB=yellow&label=nuget-prerelease)](https://www.nuget.org/packages/NugetExampleProject/) **Package not published**
- [![Coverage Status](https://img.shields.io/codecov/c/github/ajwgroup/NugetExampleProject.svg?logo=codecov&style=flat-square)](https://codecov.io/gh/ajwgroup/NugetExampleProject)
- [![Last commit](https://img.shields.io/github/last-commit/ajwgroup/NugetExampleProject.svg?style=flat-square)](https://github.com/ajwgroup/NugetExampleProject)
- [![Code Quality](https://sonarcloud.io/api/project_badges/measure?project=ajwgroup_NugetExampleProject&metric=alert_status)](https://sonarcloud.io/dashboard?id=ajwgroup_NugetExampleProject)

## ToDo

- [ ] Add in automated documentation generation
- [ ] Generate a visual studio template project