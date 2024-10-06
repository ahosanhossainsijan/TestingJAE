pipeline {

    agent any

    tools {

        dotnetsdk 'dotnet'

    }

    stages {

        stage('Restore') {

            steps {

                sh 'dotnet restore'

            }

        }

        stage('Build') {

            steps {

                sh 'dotnet build --no-restore'

            }

        }

        stage('Test') {

            steps {

                sh 'dotnet test --no-build'

            }

        }

    }

}
 