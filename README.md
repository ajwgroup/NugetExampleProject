# Nuget Example Project

An example project for a NuGet Package with code coverage, code quality and auto-deploy to nuget

## Travis-CI

The build platform used it [Travis-CI](https://travis-ci.com).

There are several variables that need to be set to allow Travis to work correctly with automated builds.

An essential variable that is required is the `PROJECT_NAME` variable. This is used to specify the project name for the project and allows for all references to the project name to be updated once from within the CI.

### Setting Environment Variables in Travis-CI

To set an environment variable within travis CI...

More information can be found in [this guide.](https://google.com)

## Nuget

Get token add it to CI

## Code Coverage

[Codecov](https://codecov.io/gh/ajwgroup/NugetExampleProject) is used for displaying the projects test code coverage.

No variables need to be set to

## SonarCloud

[SonarCloud](https://docs.travis-ci.com/user/sonarcloud/)

![Add new project](images/AddProjectSonarCloud.png)

![Add project details](images/ProjectDetailsSonarCloud.png)

![Generate/Use Token](images/SonarTokenGenerated.png)

![Open Project Settings in Travis](images/TravisCISettings.png)

![Add Sonar token to CI variables](images/SonarTokenVariable.png)

## Badges

For a consistent look it's recommended to use badges available from [shields.io](https://shields.io) these. Example Badges can be seen below.

[![License - MIT](https://img.shields.io/github/license/ajwgroup/NugetExampleProject.svg?style=flat-square)](https://github.com/ajwgroup/NugetExampleProject/blob/master/LICENSE)
[![Build Status](https://img.shields.io/travis/com/ajwgroup/NugetExampleProject/master.svg?logo=travis&style=flat-square)](https://travis-ci.com/ajwgroup/NugetExampleProject)
[![Issues](https://img.shields.io/github/issues/ajwgroup/NugetExampleProject.svg?style=flat-square)](https://github.com/ajwgroup/NugetExampleProject/issues)
![Latest Nuget Release](https://img.shields.io/nuget/v/NugetExampleProject.svg?style=flat-square&link=http://www.nuget.org/packages/NugetExampleProject/&link=http://www.nuget.org/packages/NugetExampleProject/)
[![Latest Nuget Pre-Release](https://img.shields.io/nuget/vpre/NugetExampleProject.svg?style=flat-square&colorB=yellow&label=nuget-prerelease)](https://www.nuget.org/packages/NugetExampleProject/)
[![Coverage Status](https://img.shields.io/codecov/c/github/ajwgroup/NugetExampleProject.svg?logo=codecov&style=flat-square)](https://codecov.io/gh/ajwgroup/NugetExampleProject)
[![Last commit](https://img.shields.io/github/last-commit/ajwgroup/NugetExampleProject.svg?style=flat-square)](https://github.com/ajwgroup/NugetExampleProject)