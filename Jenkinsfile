pipeline {
    agent any

    tools {
        dotnetsdk 'dotnet'
    }

    stages {
        stage('Restore') {
            steps {
                script {
                    bat 'dotnet restore'
                }
            }
        }

        stage('Build') {
            steps {
                script {
                    bat 'dotnet build --no-restore'
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    bat 'dotnet test --no-build'
                }
            }
        }
    }
}
