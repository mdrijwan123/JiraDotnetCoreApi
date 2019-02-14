pipeline {
           agent any
           stages {
                stage("Compile stage") {
                     steps {
                          sh "dotnet clean;dotnet restore;dotnet build"                       
                     }
                }
           }
      }


